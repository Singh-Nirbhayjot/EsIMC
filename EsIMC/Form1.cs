using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsIMC
{
    public partial class Form1 : Form
    {
        string nome , lista ;
        double peso;
        int altezza;
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbIMCsingolo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {

        }

        private void txtNominativo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstPersone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            nome = txtNominativo.Text;
            peso = double.Parse(txtPeso.Text);


            lista += nome + "-" + peso + "-" + ;


        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
