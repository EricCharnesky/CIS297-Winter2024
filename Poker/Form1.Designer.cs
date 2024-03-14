namespace Poker
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
            newHandButton = new Button();
            player1HandLabel = new Label();
            sharedCardsLabel = new Label();
            player2HandLabel = new Label();
            currentPlayerLabel = new Label();
            betOrFoldButton = new Button();
            checkOrCallButton = new Button();
            potLabel = new Label();
            player1MoneyLabel = new Label();
            player2MoneyLabel = new Label();
            roundOverLabel = new Label();
            SuspendLayout();
            // 
            // newHandButton
            // 
            newHandButton.Location = new Point(269, 175);
            newHandButton.Name = "newHandButton";
            newHandButton.Size = new Size(94, 29);
            newHandButton.TabIndex = 0;
            newHandButton.Text = "New Hand";
            newHandButton.UseVisualStyleBackColor = true;
            newHandButton.Click += newHandButton_Click;
            // 
            // player1HandLabel
            // 
            player1HandLabel.AutoSize = true;
            player1HandLabel.Location = new Point(556, 126);
            player1HandLabel.Name = "player1HandLabel";
            player1HandLabel.Size = new Size(0, 20);
            player1HandLabel.TabIndex = 1;
            // 
            // sharedCardsLabel
            // 
            sharedCardsLabel.AutoSize = true;
            sharedCardsLabel.Location = new Point(284, 286);
            sharedCardsLabel.Name = "sharedCardsLabel";
            sharedCardsLabel.Size = new Size(50, 20);
            sharedCardsLabel.TabIndex = 2;
            sharedCardsLabel.Text = "label1";
            // 
            // player2HandLabel
            // 
            player2HandLabel.AutoSize = true;
            player2HandLabel.Location = new Point(507, 175);
            player2HandLabel.Name = "player2HandLabel";
            player2HandLabel.Size = new Size(0, 20);
            player2HandLabel.TabIndex = 3;
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.Location = new Point(40, 184);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(108, 20);
            currentPlayerLabel.TabIndex = 4;
            currentPlayerLabel.Text = "Current Player: ";
            // 
            // betOrFoldButton
            // 
            betOrFoldButton.Location = new Point(269, 210);
            betOrFoldButton.Name = "betOrFoldButton";
            betOrFoldButton.Size = new Size(94, 29);
            betOrFoldButton.TabIndex = 5;
            betOrFoldButton.Text = "Bet";
            betOrFoldButton.UseVisualStyleBackColor = true;
            betOrFoldButton.Click += betOrFoldButton_Click;
            // 
            // checkOrCallButton
            // 
            checkOrCallButton.Location = new Point(369, 210);
            checkOrCallButton.Name = "checkOrCallButton";
            checkOrCallButton.Size = new Size(94, 29);
            checkOrCallButton.TabIndex = 6;
            checkOrCallButton.Text = "Check";
            checkOrCallButton.UseVisualStyleBackColor = true;
            checkOrCallButton.Click += checkButton_Click;
            // 
            // potLabel
            // 
            potLabel.AutoSize = true;
            potLabel.Location = new Point(42, 232);
            potLabel.Name = "potLabel";
            potLabel.Size = new Size(45, 20);
            potLabel.TabIndex = 7;
            potLabel.Text = "Pot: $";
            // 
            // player1MoneyLabel
            // 
            player1MoneyLabel.AutoSize = true;
            player1MoneyLabel.Location = new Point(55, 305);
            player1MoneyLabel.Name = "player1MoneyLabel";
            player1MoneyLabel.Size = new Size(125, 20);
            player1MoneyLabel.TabIndex = 8;
            player1MoneyLabel.Text = "Player 1 Money: $";
            // 
            // player2MoneyLabel
            // 
            player2MoneyLabel.AutoSize = true;
            player2MoneyLabel.Location = new Point(55, 340);
            player2MoneyLabel.Name = "player2MoneyLabel";
            player2MoneyLabel.Size = new Size(125, 20);
            player2MoneyLabel.TabIndex = 9;
            player2MoneyLabel.Text = "Player 2 Money: $";
            // 
            // roundOverLabel
            // 
            roundOverLabel.AutoSize = true;
            roundOverLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            roundOverLabel.Location = new Point(198, 24);
            roundOverLabel.Name = "roundOverLabel";
            roundOverLabel.Size = new Size(0, 31);
            roundOverLabel.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roundOverLabel);
            Controls.Add(player2MoneyLabel);
            Controls.Add(player1MoneyLabel);
            Controls.Add(potLabel);
            Controls.Add(checkOrCallButton);
            Controls.Add(betOrFoldButton);
            Controls.Add(currentPlayerLabel);
            Controls.Add(player2HandLabel);
            Controls.Add(sharedCardsLabel);
            Controls.Add(player1HandLabel);
            Controls.Add(newHandButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newHandButton;
        private Label player1HandLabel;
        private Label sharedCardsLabel;
        private Label player2HandLabel;
        private Label currentPlayerLabel;
        private Button betOrFoldButton;
        private Button checkOrCallButton;
        private Label potLabel;
        private Label player1MoneyLabel;
        private Label player2MoneyLabel;
        private Label roundOverLabel;
    }
}