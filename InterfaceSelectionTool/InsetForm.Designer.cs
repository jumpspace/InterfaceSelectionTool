namespace InterfaceSelectionTool
{
    partial class FrmInset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInset));
            this.IntroTextLabel = new System.Windows.Forms.Label();
            this.ModuleLabel = new System.Windows.Forms.Label();
            this.ModuleComboBox = new System.Windows.Forms.ComboBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroTextLabel
            // 
            this.IntroTextLabel.AutoSize = true;
            this.IntroTextLabel.Location = new System.Drawing.Point(13, 13);
            this.IntroTextLabel.Name = "IntroTextLabel";
            this.IntroTextLabel.Size = new System.Drawing.Size(463, 13);
            this.IntroTextLabel.TabIndex = 0;
            this.IntroTextLabel.Text = "This tool selects for you the scripts required to start creating an interface bas" +
    "ed on your selection.";
            // 
            // ModuleLabel
            // 
            this.ModuleLabel.AutoSize = true;
            this.ModuleLabel.Location = new System.Drawing.Point(16, 53);
            this.ModuleLabel.Name = "ModuleLabel";
            this.ModuleLabel.Size = new System.Drawing.Size(45, 13);
            this.ModuleLabel.TabIndex = 1;
            this.ModuleLabel.Text = "Module:";
            // 
            // ModuleComboBox
            // 
            this.ModuleComboBox.FormattingEnabled = true;
            this.ModuleComboBox.Location = new System.Drawing.Point(67, 50);
            this.ModuleComboBox.Name = "ModuleComboBox";
            this.ModuleComboBox.Size = new System.Drawing.Size(221, 21);
            this.ModuleComboBox.TabIndex = 2;
            this.ModuleComboBox.SelectedIndexChanged += new System.EventHandler(this.ModuleComboBox_SelectedIndexChanged);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(19, 84);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(37, 13);
            this.ModeLabel.TabIndex = 3;
            this.ModeLabel.Text = "Mode:";
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Items.AddRange(new object[] {
            "Import",
            "Export"});
            this.ModeComboBox.Location = new System.Drawing.Point(67, 81);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(147, 21);
            this.ModeComboBox.TabIndex = 4;
            this.ModeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeComboBox_SelectedIndexChanged);
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.Location = new System.Drawing.Point(67, 175);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(93, 39);
            this.RetrieveButton.TabIndex = 5;
            this.RetrieveButton.Text = "&Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = true;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(383, 175);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 39);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Location = new System.Drawing.Point(22, 114);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(121, 13);
            this.FolderPathLabel.TabIndex = 8;
            this.FolderPathLabel.Text = "[Folder Path Goes Here]";
            // 
            // FrmInset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 226);
            this.Controls.Add(this.FolderPathLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.ModeComboBox);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.ModuleComboBox);
            this.Controls.Add(this.ModuleLabel);
            this.Controls.Add(this.IntroTextLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInset";
            this.Text = "FDM Interface Selection Tool";
            this.Load += new System.EventHandler(this.FrmInset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IntroTextLabel;
        private System.Windows.Forms.Label ModuleLabel;
        private System.Windows.Forms.ComboBox ModuleComboBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label FolderPathLabel;
    }
}

