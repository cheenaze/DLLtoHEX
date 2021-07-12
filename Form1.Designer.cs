namespace DLLtoHEX
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
            this.Main_b = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.setSecondFile_b = new System.Windows.Forms.Button();
            this.setFirstFile_b = new System.Windows.Forms.Button();
            this.setOutput_b = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Main_b
            // 
            this.Main_b.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Main_b.FlatAppearance.BorderSize = 0;
            this.Main_b.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Main_b.Location = new System.Drawing.Point(12, 12);
            this.Main_b.Name = "Main_b";
            this.Main_b.Size = new System.Drawing.Size(202, 68);
            this.Main_b.TabIndex = 0;
            this.Main_b.Text = "CONVERT TO BYTES";
            this.Main_b.UseVisualStyleBackColor = false;
            this.Main_b.Click += new System.EventHandler(this.Main_b_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 1;
            // 
            // setSecondFile_b
            // 
            this.setSecondFile_b.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.setSecondFile_b.FlatAppearance.BorderSize = 0;
            this.setSecondFile_b.Font = new System.Drawing.Font("JetBrains Mono", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setSecondFile_b.Location = new System.Drawing.Point(115, 86);
            this.setSecondFile_b.Name = "setSecondFile_b";
            this.setSecondFile_b.Size = new System.Drawing.Size(99, 22);
            this.setSecondFile_b.TabIndex = 3;
            this.setSecondFile_b.Text = "set 2nd file";
            this.setSecondFile_b.UseVisualStyleBackColor = false;
            this.setSecondFile_b.Click += new System.EventHandler(this.setSecondFile_b_Click);
            // 
            // setFirstFile_b
            // 
            this.setFirstFile_b.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.setFirstFile_b.FlatAppearance.BorderSize = 0;
            this.setFirstFile_b.Font = new System.Drawing.Font("JetBrains Mono", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setFirstFile_b.Location = new System.Drawing.Point(12, 86);
            this.setFirstFile_b.Name = "setFirstFile_b";
            this.setFirstFile_b.Size = new System.Drawing.Size(97, 22);
            this.setFirstFile_b.TabIndex = 4;
            this.setFirstFile_b.Text = "set 1st file";
            this.setFirstFile_b.UseVisualStyleBackColor = false;
            this.setFirstFile_b.Click += new System.EventHandler(this.setFirstFile_b_Click);
            // 
            // setOutput_b
            // 
            this.setOutput_b.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.setOutput_b.FlatAppearance.BorderSize = 0;
            this.setOutput_b.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setOutput_b.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setOutput_b.Location = new System.Drawing.Point(12, 114);
            this.setOutput_b.Name = "setOutput_b";
            this.setOutput_b.Size = new System.Drawing.Size(202, 30);
            this.setOutput_b.TabIndex = 5;
            this.setOutput_b.Text = "set output";
            this.setOutput_b.UseVisualStyleBackColor = false;
            this.setOutput_b.Click += new System.EventHandler(this.setOutput_b_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(12, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 18);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "file";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(115, 150);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 18);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = ".txt";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(12, 174);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 18);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = ".cpp";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(115, 174);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 18);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = ".c";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(226, 232);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.setOutput_b);
            this.Controls.Add(this.setFirstFile_b);
            this.Controls.Add(this.setSecondFile_b);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Main_b);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "DLLtoHEX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_b;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button setSecondFile_b;
        private System.Windows.Forms.Button setFirstFile_b;
        private System.Windows.Forms.Button setOutput_b;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

