using QRCoder;
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

namespace CamelCase
{
    public partial class Form1 : Form
    {
        private string sentence;
        private SpeechSynthesizer synthesizer;

        interface form
        {
            //추상화로 구조 짤 것!
            string strCodeLink { get; set; }
            string strQRLink { get; set; }
            string sentence { get; set; }

            SpeechSynthesizer synthesizer { get; set; }

            void btnGenerate_Click(object sender, EventArgs e);
            void SpeechSynthesize(string sentence);
        }

        public Form1()
        {
            InitializeComponent();
            sentence = "다음으로  이동합니다.";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qGen = new QRCodeGenerator();
            QRCodeData qData = qGen.CreateQrCode(txtQRCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qCode = new QRCode(qData);
            pic.Image = qCode.GetGraphic(7);
            SpeechSynthesize(sentence);
        }

        private void SpeechSynthesize(string sentence)
        {
            synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.SelectVoice("Microsoft Heami Desktop");
            synthesizer.Speak(sentence);
        }
    }
}
