using System.Collections;

namespace RomanoParaArabico
{
    public partial class ConversorRomanoArabico : Form
    {
        private Arabico numeroArabico = new Arabico();
        private Romano numeroRomano = new Romano();

        public ConversorRomanoArabico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroArabico = new Arabico();
            string numeroRomano = textBox1.Text.ToString();
            int arabico = numeroArabico.ConversaoSimples(numeroRomano);
            label2.Text = "" + arabico;
        }

        private void button2_Click(object sender, EventArgs e)

        {
            numeroRomano = new Romano();
            int arab = int.Parse(textBox2.Text.ToString());
            string romano = numeroRomano.ConverteArabicoParaRomano(arab);
            label8.Text = romano;

        }     

    }
    }

    

           
        
    

 
