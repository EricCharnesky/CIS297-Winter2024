namespace WinFormsApp1
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
            clickMeLabel = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            sequenceListBox = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(382, 285);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Click Me!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clickMeLabel
            // 
            clickMeLabel.AutoSize = true;
            clickMeLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clickMeLabel.Location = new Point(87, 54);
            clickMeLabel.Name = "clickMeLabel";
            clickMeLabel.Size = new Size(0, 20);
            clickMeLabel.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(387, 362);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 2;
            nameTextBox.KeyPress += textBoxKeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 365);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter your name";
            // 
            // sequenceListBox
            // 
            sequenceListBox.FormattingEnabled = true;
            sequenceListBox.ItemHeight = 20;
            sequenceListBox.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh" });
            sequenceListBox.Location = new Point(633, 219);
            sequenceListBox.Name = "sequenceListBox";
            sequenceListBox.Size = new Size(150, 104);
            sequenceListBox.TabIndex = 4;
            sequenceListBox.SelectedIndexChanged += sequenceListbox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sequenceListBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(clickMeLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label clickMeLabel;
        private TextBox nameTextBox;
        private Label label1;
        private ListBox sequenceListBox;
    }
}