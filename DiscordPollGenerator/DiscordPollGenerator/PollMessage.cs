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
    public partial class frmPollMessage : Form
    {
        public frmPollMessage(string PollQuestion, List<string> PollOptions)
        {
            InitializeComponent();
            this.txtboxPollMessage.Text = CreatePoll(PollQuestion, PollOptions);
        }

        private string CreatePoll(string PollQuestion, List<string> PollOptions)
        {
            string PollMessage = PollQuestion + Environment.NewLine;

            for(int i = 0; i < PollOptions.Count; i++)
                PollMessage += $":{HumanFriendlyInteger.IntegerToWritten(i).ToLower()}: - {PollOptions[i]}{Environment.NewLine}";

            return PollMessage;
        }
    }
}