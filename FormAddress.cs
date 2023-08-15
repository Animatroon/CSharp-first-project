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
    public partial class FormAddress : Form
    {
        private int studentID;

        public FormAddress()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
