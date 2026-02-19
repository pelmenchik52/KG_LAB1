namespace KG_LAB1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            xCoordinateTextBox = new TextBox();
            yCoordinateTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SideLengthTextBox = new TextBox();
            colorDialog1 = new ColorDialog();
            button2 = new Button();
            button3 = new Button();
            colorDialog2 = new ColorDialog();
            trackBar1 = new TrackBar();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(12, 157);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(235, 44);
            button1.TabIndex = 0;
            button1.Text = "Намалювати трикутник";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(253, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1037, 589);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(235, 41);
            label1.TabIndex = 2;
            label1.Text = "Координати центру рівностороннього трикутника";
            // 
            // xCoordinateTextBox
            // 
            xCoordinateTextBox.Location = new Point(46, 79);
            xCoordinateTextBox.Name = "xCoordinateTextBox";
            xCoordinateTextBox.Size = new Size(56, 27);
            xCoordinateTextBox.TabIndex = 3;
            // 
            // yCoordinateTextBox
            // 
            yCoordinateTextBox.Location = new Point(152, 79);
            yCoordinateTextBox.Name = "yCoordinateTextBox";
            yCoordinateTextBox.Size = new Size(56, 27);
            yCoordinateTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(20, 19);
            label2.TabIndex = 5;
            label2.Text = "X: ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(126, 83);
            label3.Name = "label3";
            label3.Size = new Size(20, 19);
            label3.TabIndex = 6;
            label3.Text = "Y: ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(121, 24);
            label4.TabIndex = 7;
            label4.Text = "Довжина сторони ";
            // 
            // SideLengthTextBox
            // 
            SideLengthTextBox.Location = new Point(139, 115);
            SideLengthTextBox.Name = "SideLengthTextBox";
            SideLengthTextBox.Size = new Size(108, 27);
            SideLengthTextBox.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(12, 207);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(235, 44);
            button2.TabIndex = 9;
            button2.Text = "Змінити колір трикутника";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(12, 257);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(235, 44);
            button3.TabIndex = 10;
            button3.Text = "Змінити колір медіан";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1057, 607);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(233, 56);
            trackBar1.TabIndex = 11;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(12, 557);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(235, 44);
            button4.TabIndex = 12;
            button4.Text = "Очистити все";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 673);
            Controls.Add(button4);
            Controls.Add(trackBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(SideLengthTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(yCoordinateTextBox);
            Controls.Add(xCoordinateTextBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox xCoordinateTextBox;
        private TextBox yCoordinateTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SideLengthTextBox;
        private ColorDialog colorDialog1;
        private Button button2;
        private Button button3;
        private ColorDialog colorDialog2;
        private TrackBar trackBar1;
        private Button button4;
    }
}
