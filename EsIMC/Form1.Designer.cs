namespace EsIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstPersone = new System.Windows.Forms.ListBox();
            this.pnlImmagine = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.rdbVarianza = new System.Windows.Forms.RadioButton();
            this.rdbMediana = new System.Windows.Forms.RadioButton();
            this.rdbModa = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.rdbIMCsingolo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstPersone);
            this.panel2.Controls.Add(this.pnlImmagine);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAltezza);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPeso);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNominativo);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 445);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lstPersone
            // 
            this.lstPersone.FormattingEnabled = true;
            this.lstPersone.ItemHeight = 16;
            this.lstPersone.Location = new System.Drawing.Point(8, 39);
            this.lstPersone.Name = "lstPersone";
            this.lstPersone.Size = new System.Drawing.Size(776, 324);
            this.lstPersone.TabIndex = 15;
            this.lstPersone.SelectedIndexChanged += new System.EventHandler(this.lstPersone_SelectedIndexChanged_1);
            // 
            // pnlImmagine
            // 
            this.pnlImmagine.Location = new System.Drawing.Point(319, 3);
            this.pnlImmagine.Name = "pnlImmagine";
            this.pnlImmagine.Size = new System.Drawing.Size(97, 33);
            this.pnlImmagine.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalva);
            this.panel1.Controls.Add(this.btnEsegui);
            this.panel1.Controls.Add(this.rdbVarianza);
            this.panel1.Controls.Add(this.rdbMediana);
            this.panel1.Controls.Add(this.rdbModa);
            this.panel1.Controls.Add(this.rdbMedia);
            this.panel1.Controls.Add(this.rdbIMCsingolo);
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 63);
            this.panel1.TabIndex = 16;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(574, 32);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);  // AGGIUNGI QUESTA
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(139, 32);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(75, 23);
            this.btnEsegui.TabIndex = 5;
            this.btnEsegui.Text = "ESEGUI";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);  // AGGIUNGI QUESTA
            // 
            // rdbVarianza
            // 
            this.rdbVarianza.AutoSize = true;
            this.rdbVarianza.Location = new System.Drawing.Point(639, 6);
            this.rdbVarianza.Name = "rdbVarianza";
            this.rdbVarianza.Size = new System.Drawing.Size(121, 20);
            this.rdbVarianza.TabIndex = 4;
            this.rdbVarianza.TabStop = true;
            this.rdbVarianza.Text = "VARIANZA IMC";
            this.rdbVarianza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbVarianza.UseVisualStyleBackColor = true;
            // 
            // rdbMediana
            // 
            this.rdbMediana.AutoSize = true;
            this.rdbMediana.Location = new System.Drawing.Point(505, 6);
            this.rdbMediana.Name = "rdbMediana";
            this.rdbMediana.Size = new System.Drawing.Size(115, 20);
            this.rdbMediana.TabIndex = 3;
            this.rdbMediana.TabStop = true;
            this.rdbMediana.Text = "MEDIANA IMC";
            this.rdbMediana.UseVisualStyleBackColor = true;
            // 
            // rdbModa
            // 
            this.rdbModa.AutoSize = true;
            this.rdbModa.Location = new System.Drawing.Point(351, 6);
            this.rdbModa.Name = "rdbModa";
            this.rdbModa.Size = new System.Drawing.Size(94, 20);
            this.rdbModa.TabIndex = 2;
            this.rdbModa.TabStop = true;
            this.rdbModa.Text = "MODA IMC";
            this.rdbModa.UseVisualStyleBackColor = true;
            // 
            // rdbMedia
            // 
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.Location = new System.Drawing.Point(221, 6);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Size = new System.Drawing.Size(96, 20);
            this.rdbMedia.TabIndex = 1;
            this.rdbMedia.TabStop = true;
            this.rdbMedia.Text = "MEDIA IMC";
            this.rdbMedia.UseVisualStyleBackColor = true;
            // 
            // rdbIMCsingolo
            // 
            this.rdbIMCsingolo.AutoSize = true;
            this.rdbIMCsingolo.Location = new System.Drawing.Point(12, 6);
            this.rdbIMCsingolo.Name = "rdbIMCsingolo";
            this.rdbIMCsingolo.Size = new System.Drawing.Size(177, 20);
            this.rdbIMCsingolo.TabIndex = 0;
            this.rdbIMCsingolo.TabStop = true;
            this.rdbIMCsingolo.Text = "CALCOLO IMC SINGOLO";
            this.rdbIMCsingolo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Altezza (in cm)";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(609, 8);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(77, 22);
            this.txtAltezza.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Peso (in kg)";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(430, 9);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(77, 22);
            this.txtPeso.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cognome Nome";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Location = new System.Drawing.Point(8, 11);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(193, 22);
            this.txtNominativo.TabIndex = 9;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(350, 410);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(100, 30);
            this.btnAvvia.TabIndex = 7;
            this.btnAvvia.Text = "AVVIA";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstPersone;
        private System.Windows.Forms.Panel pnlImmagine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.RadioButton rdbVarianza;
        private System.Windows.Forms.RadioButton rdbMediana;
        private System.Windows.Forms.RadioButton rdbModa;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.RadioButton rdbIMCsingolo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNominativo;
    }
}

