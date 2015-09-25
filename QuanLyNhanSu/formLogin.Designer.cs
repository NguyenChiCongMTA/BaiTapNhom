namespace QuanLyNhanSu
{
    partial class formLogin
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
            this.titTle_lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.pWordBox = new System.Windows.Forms.TextBox();
            this.logInBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titTle_lab
            // 
            this.titTle_lab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titTle_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titTle_lab.Location = new System.Drawing.Point(46, 9);
            this.titTle_lab.Name = "titTle_lab";
            this.titTle_lab.Size = new System.Drawing.Size(408, 44);
            this.titTle_lab.TabIndex = 0;
            this.titTle_lab.Text = "QUẢN LÝ NHÂN SỰ";
            this.titTle_lab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usermame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // uNameBox
            // 
            this.uNameBox.Location = new System.Drawing.Point(198, 116);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(179, 20);
            this.uNameBox.TabIndex = 3;
            // 
            // pWordBox
            // 
            this.pWordBox.Location = new System.Drawing.Point(198, 174);
            this.pWordBox.Name = "pWordBox";
            this.pWordBox.Size = new System.Drawing.Size(179, 20);
            this.pWordBox.TabIndex = 4;
            // 
            // logInBut
            // 
            this.logInBut.Location = new System.Drawing.Point(219, 228);
            this.logInBut.Name = "logInBut";
            this.logInBut.Size = new System.Drawing.Size(75, 23);
            this.logInBut.TabIndex = 5;
            this.logInBut.Text = "Đăng nhập";
            this.logInBut.UseVisualStyleBackColor = true;
            this.logInBut.Click += new System.EventHandler(this.logInBut_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 277);
            this.Controls.Add(this.logInBut);
            this.Controls.Add(this.pWordBox);
            this.Controls.Add(this.uNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titTle_lab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titTle_lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.TextBox pWordBox;
        private System.Windows.Forms.Button logInBut;
    }
}

