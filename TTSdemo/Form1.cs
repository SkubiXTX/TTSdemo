using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TTSdemo
{
    public partial class Form1 : Form
    {
       public int szybskosc = 0;
       public int glosnosc = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    cmbListaGlosow.Items.Add(voice.VoiceInfo.Name);
                }
            }

            cmbListaGlosow.SelectedIndex = 0;
        }

        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer syntezator = new SpeechSynthesizer();

            if (string.IsNullOrEmpty(txtTekst.Text))
            {
                MessageBox.Show("Wpisz Tekst");
                return;
            }


            syntezator.Volume = trbGlosnosc.Value;
            syntezator.Rate = trbSzybkosc.Value;
            syntezator.SelectVoice(cmbListaGlosow.Text);
            grpOpcje.Enabled = false;
            syntezator.SpeakAsync(txtTekst.Text);
            grpOpcje.Enabled = true;
        }

        private void trbSzybkosc_Scroll(object sender, EventArgs e)
        {
            lblSzybkoscWart.Text = trbSzybkosc.Value.ToString();
        }

        private void trbGlosnosc_Scroll(object sender, EventArgs e)
        {
            lblGlosnoscWart.Text = trbGlosnosc.Value.ToString();
        }
    }
}
