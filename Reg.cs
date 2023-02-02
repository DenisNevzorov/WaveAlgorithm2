using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложуха
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            LoginBox1.Text = LoginBox1.Text.Trim();
            PassBox2.Text = PassBox2.Text.Trim();
            PassBox3.Text = PassBox3.Text.Trim();
            try
            {
                var user = new User(LoginBox1.Text, PassBox2.Text, PassBox3.Text);
                if (user.CorrectUser() && !user.UsernameExist())
                {
                    user.CreateUser();
                    this.Hide();
                    Auther main = new Auther();
                    main.FormClosed += (s, args) => this.Close();
                    main.Show();
                }
                else
                {
                   MessageBox.Show("Имя пользователя уже занято", "Ошибка регистрации",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auther main = new Auther();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassBox2.UseSystemPasswordChar = false;
            }
            else
            {
                PassBox2.UseSystemPasswordChar = true;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                PassBox3.UseSystemPasswordChar = false;
            }
            else
            {
                PassBox3.UseSystemPasswordChar = true;
            }
        }

       
    }
}
