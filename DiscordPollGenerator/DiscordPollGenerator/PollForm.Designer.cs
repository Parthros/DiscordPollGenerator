namespace DiscordPollGenerator
{
    partial class frmDiscordPollGenrator
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
            this.lblPollQuestion = new System.Windows.Forms.Label();
            this.lblPollOptions = new System.Windows.Forms.Label();
            this.txtboxPollQuestion = new System.Windows.Forms.TextBox();
            this.txtBoxPollOption = new System.Windows.Forms.TextBox();
            this.lstboxPollOptions = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPollQuestion
            // 
            this.lblPollQuestion.AutoSize = true;
            this.lblPollQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblPollQuestion.Name = "lblPollQuestion";
            this.lblPollQuestion.Size = new System.Drawing.Size(72, 13);
            this.lblPollQuestion.TabIndex = 0;
            this.lblPollQuestion.Text = "Poll Question:";
            // 
            // lblPollOptions
            // 
            this.lblPollOptions.AutoSize = true;
            this.lblPollOptions.Location = new System.Drawing.Point(12, 59);
            this.lblPollOptions.Name = "lblPollOptions";
            this.lblPollOptions.Size = new System.Drawing.Size(206, 13);
            this.lblPollOptions.TabIndex = 1;
            this.lblPollOptions.Text = "Poll Options (Press ENTER to Add to List):";
            // 
            // txtboxPollQuestion
            // 
            this.txtboxPollQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxPollQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPollQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPollQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxPollQuestion.Location = new System.Drawing.Point(15, 25);
            this.txtboxPollQuestion.Name = "txtboxPollQuestion";
            this.txtboxPollQuestion.Size = new System.Drawing.Size(240, 20);
            this.txtboxPollQuestion.TabIndex = 2;
            // 
            // txtBoxPollOption
            // 
            this.txtBoxPollOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPollOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPollOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPollOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxPollOption.Location = new System.Drawing.Point(15, 75);
            this.txtBoxPollOption.Name = "txtBoxPollOption";
            this.txtBoxPollOption.Size = new System.Drawing.Size(240, 20);
            this.txtBoxPollOption.TabIndex = 3;
            this.txtBoxPollOption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPollOption_KeyDown);
            this.txtBoxPollOption.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxPollOption_KeyUp);
            // 
            // lstboxPollOptions
            // 
            this.lstboxPollOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstboxPollOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstboxPollOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstboxPollOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstboxPollOptions.FormattingEnabled = true;
            this.lstboxPollOptions.Location = new System.Drawing.Point(15, 101);
            this.lstboxPollOptions.Name = "lstboxPollOptions";
            this.lstboxPollOptions.Size = new System.Drawing.Size(240, 197);
            this.lstboxPollOptions.TabIndex = 4;
            this.lstboxPollOptions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstboxPollOptions_KeyUp);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmit.Location = new System.Drawing.Point(82, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(173, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Generate Discord Poll";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(15, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmDiscordPollGenrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(270, 339);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstboxPollOptions);
            this.Controls.Add(this.txtBoxPollOption);
            this.Controls.Add(this.txtboxPollQuestion);
            this.Controls.Add(this.lblPollOptions);
            this.Controls.Add(this.lblPollQuestion);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimumSize = new System.Drawing.Size(286, 378);
            this.Name = "frmDiscordPollGenrator";
            this.Text = "Discord Poll Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPollQuestion;
        private System.Windows.Forms.Label lblPollOptions;
        private System.Windows.Forms.TextBox txtboxPollQuestion;
        private System.Windows.Forms.TextBox txtBoxPollOption;
        private System.Windows.Forms.ListBox lstboxPollOptions;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}

