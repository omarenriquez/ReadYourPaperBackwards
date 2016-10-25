using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("You can write or paste the text you want reversed on the box, press Enter and the program will return the sentences backwards so it makes it easier for you to catch mistakes while editing your paper");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string usersText = txtEnterText.Text;

            //string reversed = String.Join(" ",
            //    usersText.Split(' ')
            //    .Select(word => new String(word.Reverse().ToArray())));
            string result = (string.Join(". ", usersText.Split('.').Reverse()));
            txtResult.Text = result.ToString();

                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
