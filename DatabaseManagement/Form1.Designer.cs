namespace DatabaseManagement
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
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(492, 400);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 120);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(13, 152);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(16, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 348);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên thuộc tính";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Location = new Point(239, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 342);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kiểu dữ liệu";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(555, 382);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu ";
            // 
            // button4
            // 
            button4.Location = new Point(94, 400);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 26;
            button4.Text = "Thêm thuộc tính mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(241, 400);
            button5.Name = "button5";
            button5.Size = new Size(156, 23);
            button5.TabIndex = 27;
            button5.Text = "Thêm kiểu dữ liệu mới";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(20, 21);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(20, 146);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(20, 50);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 24;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(20, 114);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(20, 79);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 25;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gainsboro;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.ForeColor = SystemColors.Desktop;
            richTextBox1.Location = new Point(455, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "Kiểu dữ liệu chính:\n1. String\n2. Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 435);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button4;
        private Button button5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox10;
        private TextBox textBox8;
        private TextBox textBox9;
        private RichTextBox richTextBox1;
    }
}