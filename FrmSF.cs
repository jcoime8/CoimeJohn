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
    public partial class FrmSF : Form
    {
        public FrmSF()
        {
            InitializeComponent();
        }
        CLS_SrFigonasi sf = new CLS_SrFigonasi();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Join(" - ", sf.calcularSerie(Convert.ToInt32(textBox1.Text)));
            
        }
    }
}
