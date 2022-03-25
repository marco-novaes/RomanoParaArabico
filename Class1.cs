using System;
using System.Collections;

public class Class1
{

		private enum DigitoRomano
	{
		I = 1,
		V = 5,
		X = 10,
		L = 50,
		C = 100,
		D = 500,
		M = 1000

	}

	public int RomanoParaArabico(string romano)
	{
		int total = 0;
		int contadorDeDigito = 0;
		ArrayList valores = new ArrayList();
		while (contadorDeDigito < romano.Length)
		{
			char _numeral = romano[contadorDeDigito];
			int digito = (int)Enum.Parse(typeof(DigitoRomano), _numeral.ToString());
			int proximoDigito = 0;
			if (contadorDeDigito < romano.Length - 1)
			{
				char proximoNumeral = romano[contadorDeDigito + 1];
				proximoDigito = (int)Enum.Parse(typeof(DigitoRomano), proximoNumeral.ToString());
				if (proximoDigito > digito)
				{
					digito = proximoDigito - digito;
					contadorDeDigito++;
				}
			}
			valores.Add(digito);
			contadorDeDigito++;
		}
		foreach (int digito in valores)
			total += digito;
		return total;
	}

	
}




