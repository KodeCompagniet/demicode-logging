using System;
using System.Windows.Forms;

namespace e4subsea.Logging.Exceptions
{
    public partial class UserFeedbackForm : Form
    {
		
        public UserFeedbackForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display error information and return feedback from the user.
        /// </summary>
        public UserFeedback ShowException(Exception exception)
        {
            UseWaitCursor = false;
            SubmitButton.Enabled = true;
            ErrorTextbox.Text = String.Format("{0}\r\n{1}", exception.Message, exception.StackTrace);
            var result = ShowDialog();

            if (result == DialogResult.OK)
                return new UserFeedback(UsernameTextbox.Text, AdditionalInformationTextBox.Text);

            //If Cancel, return null
            return null;
        }

        public void ExceptionHandled(string caseStatus)
        {
            UseWaitCursor = false;
            SubmitButton.Enabled = false;

            var status = String.IsNullOrEmpty(caseStatus) ? "The error information could not be submitted at this time" : caseStatus;
            MessageBox.Show(status, "Error submit to 4Subsea", MessageBoxButtons.OK);
            Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            DialogResult = DialogResult.OK;
        }

        private void _copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ErrorTextbox.Text);
        }
    }
}


