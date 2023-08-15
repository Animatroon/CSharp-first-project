using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalPorject
{
    public partial class FormRoleChoice : Form
    {
        public FormRoleChoice()
        {
            InitializeComponent();
        }
        
        // рагистрация или авторизация студента
        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form formStudent = new FormStudent();
            Form studentAuto = new AutorizationStudent();
            // проверяем radiobuttons на активность и сделаем от этого открытие формы
            if (rdRegistration.Checked)
            {
                
                OpenNewForm(formStudent);
            }
            else if (rdAutorization.Checked)
            {
                OpenNewForm(studentAuto);
            }
            else
            {
                MessageBox.Show("Выберите опцию сверху", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // рагистрация или авторизация преподавателя
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Form formTeacher = new FormTeacher();
            Form teacherAuto = new AutorizationTeacher();
            if (rdRegistration.Checked)
            {

                OpenNewForm(formTeacher);
            }
            else if (rdAutorization.Checked)
            {
                OpenNewForm(teacherAuto);
            }
            else
            {
                MessageBox.Show("Выберите опцию сверху", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Открытие новой формы и закрытие сторой
        private void OpenNewForm(Form newForm)
        {
            this.Hide(); 

            newForm.FormClosed += (s, args) => this.Close(); 

            newForm.Show();
        }
    }
}
