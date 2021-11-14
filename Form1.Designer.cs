
namespace login
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.TextBox();
            this.lbpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Registrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "email";
            // 
            // lbemail
            // 
            this.lbemail.Location = new System.Drawing.Point(225, 162);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(200, 20);
            this.lbemail.TabIndex = 1;
            // 
            // lbpassword
            // 
            this.lbpassword.Location = new System.Drawing.Point(225, 306);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(200, 20);
            this.lbpassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "password";
            // 
            // lbusername
            // 
            this.lbusername.Location = new System.Drawing.Point(225, 234);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(200, 20);
            this.lbusername.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "username";
            // 
            // Registrati
            // 
            this.Registrati.Location = new System.Drawing.Point(225, 348);
            this.Registrati.Name = "Registrati";
            this.Registrati.Size = new System.Drawing.Size(100, 23);
            this.Registrati.TabIndex = 6;
            this.Registrati.Text = "Registrati";
            this.Registrati.UseVisualStyleBackColor = true;
            this.Registrati.Click += new System.EventHandler(this.Registrati_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 613);
            this.Controls.Add(this.Registrati);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbemail;
        private System.Windows.Forms.TextBox lbpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Registrati;
    }
}

