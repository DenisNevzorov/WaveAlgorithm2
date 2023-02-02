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
    public partial class Auther : Form
    {
        public Auther()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            textboxLogin.Text = textboxLogin.Text.Trim();
            textboxPassword.Text = textboxPassword.Text.Trim();
            try
            {
                User user = new User(textboxLogin.Text, textboxPassword.Text);
                if (user.CorrectUser() && user.UserValid())
                {
                    this.Hide();
                    MainApp main = new MainApp();
                    main.FormClosed += (s, args) => this.Close();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.FormClosed += (s, args) => this.Close();
            this.Hide();
            reg.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textboxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void Auther_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
    }
}
