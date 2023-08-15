using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPorject
{
    public partial class AutorizationTeacher : Form
    {
        public AutorizationTeacher()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtTeachEmail.Text;
            string password = txtTeachPassword.Text;
            FormMain formMain = new FormMain();

            bool isValid = DBStudent.AutorizationStudentValid(email, password);

            if (isValid)
            {
                MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenNewForm(formMain);
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenNewForm(Form newForm)
        {
            this.Hide(); // Скрываем текущую форму

            newForm.FormClosed += (s, args) => this.Close(); // При закрытии новой формы закрываем текущую форму

            newForm.Show();
        }
    }
}
