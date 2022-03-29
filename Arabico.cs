using System;
using System.Collections;

public class Arabico
{

	public int ConversaoSimples(string numero)
    {
        numero = numero.ToUpper();
        int resultado = 0;

        //Foreach para percorrer cada elemento de nossa cadeia
        foreach(char letra in numero)
        {
            resultado += LetraParaNumero(letra);
        }

        //Exemplo DXXXIV = 534
        //500 = D
        //10 = X
        //10 = X
        //10 = X
        //1 = I
        //5 = V
        //Resultado = 536 Errado
        // Resultado = Resultado - 2
        // Resultado = 534 CORRETO
        if (numero.Contains("IV") || numero.Contains("IX"))
            resultado -= 2;

        if (numero.Contains("XL") || numero.Contains("XC"))
            resultado -= 20;

        if (numero.Contains("CD") || numero.Contains("CM"))
            resultado -= 200;

        return resultado;
    }

    //função para converter letra em número
    public int LetraParaNumero(char letra)
    {
        switch (letra)
        {
            case 'M':
                {
                    return 1000;
                }
            case 'D':
                {
                    return 500;
                }
            case 'C':
                {
                    return 100;
                }
            case 'L':
                {
                    return 50;
                }
            case 'X':
                {
                    return 10;
                }
            case 'V':
                {
                    return 5;
                }
            case 'I':
                {
                    return 1;
                }
            default: 
                {
                    throw new ArgumentException("Caractere inválido");
                    //MessageBox.Show("Caractere inválido");
                }
        }
    }

	
}




