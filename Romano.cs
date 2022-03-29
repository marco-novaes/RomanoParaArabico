using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoParaArabico
{
    public class Romano
    {
        public string ConverteArabicoParaRomano(int numero)
        {
            string rom = "";
            while (true)
            {
                if (numero < 4000 && numero > 999)
                {
                    // para caso de mil em mil
                    switch (numero / 1000)
                    {
                        case 1:
                            rom += "M";
                            break;
                        case 2:
                            rom += "MM";
                            break;
                        case 3:
                            rom += "MMM";
                            break;
                    }
                    numero -= 1000 * (numero / 1000);

                }
                else if (numero < 1000 && numero > 99)
                {
                    switch (numero / 100)
                    {
                        case 1: rom += "C"; break;
                        case 2: rom += "CC"; break;
                        case 3: rom += "CCC"; break;
                        case 4: rom += "CD"; break;
                        case 5: rom += "D"; break;
                        case 6: rom += "DC"; break;
                        case 7: rom += "DCC"; break;
                        case 8: rom += "DCCC"; break;
                        case 9: rom += "CM"; break;
                    }
                    numero -= 100 * (numero / 100);

                }
                else if (numero < 100 && numero > 10)
                {
                    switch (numero / 10)
                    {
                        case 1: rom += "X"; break;
                        case 2: rom += "XX"; break;
                        case 3: rom += "XXX"; break;
                        case 4: rom += "XL"; break;
                        case 5: rom += "L"; break;
                        case 6: rom += "LX"; break;
                        case 7: rom += "LXX"; break;
                        case 8: rom += "LXXX"; break;
                        case 9: rom += "XC"; break;
                    }
                    numero -= 10 * (numero / 10);
                }

                else if (numero < 9 && numero > 0)
                {
                    switch (numero)
                    {
                        case 1: rom += "I"; break;
                        case 2: rom += "II"; break;
                        case 3: rom += "III"; break;
                        case 4: rom += "IV"; break;
                        case 5: rom += "V"; break;
                        case 6: rom += "VI"; break;
                        case 7: rom += "VII"; break;
                        case 8: rom += "VIII"; break;
                        case 9: rom += "IX"; break;
                    }
                    numero -= numero;
                }
                else
                {
                    MessageBox.Show("O número está fora do intervalo");
                    break;
                }
                if(numero == 0)
                    break;
                

                
            }
            return rom;
        }
      
    }
}
