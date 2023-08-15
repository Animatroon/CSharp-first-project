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
    
    public partial class FormNews : Form
    {
        private int studentID;
        public FormNews()
        {
            InitializeComponent();

        }

        private void OpenNewForm(Form newForm)
        {
            this.Hide();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void btnProfileBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            OpenNewForm(formMain);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            OpenNewForm(formMain);
        }

        private void FormNews_Load(object sender, EventArgs e)
        {
            NavInApp nip = new NavInApp();
            nip.Navigate(NavFirstName);
        }
    }
}
