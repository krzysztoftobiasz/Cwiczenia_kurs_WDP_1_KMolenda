using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficznaAppHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //tu kod obsługi przycisku buttokOk
            labelKomunikat1.Text = "Witaj " + textBoxImie.Text + " " + textBoxNazwisko.Text;

            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if(wiek < 67)
            {
                labelKomunikat2.Text = string.Format(" Do emerytury zostało Ci {0} lat", 67 - wiek);

            }
            else
            {
                labelKomunikat2.Text = "Jesteś emerytem";
            }
        }
    }
}
                // DZIAŁA!!!!!!!!!!!!!!!!!!!!
