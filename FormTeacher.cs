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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private Timer timerMessage;
        private bool updatingSpecSelection = false;

        private void cbTeachSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!updatingSpecSelection)
            {
                UpdateSpecSelection();
            }
        }

        private void cbTeachFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTeachFaculty.SelectedIndex != -1)
            {
                cbTeachSpec.Enabled = true;
                UpdateSpecSelection();
            }
            else
            {
                cbTeachSpec.Enabled = false;
                cbTeachSpec.SelectedIndex = -1;
            }
        }

        private void UpdateSpecSelection()
        {
            updatingSpecSelection = true;

            string selectedFaculty = cbTeachFaculty.SelectedItem?.ToString();

            string selectedSpec = cbTeachSpec.SelectedItem?.ToString();

            switch (selectedFaculty)
            {
                case "Факультет информационных технологий":
                    cbTeachSpec.Items.Clear();
                    cbTeachSpec.Items.Add("Разработка программного обеспечения");
                    cbTeachSpec.Items.Add("Компьютерная безопасность");
                    cbTeachSpec.Items.Add("Искусственный интеллект");
                    break;
                case "Факультет медицины и здравоохранения":
                    cbTeachSpec.Items.Clear();
                    cbTeachSpec.Items.Add("Общая медицина");
                    cbTeachSpec.Items.Add("Стоматология");
                    cbTeachSpec.Items.Add("Фармацевтика");
                    break;
                case "Факультет экономики и бизнеса":
                    cbTeachSpec.Items.Clear();
                    cbTeachSpec.Items.Add("Международный бизнес");
                    cbTeachSpec.Items.Add("Финансы и инвестиции");
                    cbTeachSpec.Items.Add("Маркетинг и реклама");
                    break;
                case "Факультет искусств и дизайна":
                    cbTeachSpec.Items.Clear();
                    cbTeachSpec.Items.Add("Иллюстрация и анимация");
                    cbTeachSpec.Items.Add("Графический дизайн");
                    cbTeachSpec.Items.Add("Театральное искусство");
                    break;
                default:
                    cbTeachSpec.Items.Clear();
                    break;
            }

            if (!string.IsNullOrEmpty(selectedSpec) && cbTeachSpec.Items.Contains(selectedSpec))
            {
                cbTeachSpec.SelectedItem = selectedSpec;
            }
            else
            {
                cbTeachSpec.SelectedIndex = 0;
            }

            updatingSpecSelection = false;
        }

        private bool ValidateTextBox(TextBox textBox)
        {
            string text = textBox.Text;
            bool searching = string.IsNullOrEmpty(text) || text.Length < 3 || !text.All(char.IsLetter);
            if (searching)
            {
                ErrorEvent.Text = "Ошибка";
                ErrorEvent.ForeColor = Color.Red;
            }
            return searching;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(txtTeachFirstName)) return;
            if (ValidateTextBox(txtTeachLastName)) return;
            if (ValidateTextBox(txtTeachBirthland)) return;
            if (ValidateTextBox(txtTeachNation)) return;

            Teacher teacher = new Teacher(txtTeachFirstName.Text, txtTeachLastName.Text, txtTeachBirthland.Text, txtTeachNation.Text, int.Parse(cbTeachAge.Text), cbTeachGender.Text, cbTeachFaculty.Text, cbTeachLanguage.Text, cbTeachSpec.Text, cbTeachGroup.Text, int.Parse(cbTeachGroupNumber.Text), txtTeachNumber.Text, txtTeachEmail.Text, txtTeachPassword.Text, txtTeachEducation.Text, int.Parse(cbTeachExp.Text));
            try
            {
                ErrorEvent.Text = "Успешно добавлено";
                ErrorEvent.ForeColor = Color.Green;
                timerMessage.Start();
                DBTeacher.InsertTeacherData(teacher);
                MessageBox.Show("Данные успешно добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while inserting teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ErrorEvent.Text = string.Empty;
            timerMessage.Stop();
        }
    }
}
