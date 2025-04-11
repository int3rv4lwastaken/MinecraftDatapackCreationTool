using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDCTRevised
{
    public partial class SettingsForm : Form
    {
        private Point mousePoint;
        private bool unsavedChanges;

        private string appTheme;
        private bool showCloseAlert;
        private string defaultDirectory;
        private Exception selectedException;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveSettings()
        {
            try
            {
                Properties.Settings1.Default.DefaultLaunchDirectory = defaultDirectory;
                Properties.Settings1.Default.ShowCloseWarning = showCloseAlert;
                Properties.Settings1.Default.SoftwareTheme = appTheme;

                Properties.Settings1.Default.Save();

                unsavedChanges = false;

                MessageBox.Show("Successfully saved application settings.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void SettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

            this.Location = new Point(this.Left - (mousePoint.X - e.X), this.Top - (mousePoint.Y - e.Y));
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (unsavedChanges)
            {
                TaskDialogPage unsavedChangesAlert = new TaskDialogPage();
                unsavedChangesAlert.Heading = "You have unsaved changes";
                unsavedChangesAlert.Text = "If you close the Settings menu now, you'll lose any changes you've made to your settings. Do you want to save your settings now?";

                TaskDialogCommandLinkButton saveNow = new TaskDialogCommandLinkButton();
                saveNow.Text = "Save and Close";
                saveNow.Click += (s, e) =>
                {
                    SaveSettings();
                    this.Close();
                };

                TaskDialogCommandLinkButton closeWithoutSaving = new TaskDialogCommandLinkButton();
                closeWithoutSaving.Text = "Close Without Saving";
                closeWithoutSaving.Click += (s, e) =>
                {
                    this.Close();
                };

                TaskDialogCommandLinkButton cancelButton = new TaskDialogCommandLinkButton();
                cancelButton.Text = "Do Nothing";

                unsavedChangesAlert.Buttons = [saveNow, closeWithoutSaving, cancelButton];

                TaskDialog.ShowDialog(unsavedChangesAlert);
            }
            else
            {
                this.Close();
            }
        }

        private void themeSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            appTheme = themeSelect.Items[themeSelect.SelectedIndex].ToString();
            unsavedChanges = true;
        }

        private void selectLaunchDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                defaultDirectory = dialog.SelectedPath;
                unsavedChanges = true;
            }
        }

        private void toggleCloseAlert_CheckedChanged(object sender, EventArgs e)
        {
            showCloseAlert = toggleCloseAlert.Checked;
            unsavedChanges = true;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            toggleCloseAlert.Checked = Properties.Settings1.Default.ShowCloseWarning;
            themeSelect.SelectedValue = Properties.Settings1.Default.SoftwareTheme;

            ExceptionLister lister = new ExceptionLister();

            Exception[] exceptions = lister.ListExceptions();

            foreach (Exception item in exceptions.OrderBy(exc => exc.GetType().Name))
            {
                exceptionSelect.Items.Add(item);

                exceptionSelect.SelectedValueChanged += (s, e) =>
                {
                    if (exceptionSelect.SelectedItem == item)
                    {
                        Exception selection = exceptionSelect.SelectedItem as Exception;
                        selectedException = selection;
                    }
                };
            }

            exceptionSelect.Format += (s, e) =>
            {
                if (e.ListItem is Exception ex)
                {
                    e.Value = ex.GetType().Name;
                }
            };

            unsavedChanges = false;
        }

        private void triggerErrorHandler_Click(object sender, EventArgs e)
        {
            if (selectedException != null)
            {
                bool shouldTryAgain = PublicMethods.HandleException(selectedException);

                if (shouldTryAgain)
                {
                    MessageBox.Show("There's no action to try again.", "Error Handler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select an exception and try again.");
            }
        }

        private void reportBug_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = true;
            startInfo.FileName = "https://github.com/int3rv4lwastaken/MinecraftDatapackCreationTool/issues/new";

            Process.Start(startInfo);
        }
    }
}
