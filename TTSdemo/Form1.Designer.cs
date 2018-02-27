namespace TTSdemo
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdczyt = new System.Windows.Forms.Button();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.cmbListaGlosow = new System.Windows.Forms.ComboBox();
            this.grpOpcje = new System.Windows.Forms.GroupBox();
            this.lblGlosnoscWart = new System.Windows.Forms.Label();
            this.lblSzybkoscWart = new System.Windows.Forms.Label();
            this.lblGlosnosc = new System.Windows.Forms.Label();
            this.lblSzybkosc = new System.Windows.Forms.Label();
            this.trbGlosnosc = new System.Windows.Forms.TrackBar();
            this.trbSzybkosc = new System.Windows.Forms.TrackBar();
            this.lblGłos = new System.Windows.Forms.Label();
            this.grpOpcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbGlosnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSzybkosc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdczyt
            // 
            this.btnOdczyt.Location = new System.Drawing.Point(87, 104);
            this.btnOdczyt.Name = "btnOdczyt";
            this.btnOdczyt.Size = new System.Drawing.Size(100, 35);
            this.btnOdczyt.TabIndex = 0;
            this.btnOdczyt.Text = "Odczytaj";
            this.btnOdczyt.UseVisualStyleBackColor = true;
            this.btnOdczyt.Click += new System.EventHandler(this.btnOdczyt_Click);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(12, 12);
            this.txtTekst.Multiline = true;
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(260, 81);
            this.txtTekst.TabIndex = 1;
            // 
            // cmbListaGlosow
            // 
            this.cmbListaGlosow.FormattingEnabled = true;
            this.cmbListaGlosow.Location = new System.Drawing.Point(6, 177);
            this.cmbListaGlosow.Name = "cmbListaGlosow";
            this.cmbListaGlosow.Size = new System.Drawing.Size(248, 21);
            this.cmbListaGlosow.TabIndex = 2;
            // 
            // grpOpcje
            // 
            this.grpOpcje.Controls.Add(this.lblGlosnoscWart);
            this.grpOpcje.Controls.Add(this.lblSzybkoscWart);
            this.grpOpcje.Controls.Add(this.lblGlosnosc);
            this.grpOpcje.Controls.Add(this.lblSzybkosc);
            this.grpOpcje.Controls.Add(this.trbGlosnosc);
            this.grpOpcje.Controls.Add(this.trbSzybkosc);
            this.grpOpcje.Controls.Add(this.lblGłos);
            this.grpOpcje.Controls.Add(this.cmbListaGlosow);
            this.grpOpcje.Location = new System.Drawing.Point(12, 145);
            this.grpOpcje.Name = "grpOpcje";
            this.grpOpcje.Size = new System.Drawing.Size(260, 204);
            this.grpOpcje.TabIndex = 3;
            this.grpOpcje.TabStop = false;
            this.grpOpcje.Text = "Opcje";
            // 
            // lblGlosnoscWart
            // 
            this.lblGlosnoscWart.AutoSize = true;
            this.lblGlosnoscWart.Location = new System.Drawing.Point(221, 80);
            this.lblGlosnoscWart.Name = "lblGlosnoscWart";
            this.lblGlosnoscWart.Size = new System.Drawing.Size(19, 13);
            this.lblGlosnoscWart.TabIndex = 9;
            this.lblGlosnoscWart.Text = "50";
            // 
            // lblSzybkoscWart
            // 
            this.lblSzybkoscWart.AutoSize = true;
            this.lblSzybkoscWart.Location = new System.Drawing.Point(218, 20);
            this.lblSzybkoscWart.Name = "lblSzybkoscWart";
            this.lblSzybkoscWart.Size = new System.Drawing.Size(13, 13);
            this.lblSzybkoscWart.TabIndex = 8;
            this.lblSzybkoscWart.Text = "0";
            // 
            // lblGlosnosc
            // 
            this.lblGlosnosc.AutoSize = true;
            this.lblGlosnosc.Location = new System.Drawing.Point(7, 80);
            this.lblGlosnosc.Name = "lblGlosnosc";
            this.lblGlosnosc.Size = new System.Drawing.Size(53, 13);
            this.lblGlosnosc.TabIndex = 7;
            this.lblGlosnosc.Text = "Głośność";
            // 
            // lblSzybkosc
            // 
            this.lblSzybkosc.AutoSize = true;
            this.lblSzybkosc.Location = new System.Drawing.Point(7, 19);
            this.lblSzybkosc.Name = "lblSzybkosc";
            this.lblSzybkosc.Size = new System.Drawing.Size(53, 13);
            this.lblSzybkosc.TabIndex = 6;
            this.lblSzybkosc.Text = "Szybkość";
            // 
            // trbGlosnosc
            // 
            this.trbGlosnosc.Location = new System.Drawing.Point(6, 99);
            this.trbGlosnosc.Maximum = 100;
            this.trbGlosnosc.Name = "trbGlosnosc";
            this.trbGlosnosc.Size = new System.Drawing.Size(248, 45);
            this.trbGlosnosc.TabIndex = 5;
            this.trbGlosnosc.Value = 50;
            this.trbGlosnosc.Scroll += new System.EventHandler(this.trbGlosnosc_Scroll);
            // 
            // trbSzybkosc
            // 
            this.trbSzybkosc.Location = new System.Drawing.Point(6, 38);
            this.trbSzybkosc.Minimum = -10;
            this.trbSzybkosc.Name = "trbSzybkosc";
            this.trbSzybkosc.Size = new System.Drawing.Size(248, 45);
            this.trbSzybkosc.TabIndex = 4;
            this.trbSzybkosc.Scroll += new System.EventHandler(this.trbSzybkosc_Scroll);
            // 
            // lblGłos
            // 
            this.lblGłos.AutoSize = true;
            this.lblGłos.Location = new System.Drawing.Point(7, 158);
            this.lblGłos.Name = "lblGłos";
            this.lblGłos.Size = new System.Drawing.Size(30, 13);
            this.lblGłos.TabIndex = 3;
            this.lblGłos.Text = "Głos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.grpOpcje);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.btnOdczyt);
            this.Name = "Form1";
            this.Text = "Odczytaj Tekst";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOpcje.ResumeLayout(false);
            this.grpOpcje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbGlosnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSzybkosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdczyt;
        private System.Windows.Forms.TextBox txtTekst;
        private System.Windows.Forms.ComboBox cmbListaGlosow;
        private System.Windows.Forms.GroupBox grpOpcje;
        private System.Windows.Forms.Label lblGlosnosc;
        private System.Windows.Forms.Label lblSzybkosc;
        private System.Windows.Forms.TrackBar trbGlosnosc;
        private System.Windows.Forms.TrackBar trbSzybkosc;
        private System.Windows.Forms.Label lblGłos;
        private System.Windows.Forms.Label lblGlosnoscWart;
        private System.Windows.Forms.Label lblSzybkoscWart;
    }
}

