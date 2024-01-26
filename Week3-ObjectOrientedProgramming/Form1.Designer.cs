namespace Week3_ObjectOrientedProgramming
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
            lengthTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            widthTextBox = new TextBox();
            makeRectangleButton = new Button();
            rectangleLabel = new Label();
            areaLabel = new Label();
            perimeterLabel = new Label();
            lengthSlider = new TrackBar();
            label3 = new Label();
            circleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)lengthSlider).BeginInit();
            SuspendLayout();
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(195, 90);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(125, 27);
            lengthTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 95);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 144);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Width";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(195, 139);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(125, 27);
            widthTextBox.TabIndex = 2;
            // 
            // makeRectangleButton
            // 
            makeRectangleButton.Location = new Point(348, 95);
            makeRectangleButton.Name = "makeRectangleButton";
            makeRectangleButton.Size = new Size(94, 80);
            makeRectangleButton.TabIndex = 4;
            makeRectangleButton.Text = "Make a rectangle";
            makeRectangleButton.UseVisualStyleBackColor = true;
            makeRectangleButton.Click += makeRectangleButton_Click;
            // 
            // rectangleLabel
            // 
            rectangleLabel.AutoSize = true;
            rectangleLabel.Location = new Point(529, 120);
            rectangleLabel.Name = "rectangleLabel";
            rectangleLabel.Size = new Size(0, 20);
            rectangleLabel.TabIndex = 5;
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new Point(475, 263);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(47, 20);
            areaLabel.TabIndex = 6;
            areaLabel.Text = "Area: ";
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Location = new Point(612, 263);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(79, 20);
            perimeterLabel.TabIndex = 7;
            perimeterLabel.Text = "Perimeter: ";
            // 
            // lengthSlider
            // 
            lengthSlider.Location = new Point(141, 217);
            lengthSlider.Name = "lengthSlider";
            lengthSlider.Size = new Size(242, 56);
            lengthSlider.TabIndex = 8;
            lengthSlider.Scroll += lengthSlider_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // circleLabel
            // 
            circleLabel.AutoSize = true;
            circleLabel.Location = new Point(284, 367);
            circleLabel.Name = "circleLabel";
            circleLabel.Size = new Size(101, 20);
            circleLabel.TabIndex = 10;
            circleLabel.Text = "Circle Radius: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(circleLabel);
            Controls.Add(label3);
            Controls.Add(lengthSlider);
            Controls.Add(perimeterLabel);
            Controls.Add(areaLabel);
            Controls.Add(rectangleLabel);
            Controls.Add(makeRectangleButton);
            Controls.Add(label2);
            Controls.Add(widthTextBox);
            Controls.Add(label1);
            Controls.Add(lengthTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)lengthSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lengthTextBox;
        private Label label1;
        private Label label2;
        private TextBox widthTextBox;
        private Button makeRectangleButton;
        private Label rectangleLabel;
        private Label areaLabel;
        private Label perimeterLabel;
        private TrackBar lengthSlider;
        private Label label3;
        private Label circleLabel;
    }
}