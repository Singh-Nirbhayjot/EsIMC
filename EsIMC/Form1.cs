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
        string nome;
        double peso;
        int altezza;

        List<double> valoriIMC = new List<double>();
        List<string> nomiPersone = new List<string>();
        

        public Form1()
        {
            InitializeComponent();


            pnlImmagine.BackgroundImage = Image.FromFile("IMC.png");
            pnlImmagine.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            if (!rdbIMCsingolo.Checked && !rdbMedia.Checked && !rdbModa.Checked &&
                !rdbMediana.Checked && !rdbVarianza.Checked)
            {
                MessageBox.Show("Seleziona un'operazione da eseguire");
                return;
            }

            if (rdbIMCsingolo.Checked)
            {
                if (txtNominativo.Text == "" || txtPeso.Text == "" || txtAltezza.Text == "")
                {
                    MessageBox.Show("Compila tutti i campi per calcolare l'IMC");
                    return;
                }

                nome = txtNominativo.Text;

                if (!double.TryParse(txtPeso.Text, out peso))
                {
                    MessageBox.Show("Inserisci un peso valido");
                    return;
                }

                if (!int.TryParse(txtAltezza.Text, out altezza))
                {
                    MessageBox.Show("Inserisci un'altezza valida");
                    return;
                }

                // Calcola l'IMC (Peso / Altezza²) in metri
                double altezzaInMetri = altezza / 100.0;
                double imc = peso / (altezzaInMetri * altezzaInMetri);

                valoriIMC.Add(imc);
                nomiPersone.Add(nome);

                lstPersone.Items.Add(nome + " - " + peso + "kg - " + altezza + "cm : IMC = " + Math.Round(imc, 2));

                string categoria = OttieniCategoriaIMC(imc);
                MessageBox.Show(nome + ", il tuo IMC è: " + Math.Round(imc, 2) + "\nCategoria: " + categoria);

                PulisciCampi();
            }

            else
            {
                if (valoriIMC.Count == 0)
                {
                    MessageBox.Show("Nessun dato disponibile.\nInserisci prima almeno una persona con IMC singolo.");
                    return;
                }

                if (rdbMedia.Checked)
                {
                    double media = CalcolaMedia();
                    MessageBox.Show("La Media di tutti gli IMC (" + valoriIMC.Count + " persone) è: " + Math.Round(media, 2));
                }
                else if (rdbModa.Checked)
                {
                    CalcolaModa();
                }
                else if (rdbMediana.Checked)
                {
                    double mediana = CalcolaMediana();
                    MessageBox.Show("La Mediana è: " + Math.Round(mediana, 2));
                }
                else if (rdbVarianza.Checked)
                {
                    double varianza = CalcolaVarianza();
                    MessageBox.Show("La Varianza è: " + Math.Round(varianza, 2));
                }
            }

            ResetRadioButtons();
        }

        private double CalcolaMedia()
        {
            double somma = 0;
            for (int i = 0; i < valoriIMC.Count; i++)
            {
                somma += valoriIMC[i];
            }
            return somma / valoriIMC.Count;
        }

        private void CalcolaModa()
        {
            double moda = -1;
            int maxContatore = 0;

            for (int i = 0; i < valoriIMC.Count; i++)
            {
                int contatore = 0;
                for (int j = 0; j < valoriIMC.Count; j++)
                {
                    if (Math.Round(valoriIMC[i], 1) == Math.Round(valoriIMC[j], 1))
                        contatore++;
                }
                if (contatore > maxContatore)
                {
                    maxContatore = contatore;
                    moda = valoriIMC[i];
                }
            }

            if (maxContatore > 1)
                MessageBox.Show("La Moda (valore più frequente) è: " + Math.Round(moda, 2));
            else
                MessageBox.Show("Nessun valore si ripete. Non c'è una moda.");
        }

        private double CalcolaMediana()
        {
            List<double> copia = new List<double>();
            for (int i = 0; i < valoriIMC.Count; i++)
            {
                copia.Add(valoriIMC[i]);
            }

            for (int i = 0; i < copia.Count - 1; i++)
            {
                for (int j = 0; j < copia.Count - 1 - i; j++)
                {
                    if (copia[j] > copia[j + 1])
                    {
                        double temp = copia[j];
                        copia[j] = copia[j + 1];
                        copia[j + 1] = temp;
                    }
                }
            }

            double mediana;
            if (copia.Count % 2 == 0)
            {
                int centro1 = copia.Count / 2 - 1;
                int centro2 = copia.Count / 2;
                mediana = (copia[centro1] + copia[centro2]) / 2.0;
            }
            else
            {
                int centro = copia.Count / 2;
                mediana = copia[centro];
            }

            return mediana;
        }

        private double CalcolaVarianza()
        {
            double media = CalcolaMedia();

            double sommaDifferenzeQuadrate = 0;
            for (int i = 0; i < valoriIMC.Count; i++)
            {
                double diff = valoriIMC[i] - media;
                sommaDifferenzeQuadrate += diff * diff;
            }

            return sommaDifferenzeQuadrate / valoriIMC.Count;
        }

        private string OttieniCategoriaIMC(double imc)
        {
            if (imc < 18.5)
                return "Sottopeso";
            else if (imc < 25)
                return "Normopeso";
            else if (imc < 30)
                return "Sovrappeso";
            else
                return "Obesità";
        }

        private void PulisciCampi()
        {
            txtNominativo.Text = "";
            txtPeso.Text = "";
            txtAltezza.Text = "";
            txtNominativo.Focus();
        }

        private void ResetRadioButtons()
        {
            rdbIMCsingolo.Checked = false;
            rdbMedia.Checked = false;
            rdbModa.Checked = false;
            rdbMediana.Checked = false;
            rdbVarianza.Checked = false;
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            valoriIMC.Clear();
            nomiPersone.Clear();
            lstPersone.Items.Clear();
            PulisciCampi();
            ResetRadioButtons();
            MessageBox.Show("Applicazione avviata.\nInserisci i dati e seleziona 'IMC Singolo' per aggiungere persone.");
        }

        private void btnSalva_Click(object sender, EventArgs e) { }
        private void rdbIMCsingolo_CheckedChanged(object sender, EventArgs e) { }
        private void rdbMedia_CheckedChanged(object sender, EventArgs e) { }
        private void rdbModa_CheckedChanged(object sender, EventArgs e) { }
        private void rdbMediana_CheckedChanged(object sender, EventArgs e) { }
        private void rdbVarianza_CheckedChanged(object sender, EventArgs e) { }
        private void txtNominativo_TextChanged(object sender, EventArgs e) { }
        private void txtPeso_TextChanged(object sender, EventArgs e) { }
        private void txtAltezza_TextChanged(object sender, EventArgs e) { }
        private void lstPersone_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pnlImmagine_Paint(object sender, PaintEventArgs e) 
        {
        }
    }
}