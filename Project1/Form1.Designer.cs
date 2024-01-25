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
            textBox = new TextBox();
            label1 = new Label();
            addButton = new Button();
            taxesOwedLabel = new Label();
            incomeRadioButton = new RadioButton();
            deductionRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(151, 121);
            textBox.Name = "textBox";
            textBox.Size = new Size(125, 27);
            textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 124);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter a value";
            // 
            // addButton
            // 
            addButton.Enabled = false;
            addButton.Location = new Point(282, 119);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 29);
            addButton.TabIndex = 2;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
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
            // incomeRadioButton
            // 
            incomeRadioButton.AutoSize = true;
            incomeRadioButton.Location = new Point(123, 75);
            incomeRadioButton.Name = "incomeRadioButton";
            incomeRadioButton.Size = new Size(105, 24);
            incomeRadioButton.TabIndex = 7;
            incomeRadioButton.Text = "W2 Income";
            incomeRadioButton.UseVisualStyleBackColor = true;
            incomeRadioButton.CheckedChanged += incomeRadioButton_CheckedChanged;
            // 
            // deductionRadioButton
            // 
            deductionRadioButton.AutoSize = true;
            deductionRadioButton.Location = new Point(256, 75);
            deductionRadioButton.Name = "deductionRadioButton";
            deductionRadioButton.Size = new Size(99, 24);
            deductionRadioButton.TabIndex = 8;
            deductionRadioButton.Text = "Deduction";
            deductionRadioButton.UseVisualStyleBackColor = true;
            deductionRadioButton.CheckedChanged += deductionRadioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deductionRadioButton);
            Controls.Add(incomeRadioButton);
            Controls.Add(taxesOwedLabel);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Label label1;
        private Button addButton;
        private Label taxesOwedLabel;
        private RadioButton incomeRadioButton;
        private RadioButton deductionRadioButton;
    }
}