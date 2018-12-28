using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfaceSelectionTool
{
    class InsetMain
    {
        private const int MAXLIST = 1000;

        /// <summary>
        /// Load the list of modules from a text file and populate the Modules drop-down field
        /// </summary>
        /// <returns>The list of items read from file: string array</returns>
        public static string[] LoadModuleList()
        {
            string[] modList;

            // within this scope, modList contains garbage characters
            // must initialize with empty string
            modList = new string[MAXLIST];
            for (int counter = 0; counter < MAXLIST; counter++)
            {
                modList[counter] = string.Empty;
            }

            if (File.Exists("modules.txt"))
            {
                try
                {
                    StreamReader modReader = new StreamReader("modules.txt");
                    modList = modReader.ReadToEnd().Split('\n');
                }

                catch (IOException)
                {
                    for (int counter = 0; counter < modList.Length; counter++)
                    {
                        modList[counter] = string.Empty;
                    }

                    throw;
                }
            }
            else
            {
                modList[0] = "-1";
                return modList;
            }

            return modList;
        }

        /// <summary>
        /// Determine if the module's directory exists
        /// </summary>
        /// <param name="moduleListItem">the module item to check</param>
        /// <returns>directory exists=true; missing=false</returns>
        public static bool ModuleDirectoryExists(string moduleListItem)
        {
            bool exists = false;

            exists = (Directory.Exists(".\\" + moduleListItem)) ? true : false;
            return exists;
        }

        /// <summary>
        /// Take the necessary scripts based on user selection and put them into specified directory
        /// </summary>
        /// <param name="destinationPath">The path the scripts are to be copied to</param>
        /// <param name="chosenModule">The module folder where files are copied from</param>
        /// <param name="chosenMode">The selected mode (import/export); a subdirectory of the module folder</param>
        /// <returns>Number of scripts retrieved</returns>
        public static int RetrieveScripts(string destinationPath, string chosenModule, string chosenMode)
        {
            FileInfo[] commonScripts;
            FileInfo[] moduleScripts;

            // TODO: arbitrary maximum list size; change later
            commonScripts = new FileInfo[1000];
            moduleScripts = new FileInfo[1000];

            // retrieve the Interface Common scripts first
            DirectoryInfo commonDir = new DirectoryInfo(@".\Common");
            if (commonDir.Exists)
            {
                Directory.SetCurrentDirectory(commonDir.ToString());
                commonScripts = commonDir.GetFiles();

                foreach (FileInfo script in commonScripts)
                {
                    if (!File.Exists(destinationPath + "\\" + script.Name))
                    {
                        try
                        {
                            File.Copy(script.FullName, Path.Combine(destinationPath, script.Name));
                        }

                        finally
                        {
                            ;
                        }
                    }
                }
            }

            Directory.SetCurrentDirectory("..");

            // retrieve the module scritps next
            DirectoryInfo moduleDir = new DirectoryInfo(".\\" + chosenModule + "\\" + chosenMode);
            if (moduleDir.Exists)
            {
                Directory.SetCurrentDirectory(moduleDir.ToString());
                moduleScripts = moduleDir.GetFiles();

                foreach (FileInfo script in moduleScripts)
                {
                    if (!File.Exists(destinationPath + "\\" + script.Name))
                    {
                        try
                        {
                            File.Copy(script.FullName, Path.Combine(destinationPath, script.Name));
                        }

                        finally
                        {
                            ;
                        }
                        
                    }
                }
            }

            return 0;
        }
    }
}
