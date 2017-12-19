using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ReCLI.Decompile;
using Mono.Cecil;
using Mono.Cecil.Cil;
using FastColoredTextBoxNS;
using ICSharpCode.Decompiler;

namespace ReCLI
{
    public partial class Form_Main : Form
    {
        #region Init
        public Form_Main()
        {
            InitializeComponent();
            Log log = new Log(RichTextBox_Log);
        }
        #endregion

        #region Methods
        private static string FindAssembly()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Assemblies (*.exe, *.dll) | *.exe; *.dll";
            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;
            else
                return null;
        }
        private static void LoadMethod(MethodDefinition methodDefinition, DataGridView dataGridView, FastColoredTextBox fastColoredTextBox)
        {
            if (!methodDefinition.IsAbstract)
            {
                LoadInstructions(methodDefinition, dataGridView);

                fastColoredTextBox.Clear();
                fastColoredTextBox.Text = LoadCode(methodDefinition);
            }
        }
        private static void LoadInstructions(MethodDefinition methodDefinition, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (Instruction instruction in methodDefinition.Body.Instructions)
                dataGridView.Rows.Add(instruction.Offset, instruction.OpCode, instruction.Operand);
        }
        private static string LoadCode(MethodDefinition methodDefinition)
        {
            string code = "";

            foreach (VariableDefinition variableDefinition in methodDefinition.Body.Variables)
                code += String.Format("{0} {1};{2}", variableDefinition.VariableType.Name, variableDefinition.Name, Environment.NewLine);

            foreach (Instruction instruction in methodDefinition.Body.Instructions)
            {
                OpCode opCode = instruction.OpCode;
                MessageBox.Show(instruction.OpCode.OperandType.ToString());
                if (Decompile.InstructionHelper.IsStore(opCode.Code))
                {
                    code += String.Format("{0} = {1};{2}", instruction.Operand, GetValueOf(instruction.Previous), Environment.NewLine);
                }
                else if (opCode.Code == Code.Ret)
                {
                    if (Decompile.InstructionHelper.IsLoad(instruction.Previous.OpCode.Code))
                        code += String.Format("return {0};{1}", GetValueOf(instruction.Previous), Environment.NewLine);
                    else
                        code += "return;" + Environment.NewLine;
                }
                else
                {
                    code += String.Format("{0}: {1} {2}{3}", instruction.Offset, instruction.OpCode, instruction.Operand, Environment.NewLine);
                }

            }

            return code;
        }
        public static string GetValueOf(Instruction instruction)
        {
            var code = instruction.OpCode.Code;
            // Check if we are trying to load a value
            // Can be, Load a field, load a constant value, argument
            // variable and more.
            if (Decompile.InstructionHelper.IsLoad(code))
            {

                // Check if we want to return a null value
                if (Decompile.InstructionHelper.IsLoadNull(instruction.OpCode.Code))
                    return "null";

                // For now, we will settle with just handling integers.
                // We will have to add more if checks later to support
                // strings, variables, etc.
                if (Decompile.InstructionHelper.IsLoadInteger(code))
                {
                    // In case the integer is bigger than 4
                    // We will need to get the value from the
                    // operand instead of the "index".
                    if (Decompile.InstructionHelper.IsLoadN(code))
                    {
                        return instruction.Operand.ToString();
                    }
                    else
                    {
                        // The GetCodeIndex will return the value used from
                        // the constant load. For instance ldc.i4.4 will return
                        // the value 4, ldc.i4.3 will return value 3. Etc.
                        return Decompile.InstructionHelper.GetCodeIndex(code).ToString();
                    }
                }
            }

            // If our instructions are to call a method
            if (Decompile.InstructionHelper.IsCallMethod(code))
            {
                // We will need to grab the information of that specific method
                // By casting the Operand into a MethodDefinition.
                var callingMethod = instruction.Operand as MethodDefinition;
                // Note: We are not managing any parameters yet.
                return callingMethod.Name + "()";
            }
            // Return a empty value if we can't determine what we want to return.
            return "";
        }
        private static string GetCode(MethodDefinition methodDefinition)
        {
            try
            {
                var csharpLanguage = new CSharpLanguage();
                var textOutput = new PlainTextOutput();
                var decompilationOptions = new DecompilationOptions();
                decompilationOptions.FullDecompilation = true;
                csharpLanguage.DecompileMethod(methodDefinition, textOutput, decompilationOptions);
                return textOutput.ToString();

            }
            catch (Exception exception)
            {
                //PublicDI.log.error("in getSourceCode: {0}", new object[] { exception.Message });
                return ("Error in creating source code from IL: " + exception.Message);
            }
        }
        #endregion

        #region Events
        #region MenuStrip_Main
        #region Assembly
        private void ToolStripMenuItem_Assembly_Load_Click(object sender, EventArgs e)
        {
            string path = FindAssembly();
            if (path == null)
                return;
            else
                Decompile.Decompiler.LoadAssembly(path, Decompile.Decompiler.LoadMethod.Default, TreeView_Assemblies);
        }
        private void dnLibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = FindAssembly();
            if (path == null)
                return;
            else
                Decompile.Decompiler.LoadAssembly(path, Decompile.Decompiler.LoadMethod.DnLibrary, TreeView_Assemblies);
        }
        private void monoCecilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = FindAssembly();
            if (path == null)
                return;
            else
                Decompile.Decompiler.LoadAssembly(path, Decompile.Decompiler.LoadMethod.Cecil, TreeView_Assemblies);
        }
        #endregion

        private void TreeView_Assemblies_DoubleClick(object sender, EventArgs e)
        {
            if (Decompile.Decompiler.methodDefinitions.Contains(TreeView_Assemblies.SelectedNode.Tag))
                LoadMethod((MethodDefinition)TreeView_Assemblies.SelectedNode.Tag, DataGridView_Instructions, FastColoredTextBox_Code);
        }
        #endregion
        #endregion
    }
}