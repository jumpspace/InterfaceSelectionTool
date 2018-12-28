namespace InterfaceSelectionTool
{
    partial class InsetDirDialog
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
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.DirFolderButton = new System.Windows.Forms.Button();
            this.ReceivingFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(26, 20);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(108, 13);
            this.DestinationLabel.TabIndex = 0;
            this.DestinationLabel.Text = "Destination Directory:";
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(29, 45);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(303, 20);
            this.FolderPathTextBox.TabIndex = 1;
            // 
            // DirFolderButton
            // 
            this.DirFolderButton.Location = new System.Drawing.Point(331, 45);
            this.DirFolderButton.Name = "DirFolderButton";
            this.DirFolderButton.Size = new System.Drawing.Size(25, 20);
            this.DirFolderButton.TabIndex = 2;
            this.DirFolderButton.Text = "...";
            this.DirFolderButton.UseVisualStyleBackColor = true;
            this.DirFolderButton.Click += new System.EventHandler(this.DirFolderButton_Click);
            // 
            // ReceivingFolderDialog
            // 
            this.ReceivingFolderDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(198, 123);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(80, 28);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "&OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Location = new System.Drawing.Point(284, 124);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(80, 27);
            this.CancelDialogButton.TabIndex = 4;
            this.CancelDialogButton.Text = "&Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            // 
            // InsetDirDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelDialogButton;
            this.ClientSize = new System.Drawing.Size(376, 163);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DirFolderButton);
            this.Controls.Add(this.FolderPathTextBox);
            this.Controls.Add(this.DestinationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsetDirDialog";
            this.Text = "Interface Selection Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Button DirFolderButton;
        private System.Windows.Forms.FolderBrowserDialog ReceivingFolderDialog;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelDialogButton;
    }
}