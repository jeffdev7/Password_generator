using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_generator
{
    public partial class Form1 : Form
    {
        int password = 10; //it's nice if it's the same value of the numericdrop on the form
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvxwyz";

            if (check_Capital.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUVXWYZ"; //+= means that what it's on the right of "=" it'll be included in "chars" 

            if (check_numbers.Checked)
                chars += "0123456789";

            if (check_symbols.Checked)
                chars += "!@#$%*";

            list_password.Items.Clear();
            Random rm = new Random();

            for(int i = 1; i <= password; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int n = 1; n <= count_pass.Value;n++)
                {
                    int position = rm.Next(0, chars.Length);
                    sb.Append(chars[position].ToString());
                }
                list_password.Items.Add(sb.ToString());
            }


        }
    }
}
