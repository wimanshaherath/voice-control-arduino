using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace voiceArduino
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "on port", "zero port", "one", "zero" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammer = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammer);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
 
        }

         void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "on port":
                    serialPort1.Open();
                    txtStatus.Text = "\nPort is opened.";
                    break;

                case "zero port":
                    serialPort1.Close();
                    txtStatus.Text = "\nPort is closed.";
                    break;

                case "one":
                    serialPort1.Write("1");
                    txtStatus.Text = "\nLED ON";
                    break;

                case "off":
                    serialPort1.Write("0");
                    txtStatus.Text = "\nLED OFF";
                    break;

                
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
        }
    }
}
