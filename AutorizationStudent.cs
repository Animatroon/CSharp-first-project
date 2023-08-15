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
    public partial class AutorizationStudent : Form
    {
        public AutorizationStudent()
        {
            InitializeComponent();
        }



        private void OpenNewForm(Form newForm)
        {
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close(); 
            newForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBStudent student = new DBStudent();
            string email = txtLoginEmail.Text;
            string password = txtLoginPassword.Text;
            FormMain formMain = new FormMain();
            bool isValid = DBStudent.AutorizationStudentValid(email, password);

            if (isValid)
            {
                MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                student.PostDataStudent(email);
                OpenNewForm(formMain);
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
