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
            //declaration variable
            Random al = new Random();
            decimal en = al.Next(100);
            decimal nb = nbr.Value;

            for(int i=1;i>=5;i++){
                while (en != nb){
                    label3.Text = "null";
                    label2.Text = "null";
                    nb = nbr.Value;
                }
                if (en == nb) {
                    label3.Text = en.ToString();
                    label2.Text = en.ToString();
            
                }
                else{
                    //for(int i=1;i>=5;i++){

                    //}
                    
                }
                
     
            }
            
            //afficher
            label2.Text = "vous aves fini";

        }
    }
}
