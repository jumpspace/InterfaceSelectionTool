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
    public partial class FrmInset : Form
    {
        const int MAXLIST = 1000;
        private string downloadPath;
        private string selectedModule;
        private string selectedMode;

        public FrmInset()
        {
            InitializeComponent();
            downloadPath = string.Empty;
            selectedModule = string.Empty;
        }

        private void FrmInset_Load(object sender, EventArgs e)
        {
            string[] fileModules;

            fileModules = new string[MAXLIST];
            try
            {
                fileModules = InsetMain.LoadModuleList();
            }

            catch (OutOfMemoryException memEx)
            {
                MessageBox.Show("Unable to read list of modules; Out of Memory; " + memEx.GetType().ToString(), 
                    "Interface Selection Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RetrieveButton.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace + "; " + ex.GetType().ToString(), 
                    "Interface Selection Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RetrieveButton.Enabled = false;
            }
            
            if (fileModules[0] == "-1")
            {
                MessageBox.Show("Unable to load Modules List: Modules file cannot be found.",
                        "Interface Selection Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ModuleComboBox.Enabled = false;
                ModeComboBox.Enabled = false;
                RetrieveButton.Enabled = false;
                fileModules[0] = string.Empty;
            }

            if (fileModules.Length >  0 && fileModules[0] != "-1")
            {
                foreach(string listItem in fileModules)
                {
                    if (InsetMain.ModuleDirectoryExists(listItem))
                    {
                        ModuleComboBox.Items.Add(listItem);
                    }
                }
            }

            selectedModule = ModuleComboBox.SelectedItem.ToString();
            selectedMode = ModeComboBox.SelectedItem.ToString();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            InsetDirDialog dirDialog = new InsetDirDialog();
            DialogResult pathResult = dirDialog.ShowDialog();
            if (pathResult == DialogResult.OK)
            {
                downloadPath = dirDialog.ScriptPath;
            }

            FolderPathLabel.Text = "Retrieve scripts from: " + downloadPath;
            if (selectedModule == string.Empty)
            {
                // arbitrarily set a module if none is selected
                selectedModule = ModuleComboBox.Items[0].ToString();
            }

            if (selectedMode == string.Empty)
            {
                // arbitrarily set a mode if none is selected
                selectedMode = ModeComboBox.Items[0].ToString();
            }
            try
            {
                InsetMain.RetrieveScripts(downloadPath, selectedModule, selectedMode);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), 
                    "Interface Selection Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ModuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedModule = ModuleComboBox.SelectedItem.ToString();
        }

        private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMode = ModeComboBox.SelectedItem.ToString();
        }
    }
}
