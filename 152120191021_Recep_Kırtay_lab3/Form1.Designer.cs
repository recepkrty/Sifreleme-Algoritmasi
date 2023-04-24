namespace _152120191021_Recep_Kırtay_lab3
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
            textBox_studentID = new TextBox();
            label_studentID = new Label();
            textBox_metin = new TextBox();
            label_metin = new Label();
            groupBox_algorithm = new GroupBox();
            radioButton_Vigenere = new RadioButton();
            radioButton_Caesar = new RadioButton();
            groupBox_şifreleme = new GroupBox();
            radioButton_deşifreleme = new RadioButton();
            radioButton_şifreleme = new RadioButton();
            button_şifrele = new Button();
            label_şifrelenmişmetin = new Label();
            label_output = new Label();
            label_score = new Label();
            groupBox_algorithm.SuspendLayout();
            groupBox_şifreleme.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_studentID
            // 
            textBox_studentID.Location = new Point(176, 30);
            textBox_studentID.Name = "textBox_studentID";
            textBox_studentID.Size = new Size(129, 23);
            textBox_studentID.TabIndex = 0;
            textBox_studentID.Text = "20191021";
            textBox_studentID.KeyPress += textBox_studentID_KeyPress;
            // 
            // label_studentID
            // 
            label_studentID.AutoSize = true;
            label_studentID.Location = new Point(61, 33);
            label_studentID.Name = "label_studentID";
            label_studentID.Size = new Size(109, 15);
            label_studentID.TabIndex = 1;
            label_studentID.Text = "Öğrenci Numarası :";
            // 
            // textBox_metin
            // 
            textBox_metin.Location = new Point(61, 120);
            textBox_metin.Multiline = true;
            textBox_metin.Name = "textBox_metin";
            textBox_metin.Size = new Size(368, 101);
            textBox_metin.TabIndex = 2;
            textBox_metin.Text = "MERHABA DUNYALI NASILSIN";
            textBox_metin.KeyPress += textBox_metin_KeyPress;
            // 
            // label_metin
            // 
            label_metin.AutoSize = true;
            label_metin.Location = new Point(61, 93);
            label_metin.Name = "label_metin";
            label_metin.Size = new Size(203, 15);
            label_metin.TabIndex = 3;
            label_metin.Text = "Şifrelenecek/Şifresi Çözülecek Metin :";
            // 
            // groupBox_algorithm
            // 
            groupBox_algorithm.Controls.Add(radioButton_Vigenere);
            groupBox_algorithm.Controls.Add(radioButton_Caesar);
            groupBox_algorithm.Location = new Point(521, 25);
            groupBox_algorithm.Name = "groupBox_algorithm";
            groupBox_algorithm.Size = new Size(200, 95);
            groupBox_algorithm.TabIndex = 4;
            groupBox_algorithm.TabStop = false;
            groupBox_algorithm.Text = "Algoritmalar";
            // 
            // radioButton_Vigenere
            // 
            radioButton_Vigenere.AutoSize = true;
            radioButton_Vigenere.Location = new Point(14, 55);
            radioButton_Vigenere.Name = "radioButton_Vigenere";
            radioButton_Vigenere.Size = new Size(109, 19);
            radioButton_Vigenere.TabIndex = 1;
            radioButton_Vigenere.Text = "Vigenere Cipher";
            radioButton_Vigenere.UseVisualStyleBackColor = true;
            // 
            // radioButton_Caesar
            // 
            radioButton_Caesar.AutoSize = true;
            radioButton_Caesar.Checked = true;
            radioButton_Caesar.Location = new Point(14, 30);
            radioButton_Caesar.Name = "radioButton_Caesar";
            radioButton_Caesar.Size = new Size(98, 19);
            radioButton_Caesar.TabIndex = 0;
            radioButton_Caesar.TabStop = true;
            radioButton_Caesar.Text = "Caesar Cipher";
            radioButton_Caesar.UseVisualStyleBackColor = true;
            // 
            // groupBox_şifreleme
            // 
            groupBox_şifreleme.Controls.Add(radioButton_deşifreleme);
            groupBox_şifreleme.Controls.Add(radioButton_şifreleme);
            groupBox_şifreleme.Location = new Point(521, 126);
            groupBox_şifreleme.Name = "groupBox_şifreleme";
            groupBox_şifreleme.Size = new Size(200, 95);
            groupBox_şifreleme.TabIndex = 5;
            groupBox_şifreleme.TabStop = false;
            groupBox_şifreleme.Text = "Şifreleme/Deşifreleme";
            // 
            // radioButton_deşifreleme
            // 
            radioButton_deşifreleme.AutoSize = true;
            radioButton_deşifreleme.Location = new Point(14, 56);
            radioButton_deşifreleme.Name = "radioButton_deşifreleme";
            radioButton_deşifreleme.Size = new Size(87, 19);
            radioButton_deşifreleme.TabIndex = 3;
            radioButton_deşifreleme.Text = "Deşifreleme";
            radioButton_deşifreleme.UseVisualStyleBackColor = true;
            // 
            // radioButton_şifreleme
            // 
            radioButton_şifreleme.AutoSize = true;
            radioButton_şifreleme.Checked = true;
            radioButton_şifreleme.Location = new Point(14, 31);
            radioButton_şifreleme.Name = "radioButton_şifreleme";
            radioButton_şifreleme.Size = new Size(74, 19);
            radioButton_şifreleme.TabIndex = 2;
            radioButton_şifreleme.TabStop = true;
            radioButton_şifreleme.Text = "Şifreleme";
            radioButton_şifreleme.UseVisualStyleBackColor = true;
            // 
            // button_şifrele
            // 
            button_şifrele.BackColor = Color.MediumSpringGreen;
            button_şifrele.ForeColor = Color.Navy;
            button_şifrele.Location = new Point(521, 227);
            button_şifrele.Name = "button_şifrele";
            button_şifrele.Size = new Size(200, 54);
            button_şifrele.TabIndex = 6;
            button_şifrele.Text = "Şifrele / Deşifrele";
            button_şifrele.UseVisualStyleBackColor = false;
            button_şifrele.Click += button_şifrele_Click;
            // 
            // label_şifrelenmişmetin
            // 
            label_şifrelenmişmetin.AutoSize = true;
            label_şifrelenmişmetin.Location = new Point(61, 309);
            label_şifrelenmişmetin.Name = "label_şifrelenmişmetin";
            label_şifrelenmişmetin.Size = new Size(187, 15);
            label_şifrelenmişmetin.TabIndex = 7;
            label_şifrelenmişmetin.Text = "Şifrelenmiş / Deşifrelenmiş Metin :";
            // 
            // label_output
            // 
            label_output.AutoSize = true;
            label_output.Location = new Point(61, 354);
            label_output.Name = "label_output";
            label_output.Size = new Size(0, 15);
            label_output.TabIndex = 8;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.BackColor = SystemColors.Control;
            label_score.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_score.ForeColor = SystemColors.ControlText;
            label_score.Location = new Point(345, 30);
            label_score.Name = "label_score";
            label_score.Size = new Size(71, 25);
            label_score.TabIndex = 9;
            label_score.Text = "SKOR : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_score);
            Controls.Add(label_output);
            Controls.Add(label_şifrelenmişmetin);
            Controls.Add(button_şifrele);
            Controls.Add(groupBox_şifreleme);
            Controls.Add(groupBox_algorithm);
            Controls.Add(label_metin);
            Controls.Add(textBox_metin);
            Controls.Add(label_studentID);
            Controls.Add(textBox_studentID);
            Name = "Form1";
            Text = "App - 3";
            groupBox_algorithm.ResumeLayout(false);
            groupBox_algorithm.PerformLayout();
            groupBox_şifreleme.ResumeLayout(false);
            groupBox_şifreleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_studentID;
        private Label label_studentID;
        private TextBox textBox_metin;
        private Label label_metin;
        private GroupBox groupBox_algorithm;
        private RadioButton radioButton_Vigenere;
        private RadioButton radioButton_Caesar;
        private GroupBox groupBox_şifreleme;
        private RadioButton radioButton_deşifreleme;
        private RadioButton radioButton_şifreleme;
        private Button button_şifrele;
        private Label label_şifrelenmişmetin;
        private Label label_output;
        private Label label_score;
    }
}