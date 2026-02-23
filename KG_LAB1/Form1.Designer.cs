namespace KG_LAB1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            xCoordinateTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            yCoordinateTextBox = new TextBox();
            label4 = new Label();
            SideLengthTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 245, 245);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(xCoordinateTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(yCoordinateTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SideLengthTextBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(260, 903);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(230, 45);
            label1.TabIndex = 0;
            label1.Text = "Центр трикутника (X, Y):";
            // 
            // xCoordinateTextBox
            // 
            xCoordinateTextBox.Location = new Point(45, 60);
            xCoordinateTextBox.Name = "xCoordinateTextBox";
            xCoordinateTextBox.Size = new Size(70, 27);
            xCoordinateTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(25, 27);
            label2.TabIndex = 1;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.Location = new Point(135, 63);
            label3.Name = "label3";
            label3.Size = new Size(25, 27);
            label3.TabIndex = 3;
            label3.Text = "Y:";
            // 
            // yCoordinateTextBox
            // 
            yCoordinateTextBox.Location = new Point(165, 60);
            yCoordinateTextBox.Name = "yCoordinateTextBox";
            yCoordinateTextBox.Size = new Size(70, 27);
            yCoordinateTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 110);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 5;
            label4.Text = "Довжина сторони:";
            // 
            // SideLengthTextBox
            // 
            SideLengthTextBox.Location = new Point(15, 138);
            SideLengthTextBox.Name = "SideLengthTextBox";
            SideLengthTextBox.Size = new Size(220, 27);
            SideLengthTextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 235, 252);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(15, 185);
            button1.Name = "button1";
            button1.Size = new Size(220, 45);
            button1.TabIndex = 7;
            button1.Text = "Намалювати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 236);
            button2.Name = "button2";
            button2.Size = new Size(220, 40);
            button2.TabIndex = 8;
            button2.Text = "Колір трикутника";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(15, 282);
            button3.Name = "button3";
            button3.Size = new Size(220, 40);
            button3.TabIndex = 9;
            button3.Text = "Колір медіан";
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(15, 350);
            button5.Name = "button5";
            button5.Size = new Size(220, 40);
            button5.TabIndex = 10;
            button5.Text = "Зберегти у файл";
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(15, 396);
            button6.Name = "button6";
            button6.Size = new Size(220, 40);
            button6.TabIndex = 11;
            button6.Text = "Завантажити";
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.DarkRed;
            button4.Location = new Point(15, 460);
            button4.Name = "button4";
            button4.Size = new Size(220, 40);
            button4.TabIndex = 12;
            button4.Text = "Очистити ";
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(260, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1522, 903);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 903);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "лаб1 кг";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private Button button4;
        private Button button5;
        private Button button6;
    }
}