namespace DiscordPollGenerator
{
    partial class frmPollMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxPollMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxPollMessage
            // 
            this.txtboxPollMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPollMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPollMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPollMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxPollMessage.Location = new System.Drawing.Point(12, 12);
            this.txtboxPollMessage.Multiline = true;
            this.txtboxPollMessage.Name = "txtboxPollMessage";
            this.txtboxPollMessage.Size = new System.Drawing.Size(386, 177);
            this.txtboxPollMessage.TabIndex = 0;
            // 
            // frmPollMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.Controls.Add(this.txtboxPollMessage);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimumSize = new System.Drawing.Size(426, 240);
            this.Name = "frmPollMessage";
            this.Text = "Poll Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPollMessage;
    }
}