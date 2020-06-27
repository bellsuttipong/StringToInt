using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringToInt
{
    public partial class Form1 : Form
    {
        private List<string> listInt = new List<string>();
        public Form1()
        {
            InitializeComponent();

            listInt.Add("1");
            listInt.Add("2");
            listInt.Add("3");
            listInt.Add("4");
            listInt.Add("5");
            listInt.Add("6");
            listInt.Add("7");
            listInt.Add("8");
            listInt.Add("9");
            listInt.Add("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = String.Empty;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {

                List<string> listString = textBox1.Text.Select(c => c.ToString()).ToList();
                listString = listString.Where(x => listInt.Any(z => x == z)).ToList();
                string toInt = string.Join("", listString.ToList());
                label3.Text = toInt;
            }  
        }
    }
}
