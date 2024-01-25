namespace Project1
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
            incomeTextBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            taxesOwedLabel = new Label();
            button2 = new Button();
            label2 = new Label();
            deductionTextBox = new TextBox();
            SuspendLayout();
            // 
            // incomeTextBox
            // 
            incomeTextBox.Location = new Point(151, 121);
            incomeTextBox.Name = "incomeTextBox";
            incomeTextBox.Size = new Size(125, 27);
            incomeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 124);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter a W2 Income";
            // 
            // button1
            // 
            button1.Location = new Point(292, 124);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 2;
            button1.Text = "Add Income";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // taxesOwedLabel
            // 
            taxesOwedLabel.AutoSize = true;
            taxesOwedLabel.Location = new Point(436, 52);
            taxesOwedLabel.Name = "taxesOwedLabel";
            taxesOwedLabel.Size = new Size(90, 20);
            taxesOwedLabel.TabIndex = 3;
            taxesOwedLabel.Text = "Taxes Owed:";
            // 
            // button2
            // 
            button2.Location = new Point(292, 172);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 6;
            button2.Text = "Add Deduction";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 172);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 5;
            label2.Text = "Enter a deduction";
            // 
            // deductionTextBox
            // 
            deductionTextBox.Location = new Point(151, 169);
            deductionTextBox.Name = "deductionTextBox";
            deductionTextBox.Size = new Size(125, 27);
            deductionTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(deductionTextBox);
            Controls.Add(taxesOwedLabel);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(incomeTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox incomeTextBox;
        private Label label1;
        private Button button1;
        private Label taxesOwedLabel;
        private Button button2;
        private Label label2;
        private TextBox deductionTextBox;
    }
}