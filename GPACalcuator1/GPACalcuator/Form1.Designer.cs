namespace GPACalcuator
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
            nameBox1 = new TextBox();
            gpaBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            Name1high = new TextBox();
            HighBox2 = new TextBox();
            gpaBox3 = new TextBox();
            lowBox4 = new TextBox();
            avBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Name2low = new TextBox();
            SuspendLayout();
            // 
            // nameBox1
            // 
            nameBox1.Location = new Point(125, 99);
            nameBox1.Name = "nameBox1";
            nameBox1.Size = new Size(125, 27);
            nameBox1.TabIndex = 0;
            // 
            // gpaBox2
            // 
            gpaBox2.Location = new Point(125, 139);
            gpaBox2.Name = "gpaBox2";
            gpaBox2.Size = new Size(125, 27);
            gpaBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 102);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 142);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "GPA";
            // 
            // button1
            // 
            button1.Location = new Point(137, 176);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Name1high
            // 
            Name1high.Location = new Point(398, 99);
            Name1high.Name = "Name1high";
            Name1high.Size = new Size(125, 27);
            Name1high.TabIndex = 5;
            // 
            // HighBox2
            // 
            HighBox2.Location = new Point(547, 99);
            HighBox2.Name = "HighBox2";
            HighBox2.Size = new Size(125, 27);
            HighBox2.TabIndex = 6;
            // 
            // gpaBox3
            // 
            gpaBox3.Location = new Point(547, 220);
            gpaBox3.Name = "gpaBox3";
            gpaBox3.Size = new Size(125, 27);
            gpaBox3.TabIndex = 7;
            // 
            // lowBox4
            // 
            lowBox4.Location = new Point(547, 139);
            lowBox4.Name = "lowBox4";
            lowBox4.Size = new Size(125, 27);
            lowBox4.TabIndex = 8;
            // 
            // avBox5
            // 
            avBox5.Location = new Point(547, 178);
            avBox5.Name = "avBox5";
            avBox5.Size = new Size(125, 27);
            avBox5.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 99);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 10;
            label3.Text = "คะแนนสูงสุด";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 149);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 11;
            label4.Text = "คะแนนต่ำสุด";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 61);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 12;
            label5.Text = "ชื่อ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(594, 61);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "คะแนน";
            // 
            // Name2low
            // 
            Name2low.Location = new Point(398, 142);
            Name2low.Name = "Name2low";
            Name2low.Size = new Size(125, 27);
            Name2low.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Name2low);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(avBox5);
            Controls.Add(lowBox4);
            Controls.Add(gpaBox3);
            Controls.Add(HighBox2);
            Controls.Add(Name1high);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gpaBox2);
            Controls.Add(nameBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox1;
        private TextBox gpaBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox Name1high;
        private TextBox HighBox2;
        private TextBox gpaBox3;
        private TextBox lowBox4;
        private TextBox avBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Name2low;
    }
}
