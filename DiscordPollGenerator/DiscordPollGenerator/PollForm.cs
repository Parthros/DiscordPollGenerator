using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordPollGenerator
{
    public partial class frmDiscordPollGenrator : Form
    {
        public frmDiscordPollGenrator()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;

            if(ValidatePollForm())
            {
                List<string> lstPollOptions = new List<string>();

                if(!string.IsNullOrEmpty(this.txtBoxPollOption.Text))
                {
                    this.lstboxPollOptions.Items.Add(this.txtBoxPollOption.Text);
                    this.txtBoxPollOption.Text = string.Empty;
                }

                foreach(object pollOption in this.lstboxPollOptions.Items)
                    lstPollOptions.Add(pollOption.ToString());

                frmPollMessage PollMessage = new frmPollMessage(this.txtboxPollQuestion.Text, lstPollOptions);

                PollMessage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Poll!  Verify you provided a Poll Question and Option(s).", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSubmit.Enabled = true;
        }

        private bool ValidatePollForm()
        {
            if(lstboxPollOptions.Items.Count > 10 || (lstboxPollOptions.Items.Count > 9 && !string.IsNullOrEmpty(txtBoxPollOption.Text)))
            {
                //Discord doesn't support :ten: or up as reactions, so unless we want to start specifying other custom reactions for option 10+, we're stuck with just 10 options
                MessageBox.Show("More than 10 options per poll is currently unsupported!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Allows a blank (white space) Poll Question, but all answers must have text
            return (!string.IsNullOrEmpty(this.lblPollQuestion.Text) && (lstboxPollOptions.Items.Count > 0 || !string.IsNullOrEmpty(txtBoxPollOption.Text)));
        }

        private void txtBoxPollOption_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return && !string.IsNullOrEmpty(txtBoxPollOption.Text))
            {
                e.Handled = e.SuppressKeyPress = true;

                if(this.lstboxPollOptions.Items.Count < 10)
                {
                    this.lstboxPollOptions.Items.Add(txtBoxPollOption.Text);
                    this.txtBoxPollOption.Text = string.Empty;
                }
                else
                {
                    //Discord doesn't support :ten: or up as reactions, so unless we want to start specifying other custom reactions for option 10+, we're stuck with just 10 options
                    MessageBox.Show("More than 10 options per poll is currently unsupported!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxPollOption.Text = string.Empty;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtboxPollQuestion.Text = string.Empty;
            this.txtBoxPollOption.Text = string.Empty;
            this.lstboxPollOptions.Items.Clear();
        }

        private void txtBoxPollOption_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                e.Handled = e.SuppressKeyPress = true;
        }

        private void lstboxPollOptions_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                lstboxPollOptions.Items.RemoveAt(lstboxPollOptions.SelectedIndex);
        }
    }
}