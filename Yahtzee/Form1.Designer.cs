namespace Yahtzee
{
    partial class Form1
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
            rollButton = new Button();
            die1Label = new Label();
            die2Label = new Label();
            die3Label = new Label();
            die4Label = new Label();
            die5Label = new Label();
            holdDie1CheckBox = new CheckBox();
            holdDie2CheckBox = new CheckBox();
            holdDie3CheckBox = new CheckBox();
            holdDie4CheckBox = new CheckBox();
            holdDie5CheckBox = new CheckBox();
            score1sButton = new Button();
            score2sButton = new Button();
            onesScoreLabel = new Label();
            twosScoreLabel = new Label();
            rollsRemainingLabel = new Label();
            currentPlayerLabel = new Label();
            newGameButton = new Button();
            SuspendLayout();
            // 
            // rollButton
            // 
            rollButton.Location = new Point(221, 363);
            rollButton.Name = "rollButton";
            rollButton.Size = new Size(94, 29);
            rollButton.TabIndex = 0;
            rollButton.Text = "Roll";
            rollButton.UseVisualStyleBackColor = true;
            rollButton.Click += rollButton_Click;
            // 
            // die1Label
            // 
            die1Label.AutoSize = true;
            die1Label.Location = new Point(89, 256);
            die1Label.Name = "die1Label";
            die1Label.Size = new Size(50, 20);
            die1Label.TabIndex = 1;
            die1Label.Text = "label1";
            // 
            // die2Label
            // 
            die2Label.AutoSize = true;
            die2Label.Location = new Point(159, 256);
            die2Label.Name = "die2Label";
            die2Label.Size = new Size(50, 20);
            die2Label.TabIndex = 2;
            die2Label.Text = "label1";
            // 
            // die3Label
            // 
            die3Label.AutoSize = true;
            die3Label.Location = new Point(235, 256);
            die3Label.Name = "die3Label";
            die3Label.Size = new Size(50, 20);
            die3Label.TabIndex = 3;
            die3Label.Text = "label1";
            // 
            // die4Label
            // 
            die4Label.AutoSize = true;
            die4Label.Location = new Point(316, 256);
            die4Label.Name = "die4Label";
            die4Label.Size = new Size(50, 20);
            die4Label.TabIndex = 4;
            die4Label.Text = "label1";
            // 
            // die5Label
            // 
            die5Label.AutoSize = true;
            die5Label.Location = new Point(391, 256);
            die5Label.Name = "die5Label";
            die5Label.Size = new Size(50, 20);
            die5Label.TabIndex = 5;
            die5Label.Text = "label1";
            // 
            // holdDie1CheckBox
            // 
            holdDie1CheckBox.AutoSize = true;
            holdDie1CheckBox.Location = new Point(89, 300);
            holdDie1CheckBox.Name = "holdDie1CheckBox";
            holdDie1CheckBox.Size = new Size(64, 24);
            holdDie1CheckBox.TabIndex = 6;
            holdDie1CheckBox.Text = "Hold";
            holdDie1CheckBox.UseVisualStyleBackColor = true;
            holdDie1CheckBox.CheckedChanged += holdDie1CheckBox_CheckedChanged;
            // 
            // holdDie2CheckBox
            // 
            holdDie2CheckBox.AutoSize = true;
            holdDie2CheckBox.Location = new Point(159, 300);
            holdDie2CheckBox.Name = "holdDie2CheckBox";
            holdDie2CheckBox.Size = new Size(64, 24);
            holdDie2CheckBox.TabIndex = 7;
            holdDie2CheckBox.Text = "Hold";
            holdDie2CheckBox.UseVisualStyleBackColor = true;
            holdDie2CheckBox.CheckedChanged += holdDie2CheckBox_CheckedChanged;
            // 
            // holdDie3CheckBox
            // 
            holdDie3CheckBox.AutoSize = true;
            holdDie3CheckBox.Location = new Point(229, 300);
            holdDie3CheckBox.Name = "holdDie3CheckBox";
            holdDie3CheckBox.Size = new Size(64, 24);
            holdDie3CheckBox.TabIndex = 8;
            holdDie3CheckBox.Text = "Hold";
            holdDie3CheckBox.UseVisualStyleBackColor = true;
            holdDie3CheckBox.CheckedChanged += holdDie3CheckBox_CheckedChanged;
            // 
            // holdDie4CheckBox
            // 
            holdDie4CheckBox.AutoSize = true;
            holdDie4CheckBox.Location = new Point(302, 300);
            holdDie4CheckBox.Name = "holdDie4CheckBox";
            holdDie4CheckBox.Size = new Size(64, 24);
            holdDie4CheckBox.TabIndex = 9;
            holdDie4CheckBox.Text = "Hold";
            holdDie4CheckBox.UseVisualStyleBackColor = true;
            holdDie4CheckBox.CheckedChanged += holdDie4CheckBox_CheckedChanged;
            // 
            // holdDie5CheckBox
            // 
            holdDie5CheckBox.AutoSize = true;
            holdDie5CheckBox.Location = new Point(391, 300);
            holdDie5CheckBox.Name = "holdDie5CheckBox";
            holdDie5CheckBox.Size = new Size(64, 24);
            holdDie5CheckBox.TabIndex = 10;
            holdDie5CheckBox.Text = "Hold";
            holdDie5CheckBox.UseVisualStyleBackColor = true;
            holdDie5CheckBox.CheckedChanged += holdDie5CheckBox_CheckedChanged;
            // 
            // score1sButton
            // 
            score1sButton.Location = new Point(550, 61);
            score1sButton.Name = "score1sButton";
            score1sButton.Size = new Size(94, 29);
            score1sButton.TabIndex = 11;
            score1sButton.Text = "Score 1s";
            score1sButton.UseVisualStyleBackColor = true;
            score1sButton.Click += score1sButton_Click;
            // 
            // score2sButton
            // 
            score2sButton.Location = new Point(550, 96);
            score2sButton.Name = "score2sButton";
            score2sButton.Size = new Size(94, 29);
            score2sButton.TabIndex = 12;
            score2sButton.Text = "Score 2s";
            score2sButton.UseVisualStyleBackColor = true;
            score2sButton.Click += score2sButton_Click;
            // 
            // onesScoreLabel
            // 
            onesScoreLabel.AutoSize = true;
            onesScoreLabel.Location = new Point(666, 69);
            onesScoreLabel.Name = "onesScoreLabel";
            onesScoreLabel.Size = new Size(50, 20);
            onesScoreLabel.TabIndex = 13;
            onesScoreLabel.Text = "label1";
            // 
            // twosScoreLabel
            // 
            twosScoreLabel.AutoSize = true;
            twosScoreLabel.Location = new Point(666, 105);
            twosScoreLabel.Name = "twosScoreLabel";
            twosScoreLabel.Size = new Size(50, 20);
            twosScoreLabel.TabIndex = 14;
            twosScoreLabel.Text = "label1";
            // 
            // rollsRemainingLabel
            // 
            rollsRemainingLabel.AutoSize = true;
            rollsRemainingLabel.Location = new Point(350, 363);
            rollsRemainingLabel.Name = "rollsRemainingLabel";
            rollsRemainingLabel.Size = new Size(50, 20);
            rollsRemainingLabel.TabIndex = 15;
            rollsRemainingLabel.Text = "label1";
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.Location = new Point(149, 45);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(108, 20);
            currentPlayerLabel.TabIndex = 16;
            currentPlayerLabel.Text = "Current Player: ";
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(805, 371);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(94, 29);
            newGameButton.TabIndex = 17;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(newGameButton);
            Controls.Add(currentPlayerLabel);
            Controls.Add(rollsRemainingLabel);
            Controls.Add(twosScoreLabel);
            Controls.Add(onesScoreLabel);
            Controls.Add(score2sButton);
            Controls.Add(score1sButton);
            Controls.Add(holdDie5CheckBox);
            Controls.Add(holdDie4CheckBox);
            Controls.Add(holdDie3CheckBox);
            Controls.Add(holdDie2CheckBox);
            Controls.Add(holdDie1CheckBox);
            Controls.Add(die5Label);
            Controls.Add(die4Label);
            Controls.Add(die3Label);
            Controls.Add(die2Label);
            Controls.Add(die1Label);
            Controls.Add(rollButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rollButton;
        private Label die1Label;
        private Label die2Label;
        private Label die3Label;
        private Label die4Label;
        private Label die5Label;
        private CheckBox holdDie1CheckBox;
        private CheckBox holdDie2CheckBox;
        private CheckBox holdDie3CheckBox;
        private CheckBox holdDie4CheckBox;
        private CheckBox holdDie5CheckBox;
        private Button score1sButton;
        private Button score2sButton;
        private Label onesScoreLabel;
        private Label twosScoreLabel;
        private Label rollsRemainingLabel;
        private Label currentPlayerLabel;
        private Button newGameButton;
    }
}