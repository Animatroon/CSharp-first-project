using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FinalPorject
{
    internal class NavInApp
    {
        private void OpenNewForm(Form newForm)
        {
            Form m = new Form();
            m.Hide();
            newForm.FormClosed += (s, args) => m.Close();
            newForm.Show();
        }



        public void Navigate(Label Fullname)
        {
            string path = @"C:\Users\jaiky\Downloads\FinalPorject\FinalPorject\localStorage\SQLdata.txt";
            string[] studentData = File.ReadAllLines(path);
            Fullname.Text = studentData[0].Trim() + " " + studentData[1].Trim();
            
        }
    }
}
