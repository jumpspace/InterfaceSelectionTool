using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceSelectionTool
{
    public partial class InsetDirDialog : Form
    {
        private string scriptPath;

        /// <summary>
        /// Default no-argument constructor. Destination path is blank
        /// </summary>
        public InsetDirDialog()
        {
            InitializeComponent();
            FolderPathTextBox.Text = String.Empty;
        }

        /// <summary>
        /// Constructor that populates the destination path
        /// </summary>
        /// <param name="folderPath">The folder path where the files are placed</param>
        public InsetDirDialog(string folderPath)
        {
            InitializeComponent();
            FolderPathTextBox.Text = folderPath;
            scriptPath = string.Empty;
        }

        public string ScriptPath => scriptPath;

        private void DirFolderButton_Click(object sender, EventArgs e)
        {
            ReceivingFolderDialog.Description = "Select the folder the scripts are to be downloaded";
            ReceivingFolderDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            DialogResult folderResult = ReceivingFolderDialog.ShowDialog();
            if (folderResult == DialogResult.OK)
            {
                FolderPathTextBox.Text = ReceivingFolderDialog.SelectedPath;
                scriptPath = ReceivingFolderDialog.SelectedPath;
            }
        }
    }
}
