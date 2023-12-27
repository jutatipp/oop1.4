namespace lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            picture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Location = new Point(235, 172);
            button1.Name = "button1";
            button1.Size = new Size(70, 29);
            button1.TabIndex = 0;
            button1.Text = "กาแฟดำ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Location = new Point(311, 172);
            button2.Name = "button2";
            button2.Size = new Size(57, 29);
            button2.TabIndex = 1;
            button2.Text = "มอลค่า";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Location = new Point(235, 254);
            button3.Name = "button3";
            button3.Size = new Size(47, 29);
            button3.TabIndex = 2;
            button3.Text = "ลาเต้";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.Location = new Point(288, 254);
            button4.Name = "button4";
            button4.Size = new Size(82, 29);
            button4.TabIndex = 3;
            button4.Text = "ช็อตโกแลต";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(551, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // picture
            // 
            picture.BackColor = Color.PapayaWhip;
            picture.Image = Properties.Resources.BlackC;
            picture.Location = new Point(299, 306);
            picture.Name = "picture";
            picture.Size = new Size(84, 90);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 5;
            picture.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 564);
            Controls.Add(picture);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox picture;
    }
}
