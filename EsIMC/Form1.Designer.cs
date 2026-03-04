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
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.lstPersone = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.rdbVarianza = new System.Windows.Forms.RadioButton();
            this.rdbMediana = new System.Windows.Forms.RadioButton();
            this.rdbModa = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.rdbIMCsingolo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNominativo
            // 
            this.txtNominativo.Location = new System.Drawing.Point(24, 12);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(193, 22);
            this.txtNominativo.TabIndex = 0;
            this.txtNominativo.TextChanged += new System.EventHandler(this.txtNominativo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cognome Nome";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(363, 15);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(77, 22);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso (in kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altezza (in cm)";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(555, 15);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(77, 22);
            this.txtAltezza.TabIndex = 4;
            // 
            // lstPersone
            // 
            this.lstPersone.FormattingEnabled = true;
            this.lstPersone.ItemHeight = 16;
            this.lstPersone.Location = new System.Drawing.Point(12, 48);
            this.lstPersone.Name = "lstPersone";
            this.lstPersone.Size = new System.Drawing.Size(776, 324);
            this.lstPersone.TabIndex = 6;
            this.lstPersone.SelectedIndexChanged += new System.EventHandler(this.lstPersone_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAvvia);
            this.panel1.Controls.Add(this.btnSalva);
            this.panel1.Controls.Add(this.btnEsegui);
            this.panel1.Controls.Add(this.rdbVarianza);
            this.panel1.Controls.Add(this.rdbMediana);
            this.panel1.Controls.Add(this.rdbModa);
            this.panel1.Controls.Add(this.rdbMedia);
            this.panel1.Controls.Add(this.rdbIMCsingolo);
            this.panel1.Location = new System.Drawing.Point(12, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 63);
            this.panel1.TabIndex = 7;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(525, 32);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(75, 23);
            this.btnAvvia.TabIndex = 7;
            this.btnAvvia.Text = "AVVIA";
            this.btnAvvia.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(342, 32);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(139, 32);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(75, 23);
            this.btnEsegui.TabIndex = 5;
            this.btnEsegui.Text = "ESEGUI";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
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
            this.rdbIMCsingolo.CheckedChanged += new System.EventHandler(this.rdbIMCsingolo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstPersone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNominativo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.ListBox lstPersone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbIMCsingolo;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.RadioButton rdbVarianza;
        private System.Windows.Forms.RadioButton rdbMediana;
        private System.Windows.Forms.RadioButton rdbModa;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtNominativo;
    }
}

