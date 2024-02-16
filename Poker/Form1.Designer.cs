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
            handLabel = new Label();
            faceCountsLabel = new Label();
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
            // handLabel
            // 
            handLabel.AutoSize = true;
            handLabel.Location = new Point(280, 80);
            handLabel.Name = "handLabel";
            handLabel.Size = new Size(0, 20);
            handLabel.TabIndex = 1;
            // 
            // faceCountsLabel
            // 
            faceCountsLabel.AutoSize = true;
            faceCountsLabel.Location = new Point(284, 286);
            faceCountsLabel.Name = "faceCountsLabel";
            faceCountsLabel.Size = new Size(50, 20);
            faceCountsLabel.TabIndex = 2;
            faceCountsLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(faceCountsLabel);
            Controls.Add(handLabel);
            Controls.Add(newHandButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newHandButton;
        private Label handLabel;
        private Label faceCountsLabel;
    }
}