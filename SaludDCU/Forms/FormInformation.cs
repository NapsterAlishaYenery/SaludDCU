using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SaludDCU.Forms
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/alexander.nunezcabrera/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/luciagabriela.figuereo.3");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es una aplicacion que soporta las informaciones de una clinica\n" +
                "esta clinica la cual nombramos AliYen Care Hospital es una clinica\n" +
                "\n" +
                "Esta Aplicacion consta de barios formularios donde los medico podran\n" +
                "manejar las ingomaciones de los pacientes de manera mas eficiente que \n" +
                "en muchas forma lo hacen utilizando los programas convencionales\n" +
                "\n" +
                "\n" +
                "Para mayor informacion ponerce enconctactos con los desarrolladores.");
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }
            lbHelp.BackColor = ThemeColor.PrimaryColor;
        }
    }
}
