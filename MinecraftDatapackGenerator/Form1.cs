using System.Diagnostics;
using System.Reflection;

namespace MinecraftDatapackGenerator
{
    public partial class Form1 : Form
    {
        public string destination;
        public string packFormat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void selectDestination_MouseClick(object sender, MouseEventArgs e)
        {
            var folderDialogue = new FolderBrowserDialog();

            folderDialogue.Description = "The folder will be used to create the datapack contents.";
            var dialogResult = folderDialogue.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                label3.Text = folderDialogue.SelectedPath + " selected";
                destination = folderDialogue.SelectedPath;
            }
        }

        // Creates a datapack.
        void GenerateDatapack()
        {
            if (destination != null)
            {
                if (datapackNameField.Text != "")
                {
                    if (packFormatField.Text != "")
                    {
                        if (!string.IsNullOrEmpty(datapackTagField.Text))
                        {
                            try
                            {
                                // I made a variable for the datapack directory for easy access
                                var datapackMainFolder = destination + "/" + datapackNameField.Text;
                                var minecraftFunctionDirectory = datapackMainFolder + "/data/minecraft/tags/function";
                                var customFileDirectory = datapackMainFolder + "/data/" + datapackTagField.Text;
                                var customFunctionDirectory = customFileDirectory + "/function";

                                // Set variable packFormat to the one provided in the form
                                packFormat = packFormatField.Text;

                                // Create folders
                                Directory.CreateDirectory(datapackMainFolder);
                                Directory.CreateDirectory(datapackMainFolder + "/data");
                                Directory.CreateDirectory(minecraftFunctionDirectory);
                                Directory.CreateDirectory(customFunctionDirectory);

                                // Create necessary files
                                File.WriteAllText(datapackMainFolder + "/pack.mcmeta", "{\n  \"pack\": {\n    \"pack_format\": " + packFormat + ",\n    \"description\": \"" + descriptionField.Text + "\"\n  }\n}");
                                File.WriteAllText(minecraftFunctionDirectory + "/load.json", "{\n  \"values\": [\n   \"" + datapackTagField.Text + "\"   \n]\n}");

                                // Create custom function files
                                var fileLoadMCFunctionContents = "# This file was generated through the datapack generator. This will run when the world/datapack loads for the first time.\nsay \"Custom datapack loaded!\"";
                                File.WriteAllText(customFunctionDirectory + "/load.mcfunction", fileLoadMCFunctionContents);

                                // Create README file
                                File.WriteAllText(datapackMainFolder + "/README.txt", "Thank you for using the Datapack generator! You can find the functions folder by going to the data/" + datapackTagField.Text + "/function folder. If this is your first time using data packs, no need to worry! There are plenty of tutorial videos online.");

                                // Display success dialogue
                                MessageBox.Show("Created a datapack folder at " + destination + " successfully. There is a README file inside of the datapack folder. Once you're done reading it, you can delete the text file afterwards.", "Datapack Folder Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception err)
                            {
                                MessageBox.Show("Exception occured when creating data pack: " + err.Message + " - If this problem continues, create a bug report in this program's GitHub repository.", "Something went wrong.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("A tag name for your datapack is required.", "No Tag Name Specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var result = MessageBox.Show("A pack format number is required. Browse the web for the latest pack format number?", "No Pack Format Specified", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (result.Equals(DialogResult.Yes))
                        {
                            Process.Start(new ProcessStartInfo() { FileName = "https://minecraft.fandom.com/wiki/Data_Pack#Pack_format", UseShellExecute = true });
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A name for your datapack is required. Type in a name and try again.", "No Name Specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("You did not select a destination folder. Select one above and then try generating the folder again.", "No Folder Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateButton_MouseClick(object sender, MouseEventArgs e)
        {
            GenerateDatapack();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo() {FileName = "https://github.com/int3rv4lwastaken/MinecraftDatapackCreationTool/issues/new/choose", UseShellExecute = true});
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
