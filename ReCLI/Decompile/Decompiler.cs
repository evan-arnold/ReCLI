using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Text;
using Mono.Cecil;
using dnlib;
using System.Collections.Generic;
using System.Linq;

namespace ReCLI.Decompile
{
    /*
     * Reference:
     * http://www.codeandux.com/writing-a-simple-decompiler-for-net-part-1/
     * https://ubbecode.wordpress.com/2014/05/03/dnspy-more-powerful-net-decompiler/
     * https://github.com/0xd4d/dnlib
     */

    public class Decompiler
    {
        public static List<MethodDefinition> methodDefinitions = new List<MethodDefinition>();

        public static void LoadAssembly(string path, int method, TreeView treeView)
        {
            if(method == LoadMethod.Cecil)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    methodDefinitions.Clear();
                    AssemblyDefinition assemblyDefinition = AssemblyDefinition.ReadAssembly(sr.BaseStream);
                    TreeNode tNode = new TreeNode();
                    tNode.Tag = assemblyDefinition;
                    foreach (ModuleDefinition moduleDefinition in assemblyDefinition.Modules)
                    {
                        tNode.Text = moduleDefinition.Name;
                        foreach(TypeDefinition typeDefinition in moduleDefinition.GetTypes())
                        {
                            if (typeDefinition.Name == "<Module>") 
                                continue;

                            TreeNode typeNode = new TreeNode();
                            typeNode.Text = GetTypeDecleration(typeDefinition);
                            typeNode.Tag = typeDefinition;
                            tNode.Nodes.Add(typeNode);

                            foreach (MethodDefinition methodDefinition in typeDefinition.Methods)
                            {
                                TreeNode methodNode = new TreeNode();
                                methodNode.Text = GetMethodDecleration(methodDefinition);
                                methodNode.Tag = methodDefinition;
                                typeNode.Nodes.Add(methodNode);

                                methodDefinitions.Add(methodDefinition);
                            }

                            foreach (FieldDefinition fieldDefinition in typeDefinition.Fields)
                            {
                                TreeNode fieldNode = new TreeNode();
                                fieldNode.Text = GetFieldDecleration(fieldDefinition);
                                fieldNode.Tag = fieldDefinition;
                                typeNode.Nodes.Add(fieldNode);
                            }
                        }
                    }
                    treeView.Nodes.Add(tNode);
                }
            }
            else if(method == LoadMethod.DnLibrary)
            {

            }
        }

        public static void ListInstructions(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

        }

        private static string GetMethodDecleration(MethodDefinition methodDefinition)
        {
            var output = (methodDefinition.IsPublic ? "public " : "private ") +
                            (methodDefinition.IsStatic ? "static " : "") +
                            (methodDefinition.IsAbstract ? "abstract " : "");

            if (methodDefinition.IsConstructor)
            {
                output += methodDefinition.MethodReturnType.ReturnType.Name + " " + methodDefinition.DeclaringType.Name;
            }
            else
            {
                output += methodDefinition.MethodReturnType.ReturnType.Name + " " + methodDefinition.Name;
            }

            if (methodDefinition.HasParameters)
            {
                var parameters = new List<string>();
                foreach (var parameter in methodDefinition.Parameters)
                {
                    parameters.Add(parameter.ParameterType.Name + " " + parameter.Name);
                }
                return output + "(" + string.Join(",", parameters) + ")";
            }

            return output + "()";
        }
        private static string GetFieldDecleration(FieldDefinition fieldDefinition)
        {
            var output = (fieldDefinition.IsPublic ? "public " : "private ") +
                         (fieldDefinition.IsStatic ? "static " : "");

            return output + fieldDefinition.FieldType + " " + fieldDefinition.Name;
        }
        private static string GetTypeDecleration(TypeDefinition typeDefinition)
        {
            var output = (typeDefinition.IsPublic ? "public " : "private ") +
                            (typeDefinition.IsSealed ? "sealed " : "") +
                            (typeDefinition.IsAbstract ? "abstract " : "") +
                            (typeDefinition.IsInterface ? "interface " : "") +
                            (typeDefinition.IsEnum ? "enum " : "") +
                            (typeDefinition.IsClass ? "class " : "");

            if (typeDefinition.HasGenericParameters)
            {
                var parameters = typeDefinition.GenericParameters.Select(t => t.Name).ToList();
                if (parameters.Count > 0)
                    return output + (typeDefinition.Name.Replace("`1", "")) + "<" + string.Join(",", parameters) + ">";
            }

            return output + typeDefinition.Name;
        }

        public struct LoadMethod
        {
            public const int Cecil = 0;
            public const int DnLibrary = 1;
            public static int Default = Cecil;
        }
    }


}