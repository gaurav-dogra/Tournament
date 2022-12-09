namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.teamOneLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.vesusLabel = new System.Windows.Forms.Label();
            this.tournamentLabel2 = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentLabel.Location = new System.Drawing.Point(52, 33);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(122, 30);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament:";
            this.tournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamOneLabel
            // 
            this.teamOneLabel.AutoSize = true;
            this.teamOneLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneLabel.Location = new System.Drawing.Point(472, 229);
            this.teamOneLabel.Name = "teamOneLabel";
            this.teamOneLabel.Size = new System.Drawing.Size(125, 30);
            this.teamOneLabel.TabIndex = 0;
            this.teamOneLabel.Text = "<team one>";
            this.teamOneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(52, 103);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(71, 30);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Round";
            this.roundLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(129, 110);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(189, 23);
            this.roundComboBox.TabIndex = 1;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(129, 155);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(104, 19);
            this.unplayedOnlyCheckBox.TabIndex = 2;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 15;
            this.matchupListBox.Location = new System.Drawing.Point(52, 229);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(266, 304);
            this.matchupListBox.TabIndex = 3;
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneScoreLabel.Location = new System.Drawing.Point(472, 283);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(62, 30);
            this.teamOneScoreLabel.TabIndex = 0;
            this.teamOneScoreLabel.Text = "Score";
            this.teamOneScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamOneScoreTextBox
            // 
            this.teamOneScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(551, 290);
            this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 23);
            this.teamOneScoreTextBox.TabIndex = 4;
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoLabel.Location = new System.Drawing.Point(472, 442);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(123, 30);
            this.teamTwoLabel.TabIndex = 0;
            this.teamTwoLabel.Text = "<team two>";
            this.teamTwoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(472, 496);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(62, 30);
            this.teamTwoScoreLabel.TabIndex = 0;
            this.teamTwoScoreLabel.Text = "Score";
            this.teamTwoScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamTwoScoreTextBox
            // 
            this.teamTwoScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(551, 503);
            this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 23);
            this.teamTwoScoreTextBox.TabIndex = 4;
            // 
            // vesusLabel
            // 
            this.vesusLabel.AutoSize = true;
            this.vesusLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vesusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.vesusLabel.Location = new System.Drawing.Point(472, 371);
            this.vesusLabel.Name = "vesusLabel";
            this.vesusLabel.Size = new System.Drawing.Size(52, 30);
            this.vesusLabel.TabIndex = 0;
            this.vesusLabel.Text = "-VS-";
            this.vesusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentLabel2
            // 
            this.tournamentLabel2.AutoSize = true;
            this.tournamentLabel2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentLabel2.Location = new System.Drawing.Point(193, 33);
            this.tournamentLabel2.Name = "tournamentLabel2";
            this.tournamentLabel2.Size = new System.Drawing.Size(86, 30);
            this.tournamentLabel2.TabIndex = 0;
            this.tournamentLabel2.Text = "<none>";
            this.tournamentLabel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreButton.Location = new System.Drawing.Point(721, 374);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(131, 32);
            this.scoreButton.TabIndex = 5;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 648);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.teamOneScoreTextBox);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.vesusLabel);
            this.Controls.Add(this.tournamentLabel2);
            this.Controls.Add(this.teamOneLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentLabel);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tournamentLabel;
        private Label teamOneLabel;
        private Label roundLabel;
        private ComboBox roundComboBox;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreTextBox;
        private Label teamTwoLabel;
        private Label teamTwoScoreLabel;
        private TextBox teamTwoScoreTextBox;
        private Label vesusLabel;
        private Label tournamentLabel2;
        private Button scoreButton;
    }
}