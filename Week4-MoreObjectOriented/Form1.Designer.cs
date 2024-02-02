namespace Week4_MoreObjectOriented
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
            button1 = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            studentLabel = new Label();
            button2 = new Button();
            lengthTextBox = new TextBox();
            widthTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            polygonLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(327, 109);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 0;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(174, 111);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 116);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(552, 104);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(69, 20);
            studentLabel.TabIndex = 3;
            studentLabel.Text = "Students:";
            // 
            // button2
            // 
            button2.Location = new Point(263, 288);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 4;
            button2.Text = "Add Rectangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(110, 258);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(125, 27);
            lengthTextBox.TabIndex = 5;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(114, 311);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(125, 27);
            widthTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 265);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 7;
            label2.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 318);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Width";
            // 
            // button3
            // 
            button3.Location = new Point(263, 377);
            button3.Name = "button3";
            button3.Size = new Size(149, 29);
            button3.TabIndex = 9;
            button3.Text = "Add Triangle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // polygonLabel
            // 
            polygonLabel.AutoSize = true;
            polygonLabel.Location = new Point(539, 303);
            polygonLabel.Name = "polygonLabel";
            polygonLabel.Size = new Size(68, 20);
            polygonLabel.TabIndex = 10;
            polygonLabel.Text = "Polygons";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(polygonLabel);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(widthTextBox);
            Controls.Add(lengthTextBox);
            Controls.Add(button2);
            Controls.Add(studentLabel);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox nameTextBox;
        private Label label1;
        private Label studentLabel;
        private Button button2;
        private TextBox lengthTextBox;
        private TextBox widthTextBox;
        private Label label2;
        private Label label3;
        private Button button3;
        private Label polygonLabel;
    }
}