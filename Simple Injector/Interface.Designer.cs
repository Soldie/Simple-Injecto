namespace Simple_Injector
{
    partial class Interface
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
            this.closeAfterInjectCheckBox = new System.Windows.Forms.CheckBox();
            this.autoInjectCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.dllFileTextBox = new System.Windows.Forms.TextBox();
            this.injectDLLButton = new System.Windows.Forms.Button();
            this.chooseDLLButton = new System.Windows.Forms.Button();
            this.selectedProcessTextBox = new System.Windows.Forms.TextBox();
            this.dllFileLabel = new System.Windows.Forms.Label();
            this.selectedProcessLabel = new System.Windows.Forms.Label();
            this.injectorGroupBox = new System.Windows.Forms.GroupBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.processDataGrid = new System.Windows.Forms.DataGridView();
            this.OpenProcessesGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.optionsGroupBox.SuspendLayout();
            this.injectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGrid)).BeginInit();
            this.OpenProcessesGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeAfterInjectCheckBox
            // 
            this.closeAfterInjectCheckBox.AutoSize = true;
            this.closeAfterInjectCheckBox.Location = new System.Drawing.Point(5, 19);
            this.closeAfterInjectCheckBox.Name = "closeAfterInjectCheckBox";
            this.closeAfterInjectCheckBox.Size = new System.Drawing.Size(106, 17);
            this.closeAfterInjectCheckBox.TabIndex = 0;
            this.closeAfterInjectCheckBox.Text = "Close After Inject";
            this.closeAfterInjectCheckBox.UseVisualStyleBackColor = true;
            this.closeAfterInjectCheckBox.CheckedChanged += new System.EventHandler(this.CloseAfterInjectCheckBox_CheckedChanged);
            // 
            // autoInjectCheckBox
            // 
            this.autoInjectCheckBox.AutoSize = true;
            this.autoInjectCheckBox.Location = new System.Drawing.Point(5, 43);
            this.autoInjectCheckBox.Name = "autoInjectCheckBox";
            this.autoInjectCheckBox.Size = new System.Drawing.Size(77, 17);
            this.autoInjectCheckBox.TabIndex = 1;
            this.autoInjectCheckBox.Text = "Auto Inject";
            this.autoInjectCheckBox.UseVisualStyleBackColor = true;
            this.autoInjectCheckBox.CheckedChanged += new System.EventHandler(this.AutoInjectCheckBox_CheckedChanged);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.autoInjectCheckBox);
            this.optionsGroupBox.Controls.Add(this.closeAfterInjectCheckBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(220, 229);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(192, 71);
            this.optionsGroupBox.TabIndex = 4;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // dllFileTextBox
            // 
            this.dllFileTextBox.Location = new System.Drawing.Point(5, 35);
            this.dllFileTextBox.Name = "dllFileTextBox";
            this.dllFileTextBox.ReadOnly = true;
            this.dllFileTextBox.Size = new System.Drawing.Size(182, 20);
            this.dllFileTextBox.TabIndex = 0;
            // 
            // injectDLLButton
            // 
            this.injectDLLButton.Location = new System.Drawing.Point(98, 125);
            this.injectDLLButton.Name = "injectDLLButton";
            this.injectDLLButton.Size = new System.Drawing.Size(89, 23);
            this.injectDLLButton.TabIndex = 1;
            this.injectDLLButton.Text = "Inject DLL";
            this.injectDLLButton.UseVisualStyleBackColor = true;
            this.injectDLLButton.Click += new System.EventHandler(this.InjectDLLButton_Click);
            // 
            // chooseDLLButton
            // 
            this.chooseDLLButton.Location = new System.Drawing.Point(5, 125);
            this.chooseDLLButton.Name = "chooseDLLButton";
            this.chooseDLLButton.Size = new System.Drawing.Size(89, 23);
            this.chooseDLLButton.TabIndex = 2;
            this.chooseDLLButton.Text = "Choose DLL";
            this.chooseDLLButton.UseVisualStyleBackColor = true;
            this.chooseDLLButton.Click += new System.EventHandler(this.ChooseDLLButton_Click);
            // 
            // selectedProcessTextBox
            // 
            this.selectedProcessTextBox.Location = new System.Drawing.Point(5, 85);
            this.selectedProcessTextBox.Name = "selectedProcessTextBox";
            this.selectedProcessTextBox.ReadOnly = true;
            this.selectedProcessTextBox.Size = new System.Drawing.Size(182, 20);
            this.selectedProcessTextBox.TabIndex = 3;
            // 
            // dllFileLabel
            // 
            this.dllFileLabel.AutoSize = true;
            this.dllFileLabel.Location = new System.Drawing.Point(2, 19);
            this.dllFileLabel.Name = "dllFileLabel";
            this.dllFileLabel.Size = new System.Drawing.Size(46, 13);
            this.dllFileLabel.TabIndex = 4;
            this.dllFileLabel.Text = "DLL File\r\n";
            // 
            // selectedProcessLabel
            // 
            this.selectedProcessLabel.AutoSize = true;
            this.selectedProcessLabel.Location = new System.Drawing.Point(2, 69);
            this.selectedProcessLabel.Name = "selectedProcessLabel";
            this.selectedProcessLabel.Size = new System.Drawing.Size(90, 13);
            this.selectedProcessLabel.TabIndex = 5;
            this.selectedProcessLabel.Text = "Selected Process";
            // 
            // injectorGroupBox
            // 
            this.injectorGroupBox.Controls.Add(this.selectedProcessLabel);
            this.injectorGroupBox.Controls.Add(this.dllFileLabel);
            this.injectorGroupBox.Controls.Add(this.selectedProcessTextBox);
            this.injectorGroupBox.Controls.Add(this.chooseDLLButton);
            this.injectorGroupBox.Controls.Add(this.injectDLLButton);
            this.injectorGroupBox.Controls.Add(this.dllFileTextBox);
            this.injectorGroupBox.Location = new System.Drawing.Point(220, 75);
            this.injectorGroupBox.Name = "injectorGroupBox";
            this.injectorGroupBox.Size = new System.Drawing.Size(192, 153);
            this.injectorGroupBox.TabIndex = 2;
            this.injectorGroupBox.TabStop = false;
            this.injectorGroupBox.Text = "Injector";
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "Dynamic Link Library (*.dll)| *.dll";
            this.FileDialog.InitialDirectory = "@\"C:\\\"";
            this.FileDialog.Title = "Select a DLL File";
            // 
            // processDataGrid
            // 
            this.processDataGrid.AllowUserToAddRows = false;
            this.processDataGrid.AllowUserToDeleteRows = false;
            this.processDataGrid.AllowUserToResizeColumns = false;
            this.processDataGrid.AllowUserToResizeRows = false;
            this.processDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.processDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.processDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.processDataGrid.Location = new System.Drawing.Point(6, 19);
            this.processDataGrid.Name = "processDataGrid";
            this.processDataGrid.ReadOnly = true;
            this.processDataGrid.RowHeadersVisible = false;
            this.processDataGrid.ShowCellErrors = false;
            this.processDataGrid.ShowEditingIcon = false;
            this.processDataGrid.ShowRowErrors = false;
            this.processDataGrid.Size = new System.Drawing.Size(188, 379);
            this.processDataGrid.TabIndex = 0;
            this.processDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessDataGrid_CellDoubleClick);
            // 
            // OpenProcessesGroupBox
            // 
            this.OpenProcessesGroupBox.Controls.Add(this.processDataGrid);
            this.OpenProcessesGroupBox.Location = new System.Drawing.Point(13, 75);
            this.OpenProcessesGroupBox.Name = "OpenProcessesGroupBox";
            this.OpenProcessesGroupBox.Size = new System.Drawing.Size(200, 404);
            this.OpenProcessesGroupBox.TabIndex = 1;
            this.OpenProcessesGroupBox.TabStop = false;
            this.OpenProcessesGroupBox.Text = "Open Processes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 71);
            this.panel1.TabIndex = 0;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.StatusLabel);
            this.statusGroupBox.Location = new System.Drawing.Point(220, 301);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(192, 178);
            this.statusGroupBox.TabIndex = 3;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(6, 16);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 0;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 491);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.injectorGroupBox);
            this.Controls.Add(this.OpenProcessesGroupBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.Text = "Simple Injector";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.injectorGroupBox.ResumeLayout(false);
            this.injectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGrid)).EndInit();
            this.OpenProcessesGroupBox.ResumeLayout(false);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox closeAfterInjectCheckBox;
        private System.Windows.Forms.CheckBox autoInjectCheckBox;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.TextBox dllFileTextBox;
        private System.Windows.Forms.Button injectDLLButton;
        private System.Windows.Forms.Button chooseDLLButton;
        private System.Windows.Forms.TextBox selectedProcessTextBox;
        private System.Windows.Forms.Label dllFileLabel;
        private System.Windows.Forms.Label selectedProcessLabel;
        private System.Windows.Forms.GroupBox injectorGroupBox;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.DataGridView processDataGrid;
        private System.Windows.Forms.GroupBox OpenProcessesGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.Label StatusLabel;
    }
}

