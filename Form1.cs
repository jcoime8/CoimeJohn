using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Definitivo;

namespace WIN_Definitivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CLSlogin login = new CLSlogin();

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.calcular(textBox1.Text, textBox2.Text) == true)
            {
                DialogResult r = MessageBox.Show("Quieres continuar?","inicio de seccion", MessageBoxButtons.YesNo);
                if(r == DialogResult.Yes)
                {
                    MDIParent1 principal = new MDIParent1();
                    principal.Show();
                }
                else if(r == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Inicio incorrecto", "Inicio de seccion");
            }

        }
    }
}
