﻿namespace Draw_Test
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox3 = new GroupBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox8 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(218, 357);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top;
            numericUpDown1.Location = new Point(6, 22);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(68, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 449);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(439, 346);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(80, 54);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Runs";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(248, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 328);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(259, 300);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(12, 357);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 9;
            button2.Text = "ChangeBitmap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.Title = "Bitmap selector";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 49);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(142, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "bufferedGraphic Draw";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 74);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(159, 19);
            checkBox4.TabIndex = 13;
            checkBox4.Text = "bufferedGraphics Refresh";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox8);
            groupBox3.Controls.Add(checkBox7);
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Location = new Point(1, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 333);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Test Methodes";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 174);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(167, 19);
            checkBox7.TabIndex = 19;
            checkBox7.Text = "buffered Draw Matrix Parts";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 149);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(138, 19);
            checkBox6.TabIndex = 18;
            checkBox6.Text = "buffered Draw Matrix";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 124);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(193, 19);
            checkBox5.TabIndex = 17;
            checkBox5.Text = "bufferedGraphic Draw Unscaled";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 99);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(177, 19);
            checkBox3.TabIndex = 16;
            checkBox3.Text = "DrawImageUnscaled Directly";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "DrawImage Directly";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(6, 199);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(162, 19);
            checkBox8.TabIndex = 20;
            checkBox8.Text = "buffered Draw Matrix Part";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 412);
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
    }
}
