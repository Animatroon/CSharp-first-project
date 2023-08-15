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

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private FormProfile formProfile = new FormProfile();

        private void OpenNewForm(Form newForm)
        {
            this.Hide();

            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        

        private void linkNews_Click(object sender, EventArgs e)
        {
            FormNews formNews = new FormNews();
            OpenNewForm(formNews);
        }

        private void MainProfile_Click(object sender, EventArgs e)
        {
            OpenNewForm(formProfile);
        }

        private void MainProfileFirstName_Click(object sender, EventArgs e)
        {
            OpenNewForm(formProfile);
        }

        private void MainProfileLastName_Click(object sender, EventArgs e)
        {
            OpenNewForm(formProfile);
        }

        private void profileIcon_Click(object sender, EventArgs e)
        {
            OpenNewForm(formProfile);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            NavInApp nip = new NavInApp();
            nip.Navigate(NavFirstName);
        }



        private void ProfilePanel_Click(object sender, EventArgs e)
        {
            OpenNewForm(formProfile);
        }
    }

}
