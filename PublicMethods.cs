using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDCTRevised
{
    internal static class PublicMethods
    {
        /// <summary>
        /// Triggers the exception handler.
        /// </summary>
        /// <param name="exception">The exception that was thrown.</param>
        /// <returns>A boolean determining if the user has clicked the "Try Again" button.</returns>
        public static bool HandleException(Exception exception)
        {
            bool clickedTryAgain = false;
            
            TaskDialogPage errorPage = new TaskDialogPage();
            errorPage.Icon = TaskDialogIcon.ShieldErrorRedBar;
            errorPage.Caption = "Error - " + exception.GetType().Name;
            errorPage.Heading = "Something went wrong performing this action";
            errorPage.Text = "An error has occured, and you are seeing this message because the program has encountered an error, or in Visual Studio terms, an exception. You can try again by clicking the Try Again button, or you can close the program and try again later. It is recommended you terminate the program to prevent software corruption.";

            errorPage.Verification.Text = "Log this exception when I exit";

            errorPage.Footnote.Icon = TaskDialogIcon.Information;
            errorPage.Footnote.Text = "If you choose to save a log of this exception, you can report the bug and include the log with it as well. That way, I can easily identify the issue!";

            errorPage.Expander.CollapsedButtonText = "See More Details";
            errorPage.Expander.Text = "Exception message: " + exception.Message + "\nStack trace: " + exception.StackTrace + "\nException source: " + exception.Source;
            
            TaskDialogCommandLinkButton tryAgain = new TaskDialogCommandLinkButton();
            tryAgain.Text = "Try Again";
            tryAgain.DescriptionText = "Retries the operation. This may not be recommended as the application could error again, however if you want to keep your data, select this option.";
            tryAgain.Click += (s, e) =>
            {
                clickedTryAgain = true;
            };

            TaskDialogCommandLinkButton cancelButton = new TaskDialogCommandLinkButton();
            cancelButton.Text = "Terminate the Program";
            cancelButton.DescriptionText = "Cancels the retry operation and forces the program to terminate. Keep in mind that you may lose unsaved data.";
            cancelButton.Click += (s, e) =>
            {
                if (errorPage.Verification.Checked)
                {
                    SaveFileDialog saveTextDialog = new SaveFileDialog();
                    saveTextDialog.FileName = "log";
                    saveTextDialog.Filter = "Text Files (*.txt)|*.txt";

                    DialogResult saveResult = saveTextDialog.ShowDialog();

                    if (saveResult == DialogResult.OK)
                    {
                        File.WriteAllText(saveTextDialog.FileName, "Exception message: " + exception.Message + "\nStack trace: " + exception.StackTrace + "\nException source: " + exception.Source);
                    }
                }

                Environment.Exit(0);
            };

            errorPage.Buttons = [tryAgain, cancelButton];

            TaskDialog.ShowDialog(errorPage);

            return clickedTryAgain;
        }
    }
}
