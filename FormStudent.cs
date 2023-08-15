using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FinalPorject
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {

            InitializeComponent();
            InitializeTimer();

        }
        private Timer timerMessage;
        private bool updatingSpecSelection = false;
        private void cbStudSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!updatingSpecSelection)
            {
                // Обновляем выбор элементов в cbSpec на основе выбранного элемента в cbFaculty
                UpdateSpecSelection();
            }
        }

        private void cbStudFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudFaculty.SelectedIndex != -1)
            {
                cbStudSpec.Enabled = true;
                UpdateSpecSelection();
            }
            else
            {
                cbStudSpec.Enabled = false;
                cbStudSpec.SelectedIndex = -1;
            }
        }

        private void UpdateSpecSelection()
        {
            // Устанавливаем флаг обновления выбора в cbSpec
            updatingSpecSelection = true;


            // Определяем выбранный элемент в cbFaculty
            string selectedFaculty = cbStudFaculty.SelectedItem?.ToString();

            // Сохраняем предыдущее значение выбранной специальности
            string selectedSpec = cbStudSpec.SelectedItem?.ToString();

            // Обновляем выбор элементов в cbSpec на основе выбранного элемента в cbFaculty
            switch (selectedFaculty)
            {
                case "Факультет информационных технологий":
                    cbStudSpec.Items.Clear();
                    cbStudSpec.Items.Add("Разработка программного обеспечения");
                    cbStudSpec.Items.Add("Компьютерная безопасность");
                    cbStudSpec.Items.Add("Искусственный интеллект");
                    break;
                case "Факультет медицины и здравоохранения":
                    cbStudSpec.Items.Clear();
                    cbStudSpec.Items.Add("Общая медицина");
                    cbStudSpec.Items.Add("Стоматология");
                    cbStudSpec.Items.Add("Фармацевтика");
                    break;
                case "Факультет экономики и бизнеса":
                    cbStudSpec.Items.Clear();
                    cbStudSpec.Items.Add("Международный бизнес");
                    cbStudSpec.Items.Add("Финансы и инвестиции");
                    cbStudSpec.Items.Add("Маркетинг и реклама");
                    break;
                case "Факультет искусств и дизайна":
                    cbStudSpec.Items.Clear();
                    cbStudSpec.Items.Add("Иллюстрация и анимация");
                    cbStudSpec.Items.Add("Графический дизайн");
                    cbStudSpec.Items.Add("Театральное искусство");
                    break;
                default:
                    cbStudSpec.Items.Clear();
                    break;
            }

            // Восстанавливаем предыдущее значение выбранной специальности (если оно есть)
            if (!string.IsNullOrEmpty(selectedSpec) && cbStudSpec.Items.Contains(selectedSpec))
            {
                cbStudSpec.SelectedItem = selectedSpec;
            }
            else
            {
                cbStudSpec.SelectedIndex = 0; // Устанавливаем первый элемент по умолчанию
            }

            updatingSpecSelection = false;
        }


        private bool ValidateTextBox(TextBox textBox)
        {
            string text = textBox.Text;
            bool searching = string.IsNullOrEmpty(text) || text.Length < 3 || !text.All(char.IsLetter);
            if (searching)
            {
                ErrorReg.Text = "Ошибка";
                ErrorReg.ForeColor = Color.Red;
            }
            return searching;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(txtFirstName)) return;
            if (ValidateTextBox(txtLastName)) return;
            if (ValidateTextBox(txtStudBirthland)) return;
            if (ValidateTextBox(txtStudNation)) return;

            Student studentik = new Student(txtFirstName.Text, txtLastName.Text, txtStudBirthland.Text, txtStudNation.Text, int.Parse(cbStudAge.Text), cbStudGender.Text, cbStudFaculty.Text, cbStudLanguage.Text, cbStudSpec.Text, cbStudGroup.Text, int.Parse(cbGroupNumber.Text), txtStudNumber.Text, txtStudEmail.Text, txtStudPassword.Text);
            try
            {
                ErrorReg.Text = "Успешно добавлено";
                ErrorReg.ForeColor = Color.Green;
                timerMessage.Start();
                DBStudent.InsertStudentData(studentik);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while inserting student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void InitializeTimer()
        {
            timerMessage = new Timer();
            timerMessage.Interval = 3000; // 3 секунды
            timerMessage.Tick += TimerMessage_Tick;
        }

        private void TimerMessage_Tick(object sender, EventArgs e)
        {
            ErrorReg.Text = string.Empty;
            timerMessage.Stop();
        }

        private void btnProfileBack_Click(object sender, EventArgs e)
        {
            FormRoleChoice studAut = new FormRoleChoice();
            OpenNewForm(studAut);
        }

        private void OpenNewForm(Form newForm)
        {
            this.Hide(); // Скрываем текущую форму

            newForm.FormClosed += (s, args) => this.Close(); // При закрытии новой формы закрываем текущую форму

            newForm.Show();
        }
    }
}
