namespace Приложуха
{
    partial class Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg));
            this.LoginBox1 = new System.Windows.Forms.TextBox();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.PassBox3 = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.LoginRegistr = new System.Windows.Forms.Label();
            this.PasswordRegistr = new System.Windows.Forms.Label();
            this.PasswordRegistrPovtor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBox1
            // 
            this.LoginBox1.Location = new System.Drawing.Point(80, 38);
            this.LoginBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBox1.Name = "LoginBox1";
            this.LoginBox1.Size = new System.Drawing.Size(239, 22);
            this.LoginBox1.TabIndex = 0;
            // 
            // PassBox2
            // 
            this.PassBox2.Location = new System.Drawing.Point(80, 70);
            this.PassBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.Size = new System.Drawing.Size(239, 22);
            this.PassBox2.TabIndex = 1;
            this.PassBox2.UseSystemPasswordChar = true;
            // 
            // PassBox3
            // 
            this.PassBox3.Location = new System.Drawing.Point(80, 102);
            this.PassBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassBox3.Name = "PassBox3";
            this.PassBox3.Size = new System.Drawing.Size(239, 22);
            this.PassBox3.TabIndex = 2;
            this.PassBox3.UseSystemPasswordChar = true;
            // 
            // RegButton
            // 
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Location = new System.Drawing.Point(61, 154);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(132, 44);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelbutton.Location = new System.Drawing.Point(220, 154);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(128, 44);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(328, 73);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(328, 105);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // LoginRegistr
            // 
            this.LoginRegistr.AutoSize = true;
            this.LoginRegistr.Location = new System.Drawing.Point(6, 38);
            this.LoginRegistr.Name = "LoginRegistr";
            this.LoginRegistr.Size = new System.Drawing.Size(40, 16);
            this.LoginRegistr.TabIndex = 7;
            this.LoginRegistr.Text = "Login";
            // 
            // PasswordRegistr
            // 
            this.PasswordRegistr.AutoSize = true;
            this.PasswordRegistr.Location = new System.Drawing.Point(6, 70);
            this.PasswordRegistr.Name = "PasswordRegistr";
            this.PasswordRegistr.Size = new System.Drawing.Size(67, 16);
            this.PasswordRegistr.TabIndex = 8;
            this.PasswordRegistr.Text = "Password";
            
            // 
            // PasswordRegistrPovtor
            // 
            this.PasswordRegistrPovtor.AutoSize = true;
            this.PasswordRegistrPovtor.Location = new System.Drawing.Point(6, 104);
            this.PasswordRegistrPovtor.Name = "PasswordRegistrPovtor";
            this.PasswordRegistrPovtor.Size = new System.Drawing.Size(67, 16);
            this.PasswordRegistrPovtor.TabIndex = 9;
            this.PasswordRegistrPovtor.Text = "Password";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(401, 222);
            this.Controls.Add(this.PasswordRegistrPovtor);
            this.Controls.Add(this.PasswordRegistr);
            this.Controls.Add(this.LoginRegistr);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.PassBox3);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.LoginBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox1;
        private System.Windows.Forms.TextBox PassBox2;
        private System.Windows.Forms.TextBox PassBox3;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label LoginRegistr;
        private System.Windows.Forms.Label PasswordRegistr;
        private System.Windows.Forms.Label PasswordRegistrPovtor;
    }
}