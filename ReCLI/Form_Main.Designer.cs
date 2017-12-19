namespace ReCLI
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.assemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Assembly_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.dnLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monoCecilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Assembly_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.SmoothSplitContainer_Main = new ReCLI.SmoothSplitContainer();
            this.SmoothSplitContainer_Secondary = new ReCLI.SmoothSplitContainer();
            this.TreeView_Assemblies = new System.Windows.Forms.TreeView();
            this.SmoothSplitContainer_Tertiary = new ReCLI.SmoothSplitContainer();
            this.FastColoredTextBox_Code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DataGridView_Instructions = new System.Windows.Forms.DataGridView();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_RichTextBoxFlat = new System.Windows.Forms.Panel();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.MenuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothSplitContainer_Main)).BeginInit();
            this.SmoothSplitContainer_Main.Panel1.SuspendLayout();
            this.SmoothSplitContainer_Main.Panel2.SuspendLayout();
            this.SmoothSplitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothSplitContainer_Secondary)).BeginInit();
            this.SmoothSplitContainer_Secondary.Panel1.SuspendLayout();
            this.SmoothSplitContainer_Secondary.Panel2.SuspendLayout();
            this.SmoothSplitContainer_Secondary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothSplitContainer_Tertiary)).BeginInit();
            this.SmoothSplitContainer_Tertiary.Panel1.SuspendLayout();
            this.SmoothSplitContainer_Tertiary.Panel2.SuspendLayout();
            this.SmoothSplitContainer_Tertiary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Instructions)).BeginInit();
            this.Panel_RichTextBoxFlat.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assemblyToolStripMenuItem});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(685, 24);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // assemblyToolStripMenuItem
            // 
            this.assemblyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Assembly_Load,
            this.ToolStripMenuItem_Assembly_Close});
            this.assemblyToolStripMenuItem.Name = "assemblyToolStripMenuItem";
            this.assemblyToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.assemblyToolStripMenuItem.Text = "Assembly";
            // 
            // ToolStripMenuItem_Assembly_Load
            // 
            this.ToolStripMenuItem_Assembly_Load.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnLibToolStripMenuItem,
            this.monoCecilToolStripMenuItem});
            this.ToolStripMenuItem_Assembly_Load.Name = "ToolStripMenuItem_Assembly_Load";
            this.ToolStripMenuItem_Assembly_Load.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItem_Assembly_Load.Text = "Load";
            this.ToolStripMenuItem_Assembly_Load.Click += new System.EventHandler(this.ToolStripMenuItem_Assembly_Load_Click);
            // 
            // dnLibToolStripMenuItem
            // 
            this.dnLibToolStripMenuItem.Name = "dnLibToolStripMenuItem";
            this.dnLibToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.dnLibToolStripMenuItem.Text = "dnlib - 0xd4d";
            this.dnLibToolStripMenuItem.Click += new System.EventHandler(this.dnLibToolStripMenuItem_Click);
            // 
            // monoCecilToolStripMenuItem
            // 
            this.monoCecilToolStripMenuItem.Name = "monoCecilToolStripMenuItem";
            this.monoCecilToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.monoCecilToolStripMenuItem.Text = "Mono.Cecil - Jb Evain (Default)";
            this.monoCecilToolStripMenuItem.Click += new System.EventHandler(this.monoCecilToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Assembly_Close
            // 
            this.ToolStripMenuItem_Assembly_Close.Enabled = false;
            this.ToolStripMenuItem_Assembly_Close.Name = "ToolStripMenuItem_Assembly_Close";
            this.ToolStripMenuItem_Assembly_Close.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItem_Assembly_Close.Text = "Close";
            // 
            // SmoothSplitContainer_Main
            // 
            this.SmoothSplitContainer_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.SmoothSplitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SmoothSplitContainer_Main.Location = new System.Drawing.Point(0, 24);
            this.SmoothSplitContainer_Main.Name = "SmoothSplitContainer_Main";
            this.SmoothSplitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SmoothSplitContainer_Main.Panel1
            // 
            this.SmoothSplitContainer_Main.Panel1.Controls.Add(this.SmoothSplitContainer_Secondary);
            // 
            // SmoothSplitContainer_Main.Panel2
            // 
            this.SmoothSplitContainer_Main.Panel2.Controls.Add(this.Panel_RichTextBoxFlat);
            this.SmoothSplitContainer_Main.Size = new System.Drawing.Size(685, 501);
            this.SmoothSplitContainer_Main.SplitterDistance = 436;
            this.SmoothSplitContainer_Main.TabIndex = 3;
            // 
            // SmoothSplitContainer_Secondary
            // 
            this.SmoothSplitContainer_Secondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SmoothSplitContainer_Secondary.Location = new System.Drawing.Point(0, 0);
            this.SmoothSplitContainer_Secondary.Name = "SmoothSplitContainer_Secondary";
            // 
            // SmoothSplitContainer_Secondary.Panel1
            // 
            this.SmoothSplitContainer_Secondary.Panel1.Controls.Add(this.TreeView_Assemblies);
            // 
            // SmoothSplitContainer_Secondary.Panel2
            // 
            this.SmoothSplitContainer_Secondary.Panel2.Controls.Add(this.SmoothSplitContainer_Tertiary);
            this.SmoothSplitContainer_Secondary.Size = new System.Drawing.Size(685, 436);
            this.SmoothSplitContainer_Secondary.SplitterDistance = 227;
            this.SmoothSplitContainer_Secondary.TabIndex = 2;
            // 
            // TreeView_Assemblies
            // 
            this.TreeView_Assemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView_Assemblies.Location = new System.Drawing.Point(0, 0);
            this.TreeView_Assemblies.Name = "TreeView_Assemblies";
            this.TreeView_Assemblies.Size = new System.Drawing.Size(227, 436);
            this.TreeView_Assemblies.TabIndex = 1;
            this.TreeView_Assemblies.DoubleClick += new System.EventHandler(this.TreeView_Assemblies_DoubleClick);
            // 
            // SmoothSplitContainer_Tertiary
            // 
            this.SmoothSplitContainer_Tertiary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SmoothSplitContainer_Tertiary.Location = new System.Drawing.Point(0, 0);
            this.SmoothSplitContainer_Tertiary.Name = "SmoothSplitContainer_Tertiary";
            this.SmoothSplitContainer_Tertiary.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SmoothSplitContainer_Tertiary.Panel1
            // 
            this.SmoothSplitContainer_Tertiary.Panel1.Controls.Add(this.FastColoredTextBox_Code);
            // 
            // SmoothSplitContainer_Tertiary.Panel2
            // 
            this.SmoothSplitContainer_Tertiary.Panel2.Controls.Add(this.DataGridView_Instructions);
            this.SmoothSplitContainer_Tertiary.Size = new System.Drawing.Size(454, 436);
            this.SmoothSplitContainer_Tertiary.SplitterDistance = 303;
            this.SmoothSplitContainer_Tertiary.TabIndex = 2;
            // 
            // FastColoredTextBox_Code
            // 
            this.FastColoredTextBox_Code.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.FastColoredTextBox_Code.BackBrush = null;
            this.FastColoredTextBox_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastColoredTextBox_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastColoredTextBox_Code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastColoredTextBox_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FastColoredTextBox_Code.Language = FastColoredTextBoxNS.Language.CSharp;
            this.FastColoredTextBox_Code.Location = new System.Drawing.Point(0, 0);
            this.FastColoredTextBox_Code.Name = "FastColoredTextBox_Code";
            this.FastColoredTextBox_Code.Paddings = new System.Windows.Forms.Padding(0);
            this.FastColoredTextBox_Code.ReadOnly = true;
            this.FastColoredTextBox_Code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastColoredTextBox_Code.Size = new System.Drawing.Size(454, 303);
            this.FastColoredTextBox_Code.TabIndex = 1;
            // 
            // DataGridView_Instructions
            // 
            this.DataGridView_Instructions.AllowUserToAddRows = false;
            this.DataGridView_Instructions.AllowUserToDeleteRows = false;
            this.DataGridView_Instructions.AllowUserToOrderColumns = true;
            this.DataGridView_Instructions.AllowUserToResizeColumns = false;
            this.DataGridView_Instructions.AllowUserToResizeRows = false;
            this.DataGridView_Instructions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView_Instructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Instructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offset,
            this.OpCode,
            this.Operand});
            this.DataGridView_Instructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Instructions.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Instructions.Name = "DataGridView_Instructions";
            this.DataGridView_Instructions.ReadOnly = true;
            this.DataGridView_Instructions.Size = new System.Drawing.Size(454, 129);
            this.DataGridView_Instructions.TabIndex = 0;
            // 
            // Offset
            // 
            this.Offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            this.Offset.Width = 60;
            // 
            // OpCode
            // 
            this.OpCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OpCode.HeaderText = "OpCode";
            this.OpCode.Name = "OpCode";
            this.OpCode.ReadOnly = true;
            this.OpCode.Width = 71;
            // 
            // Operand
            // 
            this.Operand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operand.HeaderText = "Operand";
            this.Operand.Name = "Operand";
            this.Operand.ReadOnly = true;
            // 
            // Panel_RichTextBoxFlat
            // 
            this.Panel_RichTextBoxFlat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_RichTextBoxFlat.Controls.Add(this.RichTextBox_Log);
            this.Panel_RichTextBoxFlat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_RichTextBoxFlat.Location = new System.Drawing.Point(0, 0);
            this.Panel_RichTextBoxFlat.Name = "Panel_RichTextBoxFlat";
            this.Panel_RichTextBoxFlat.Size = new System.Drawing.Size(685, 61);
            this.Panel_RichTextBoxFlat.TabIndex = 0;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Log.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Log.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.ReadOnly = true;
            this.RichTextBox_Log.Size = new System.Drawing.Size(683, 59);
            this.RichTextBox_Log.TabIndex = 0;
            this.RichTextBox_Log.Text = "Log:\n";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 525);
            this.Controls.Add(this.SmoothSplitContainer_Main);
            this.Controls.Add(this.MenuStrip_Main);
            this.MainMenuStrip = this.MenuStrip_Main;
            this.Name = "Form_Main";
            this.Text = "ReCLI";
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.SmoothSplitContainer_Main.Panel1.ResumeLayout(false);
            this.SmoothSplitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SmoothSplitContainer_Main)).EndInit();
            this.SmoothSplitContainer_Main.ResumeLayout(false);
            this.SmoothSplitContainer_Secondary.Panel1.ResumeLayout(false);
            this.SmoothSplitContainer_Secondary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SmoothSplitContainer_Secondary)).EndInit();
            this.SmoothSplitContainer_Secondary.ResumeLayout(false);
            this.SmoothSplitContainer_Tertiary.Panel1.ResumeLayout(false);
            this.SmoothSplitContainer_Tertiary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SmoothSplitContainer_Tertiary)).EndInit();
            this.SmoothSplitContainer_Tertiary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Instructions)).EndInit();
            this.Panel_RichTextBoxFlat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Assembly_Load;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Assembly_Close;
        private System.Windows.Forms.ToolStripMenuItem dnLibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monoCecilToolStripMenuItem;
        private SmoothSplitContainer SmoothSplitContainer_Secondary;
        private System.Windows.Forms.TreeView TreeView_Assemblies;
        private FastColoredTextBoxNS.FastColoredTextBox FastColoredTextBox_Code;
        private SmoothSplitContainer SmoothSplitContainer_Main;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
        private System.Windows.Forms.Panel Panel_RichTextBoxFlat;
        private SmoothSplitContainer SmoothSplitContainer_Tertiary;
        private System.Windows.Forms.DataGridView DataGridView_Instructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operand;
    }
}

