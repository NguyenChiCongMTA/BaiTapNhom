namespace WindowsFormsApplication1
{
    partial class Login
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
            this.Login_but_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_uname_box = new System.Windows.Forms.TextBox();
            this.Login_pword_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_but_ok
            // 
            this.Login_but_ok.Location = new System.Drawing.Point(140, 125);
            this.Login_but_ok.Name = "Login_but_ok";
            this.Login_but_ok.Size = new System.Drawing.Size(75, 23);
            this.Login_but_ok.TabIndex = 0;
            this.Login_but_ok.Text = "OK";
            this.Login_but_ok.UseVisualStyleBackColor = true;
            this.Login_but_ok.Click += new System.EventHandler(this.Login_but_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Login_uname_box
            // 
            this.Login_uname_box.Location = new System.Drawing.Point(140, 50);
            this.Login_uname_box.Name = "Login_uname_box";
            this.Login_uname_box.Size = new System.Drawing.Size(100, 20);
            this.Login_uname_box.TabIndex = 3;
            // 
            // Login_pword_box
            // 
            this.Login_pword_box.Location = new System.Drawing.Point(140, 77);
            this.Login_pword_box.Name = "Login_pword_box";
            this.Login_pword_box.Size = new System.Drawing.Size(100, 20);
            this.Login_pword_box.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 180);
            this.Controls.Add(this.Login_pword_box);
            this.Controls.Add(this.Login_uname_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_but_ok);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_but_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_uname_box;
        private System.Windows.Forms.TextBox Login_pword_box;
    }
}

