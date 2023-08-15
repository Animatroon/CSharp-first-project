using System.Windows.Forms;
using System;
using System.IO;

namespace FinalPorject
{
    public partial class FormProfile : Form
    {

        public FormProfile()
        {
            InitializeComponent();

        }

        private void OpenNewForm(Form newForm)
        {
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            OpenNewForm(formMain);
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            NavInApp nip = new NavInApp();
            nip.Navigate(NavFirstName);

            string path = @"C:\Users\jaiky\Downloads\FinalPorject\FinalPorject\localStorage\SQLdata.txt";
            string[] studentData = File.ReadAllLines(path);
            ProfileFisrtName.Text = studentData[0].Trim();
            ProfileLastName.Text = studentData[1].Trim();
            ProfileBirthland.Text = studentData[2].Trim();
            ProfileAge.Text = studentData[3].Trim();
            ProfileNation.Text = studentData[4].Trim();
            ProfileGender.Text = studentData[5].Trim();
            ProfileFaculty.Text = studentData[6].Trim();
            ProfileLanguage.Text = studentData[7].Trim();
            ProfileSpec.Text = studentData[8].Trim();
            ProfileGroup.Text = studentData[9].Trim();
            ProfileGroupNumber.Text = studentData[10].Trim();
            ProfileEmail.Text = studentData[11].Trim();
            ProfilePassword.Text = studentData[12].Trim();
            ProfileRating.Text = studentData[13].Trim();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }


        
    }
}
