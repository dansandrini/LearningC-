namespace Danilo_FinalExam
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fbt_reset = new System.Windows.Forms.Button();
            this.fbt_exit = new System.Windows.Forms.Button();
            this.ftx_student = new System.Windows.Forms.TextBox();
            this.ftx_session = new System.Windows.Forms.TextBox();
            this.ftx_year = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "420-CT2-AS - Final Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name and ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Schedule : Tu. 08:00-11:00 & Th. 8:00-11:00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Session:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year:";
            // 
            // fbt_reset
            // 
            this.fbt_reset.Location = new System.Drawing.Point(27, 224);
            this.fbt_reset.Name = "fbt_reset";
            this.fbt_reset.Size = new System.Drawing.Size(75, 23);
            this.fbt_reset.TabIndex = 5;
            this.fbt_reset.Text = "&Reset";
            this.fbt_reset.UseVisualStyleBackColor = true;
            this.fbt_reset.Click += new System.EventHandler(this.fbt_reset_Click);
            // 
            // fbt_exit
            // 
            this.fbt_exit.Location = new System.Drawing.Point(399, 224);
            this.fbt_exit.Name = "fbt_exit";
            this.fbt_exit.Size = new System.Drawing.Size(75, 23);
            this.fbt_exit.TabIndex = 6;
            this.fbt_exit.Text = "E&xit";
            this.fbt_exit.UseVisualStyleBackColor = true;
            this.fbt_exit.Click += new System.EventHandler(this.fbt_exit_Click);
            // 
            // ftx_student
            // 
            this.ftx_student.Location = new System.Drawing.Point(141, 73);
            this.ftx_student.Name = "ftx_student";
            this.ftx_student.Size = new System.Drawing.Size(254, 20);
            this.ftx_student.TabIndex = 7;
            this.ftx_student.Text = "Danilo Testa Sandrini - 2320014";
            // 
            // ftx_session
            // 
            this.ftx_session.Location = new System.Drawing.Point(141, 132);
            this.ftx_session.Name = "ftx_session";
            this.ftx_session.Size = new System.Drawing.Size(108, 20);
            this.ftx_session.TabIndex = 8;
            this.ftx_session.Text = "Fall";
            // 
            // ftx_year
            // 
            this.ftx_year.Location = new System.Drawing.Point(140, 161);
            this.ftx_year.Name = "ftx_year";
            this.ftx_year.Size = new System.Drawing.Size(77, 20);
            this.ftx_year.TabIndex = 9;
            this.ftx_year.Text = "2023";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Danilo_FinalExam.Properties.Resources._7182;
            this.pictureBox1.Location = new System.Drawing.Point(167, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(398, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 70);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course Number: 420-CT2-AS     gr. 7182   Teacher Name: Mihai Maftei";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 283);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ftx_year);
            this.Controls.Add(this.ftx_session);
            this.Controls.Add(this.ftx_student);
            this.Controls.Add(this.fbt_exit);
            this.Controls.Add(this.fbt_reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form (Danilo Sandrini)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fbt_reset;
        private System.Windows.Forms.Button fbt_exit;
        private System.Windows.Forms.TextBox ftx_student;
        private System.Windows.Forms.TextBox ftx_session;
        private System.Windows.Forms.TextBox ftx_year;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

