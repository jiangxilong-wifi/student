﻿namespace Student_Gender
{
    partial class xiugai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_photo = new System.Windows.Forms.TextBox();
            this.label_photo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_class = new System.Windows.Forms.Label();
            this.textBox_birthday = new System.Windows.Forms.TextBox();
            this.label_birthday = new System.Windows.Forms.Label();
            this.radioButton_gril = new System.Windows.Forms.RadioButton();
            this.radioButton_boy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_student_name = new System.Windows.Forms.TextBox();
            this.label_student_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(121, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_photo
            // 
            this.textBox_photo.Location = new System.Drawing.Point(154, 307);
            this.textBox_photo.Name = "textBox_photo";
            this.textBox_photo.Size = new System.Drawing.Size(133, 21);
            this.textBox_photo.TabIndex = 22;
            // 
            // label_photo
            // 
            this.label_photo.AutoSize = true;
            this.label_photo.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_photo.Location = new System.Drawing.Point(91, 308);
            this.label_photo.Name = "label_photo";
            this.label_photo.Size = new System.Drawing.Size(39, 20);
            this.label_photo.TabIndex = 21;
            this.label_photo.Text = "照片";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2019173808",
            "2019173807",
            "2019182901"});
            this.comboBox1.Location = new System.Drawing.Point(154, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 20);
            this.comboBox1.TabIndex = 20;
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_class.Location = new System.Drawing.Point(61, 249);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(69, 20);
            this.label_class.TabIndex = 19;
            this.label_class.Text = "学生班级";
            // 
            // textBox_birthday
            // 
            this.textBox_birthday.Location = new System.Drawing.Point(154, 180);
            this.textBox_birthday.Name = "textBox_birthday";
            this.textBox_birthday.Size = new System.Drawing.Size(133, 21);
            this.textBox_birthday.TabIndex = 18;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_birthday.Location = new System.Drawing.Point(61, 180);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(69, 20);
            this.label_birthday.TabIndex = 17;
            this.label_birthday.Text = "出生日期";
            // 
            // radioButton_gril
            // 
            this.radioButton_gril.AutoSize = true;
            this.radioButton_gril.Location = new System.Drawing.Point(252, 115);
            this.radioButton_gril.Name = "radioButton_gril";
            this.radioButton_gril.Size = new System.Drawing.Size(35, 16);
            this.radioButton_gril.TabIndex = 16;
            this.radioButton_gril.TabStop = true;
            this.radioButton_gril.Text = "女";
            this.radioButton_gril.UseVisualStyleBackColor = true;
            // 
            // radioButton_boy
            // 
            this.radioButton_boy.AutoSize = true;
            this.radioButton_boy.Location = new System.Drawing.Point(154, 115);
            this.radioButton_boy.Name = "radioButton_boy";
            this.radioButton_boy.Size = new System.Drawing.Size(35, 16);
            this.radioButton_boy.TabIndex = 15;
            this.radioButton_boy.TabStop = true;
            this.radioButton_boy.Text = "男";
            this.radioButton_boy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "学生性别";
            // 
            // textBox_student_name
            // 
            this.textBox_student_name.Location = new System.Drawing.Point(154, 53);
            this.textBox_student_name.Name = "textBox_student_name";
            this.textBox_student_name.Size = new System.Drawing.Size(133, 21);
            this.textBox_student_name.TabIndex = 13;
            // 
            // label_student_name
            // 
            this.label_student_name.AutoSize = true;
            this.label_student_name.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_student_name.Location = new System.Drawing.Point(61, 53);
            this.label_student_name.Name = "label_student_name";
            this.label_student_name.Size = new System.Drawing.Size(69, 20);
            this.label_student_name.TabIndex = 12;
            this.label_student_name.Text = "学生姓名";
            // 
            // xiugai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_photo);
            this.Controls.Add(this.label_photo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.textBox_birthday);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.radioButton_gril);
            this.Controls.Add(this.radioButton_boy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_student_name);
            this.Controls.Add(this.label_student_name);
            this.Name = "xiugai";
            this.Text = "信息修改";
            this.Load += new System.EventHandler(this.xiugai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_photo;
        private System.Windows.Forms.Label label_photo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.TextBox textBox_birthday;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.RadioButton radioButton_gril;
        private System.Windows.Forms.RadioButton radioButton_boy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_student_name;
        private System.Windows.Forms.Label label_student_name;
    }
}