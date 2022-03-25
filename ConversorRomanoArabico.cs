using System.Collections;

namespace RomanoParaArabico
{
    public partial class ConversorRomanoArabico : Form
    {
        private Class1 _conversor = new Class1();

        public ConversorRomanoArabico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = _conversor.RomanoParaArabico(textBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                label2.Text = "Exceção: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            label8.ResetText();
            int numero = Convert.ToInt32(textBox2.Text);

            if (numero.ToString().Trim().Length == 0)
                return;

            if (numero >= 4000) {
                MessageBox.Show("Por favor entre um número menor do que 4000.",
                    this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                textBox2.Focus();
                return;
            }

            String[] romano = new String[] {"M", "CM", "D", "CD", "C", "XC", "L",
            "XL", "X", "IX", "V", "IV", "I"};
            int[] decimais = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string valorRomano = String.Empty;

            for( int i = 0; i < 13; i++)
            {
                while(numero >= decimais[i]){
                    numero -= decimais[i];
                    valorRomano += romano[i];
                }
            }

            label8.Text = valorRomano;
        }     

    }
    }

    

           
        
    

 
