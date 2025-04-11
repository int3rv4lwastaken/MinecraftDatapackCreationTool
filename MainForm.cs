using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;

namespace MDCTRevised
{
    public partial class MainForm : Form
    {
        private Point mousePoint;
        private bool isMaximized = false;
        private string datapackFolderDestination;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayErrorProvider(Control control, string message)
        {
            errorProvider1.SetError(control, message);
            errorProvider1.SetIconPadding(control, 5);
        }

        private void TryCreateDirectory(string folder)
        {
            bool success;

            try
            {
                string dataFolder = folder + "\\data";
                string namespaceFolder = dataFolder + "\\" + datapackNamespaceField.Text;

                Directory.CreateDirectory(folder);
                Directory.CreateDirectory(dataFolder);
                Directory.CreateDirectory(namespaceFolder);

                Directory.CreateDirectory(dataFolder + "\\minecraft");

                // Minecraft folder files

                string minecraftFunctionTagsFolder = dataFolder + "\\minecraft\\tags\\function";

                Directory.CreateDirectory(minecraftFunctionTagsFolder);

                // Load.json
                Dictionary<string, object> loadJsonStart = new Dictionary<string, object>();
                string[] values = [datapackNamespaceField.Text];

                loadJsonStart.Add("values", values);

                string loadJsonString = JsonSerializer.Serialize(loadJsonStart, new JsonSerializerOptions() { WriteIndented = true });

                File.WriteAllText(minecraftFunctionTagsFolder + "\\load.json", loadJsonString);

                // Namespace function directory

                Directory.CreateDirectory(namespaceFolder + "\\function");

                // pack.mcmeta

                Dictionary<string, object> packStart = new Dictionary<string, object>();
                Dictionary<string, object> packInfo = new Dictionary<string, object>();

                packInfo.Add("pack_format", packFormat.Value);
                packInfo.Add("description", datapackDescriptionText.Text);

                packStart.Add("pack", packInfo);

                JsonSerializerOptions jsonConfig = new JsonSerializerOptions() { WriteIndented = true };

                string packMcmeta = JsonSerializer.Serialize(packStart, jsonConfig);
                MessageBox.Show(packMcmeta);

                // MCFUNCTION files
                File.WriteAllText(folder + "\\pack.mcmeta", packMcmeta);
                File.WriteAllText(namespaceFolder + "\\function\\load.mcfunction", @$"# This will run when the datapack loads. Replace this with commands that should be executed when the datapack loads!
say Datapack {datapackNameField.Text} loaded!");

                // Successful!
                success = true;
            }
            catch (Exception ex)
            {
                success = false;

                bool shouldTryAgain = PublicMethods.HandleException(ex);

                if (shouldTryAgain)
                {
                    TryCreateDirectory(folder);
                }
            }

            if (success)
            {
                DialogResult createdBox = MessageBox.Show("Created folder successfully. Open the folder now?", "Folder Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (createdBox == DialogResult.Yes)
                {
                    ProcessStartInfo startInformation = new ProcessStartInfo();
                    startInformation.UseShellExecute = true;
                    startInformation.FileName = folder;

                    Process.Start(startInformation);
                }
            }
        }

        private bool PromptOverwriteWarning(string folder)
        {
            bool shouldOverwrite = false;

            TaskDialogPage page = new TaskDialogPage();
            page.Heading = "A folder within the provided directory already exists";
            page.Text = "Minecraft Datapack Creation Tool has found that a folder with the same name in the directory provided. Continuing with the generation will delete the old folder and replace it with the new one. If you don't want this, press Cancel, otherwise, click Continue. What do you want to do with the already existing folder?";

            page.Footnote.Icon = TaskDialogIcon.Warning;
            page.Footnote.Text = "If you choose to overwrite the folder, you will lose all the contents inside the current folder.";

            TaskDialogCommandLinkButton continueButton = new TaskDialogCommandLinkButton();
            continueButton.Text = "Overwrite Folder";
            continueButton.DescriptionText = "Deletes the old folder and replaces it with the new files.";
            continueButton.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("This action is irreversible. Are you sure you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    shouldOverwrite = true;
                }
            };

            TaskDialogCommandLinkButton viewDirectoryButton = new TaskDialogCommandLinkButton();
            viewDirectoryButton.Text = "View Folder Contents";
            viewDirectoryButton.DescriptionText = "Opens the folder via the File Explorer so you can see what's inside the folder.";
            viewDirectoryButton.Click += (s, e) =>
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = true;
                info.FileName = folder;
                Process.Start(info);
            };

            TaskDialogCommandLinkButton cancelButton = new TaskDialogCommandLinkButton();
            cancelButton.Text = "Cancel";
            cancelButton.DescriptionText = "Fully cancels the overwriting operation.";

            page.Buttons = [continueButton, viewDirectoryButton, cancelButton];

            TaskDialog.ShowDialog(page);

            return shouldOverwrite;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

            this.Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            isMaximized = !isMaximized;
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings1.Default.ShowCloseWarning)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close the application? Any information provided will be lost.", "Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "Select Datapack Destination";

            if (!string.IsNullOrEmpty(Properties.Settings1.Default.DefaultLaunchDirectory))
            {
                dialog.InitialDirectory = Properties.Settings1.Default.DefaultLaunchDirectory;
            }

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                datapackFolderDestination = dialog.SelectedPath;

                string destinationDisplay = datapackFolderDestination ?? "None.";
                toolTip1.SetToolTip(selectFolderButton, destinationDisplay);
            }
        }

        private void generateDatapack_Click(object sender, EventArgs e)
        {
            DisplayErrorProvider(datapackNameField, "");
            DisplayErrorProvider(datapackNamespaceField, "");
            DisplayErrorProvider(datapackDescriptionText, "");
            DisplayErrorProvider(packFormat, "");
            DisplayErrorProvider(selectFolderButton, "");

            errorNotif.Visible = false;

            int errorCount = 0;

            // Handle errors
            if (string.IsNullOrEmpty(datapackNameField.Text))
            {
                DisplayErrorProvider(datapackNameField, "Name field cannot be empty.");
                errorCount++;
            }

            if (string.IsNullOrEmpty(datapackNamespaceField.Text))
            {
                DisplayErrorProvider(datapackNamespaceField, "Namespace field cannot be empty.");
                errorCount++;
            }

            if (string.IsNullOrEmpty(datapackDescriptionText.Text))
            {
                DisplayErrorProvider(datapackDescriptionText, "Datapack description cannot be empty.");
                errorCount++;
            }

            if (packFormat.Value < 1)
            {
                DisplayErrorProvider(packFormat, "Pack format must be greater than zero. You can find a list of pack format numbers through the web.");
                errorCount++;
            }

            if (string.IsNullOrEmpty(datapackFolderDestination))
            {
                DisplayErrorProvider(selectFolderButton, "A destination is required.");
                errorCount++;
            }

            if (errorCount >= 1)
            {
                errorNotif.Visible = true;
                MessageBox.Show("There were errors while checking the information provided. Please resolve them and try again.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("A folder will be created at " + datapackFolderDestination + ". Continue?", "Create Folder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string folder = datapackFolderDestination + "\\" + datapackNameField.Text;
                if (!Directory.Exists(folder))
                {
                    TryCreateDirectory(folder);
                }
                else
                {
                    bool overwrite = PromptOverwriteWarning(folder);

                    if (overwrite)
                    {
                        Directory.Delete(folder, true);
                        TryCreateDirectory(folder);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExceptionLister lister = new ExceptionLister();
            var exceptions = lister.ListExceptions();

            string destinationDisplay = datapackFolderDestination ?? "None.";

            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Destination Selected";
            toolTip1.Active = true;
            toolTip1.SetToolTip(selectFolderButton, destinationDisplay);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Browse the web for the latest pack format version?", "Open Browser", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.FileName = "https://minecraft.wiki/w/Data_pack#Pack_format";

                Process.Start(startInfo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
