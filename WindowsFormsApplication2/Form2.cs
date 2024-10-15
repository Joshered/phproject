using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random al = new Random();
            int en = al.Next(100);
            int entier = al.Next(0, 100);
            decimal nb = nbr.Value;
            Console.WriteLine(en);
            Console.ReadLine();
            label2.Text = en.ToString();

        }
    }
}
