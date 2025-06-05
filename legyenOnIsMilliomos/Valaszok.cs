using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenOnIsMilliomos
{
	internal class Valaszok
	{
		public string[] ValaszLista { get; set; }

		public Valaszok(string a, string b, string c, string d) 
		{
			ValaszLista = new string[] { a, b, c, d };
		}

		public void Megjelenit(char[] elerheto = null) 
		{
			char[] betuk = { 'A', 'B', 'C', 'D' };
			for (int i = 0; i < ValaszLista.Length; i++) 
			{
				if (elerheto == null || elerheto.Contains(betuk[i])) 
				{
					Console.WriteLine($"{betuk[i]}: {ValaszLista[i]}");
				}
			}
		}
		
		public string GetValasz(char betu) 
		{
			int index = betu - 'A';
			return ValaszLista[index];
		}
	}
}
