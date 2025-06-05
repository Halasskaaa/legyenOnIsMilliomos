using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenOnIsMilliomos
{
	internal class Segitseg
	{
		public bool Kozonseg { get; private set; } = true;

		public bool Felezo { get; private set; } = true;

		public bool Telefon { get; private set; } = true;

		public void Hasznal(string tipus, char helyes) 
		{
			switch (tipus.ToLower()) 
			{
				case "kozonseg":
					if (!Kozonseg) { Console.WriteLine("Ezt már használtad!"); break; }
					Console.WriteLine("A közönség 80%-a szerint a helyes válasz: " + helyes);				
					Kozonseg = false;			
					break;		
					
				case "felezo":				
					if (!Felezo) { Console.WriteLine("Ezt már használtad!"); break; }				
					Console.WriteLine("Két hibás válasz eltávolítva.");				
					Felezo = false;				
					break;
			
				case "telefon":				
					if (!Telefon) { Console.WriteLine("Ezt már használtad!"); break; }
					Console.WriteLine("A barátod azt mondja: talán a(z) " + helyes + " a helyes.");				
					Telefon = false;			
					break;
				default:
					Console.WriteLine("Érvénytelen segítség.");
					break;	
			}
			
		}
		
		public void MutatElerheto() 
		{
			Console.Write("Elérhető segítségek: ");
			
			if (Kozonseg) Console.Write("Közönség ");

			if (Felezo) Console.Write("Felező ");

			if (Telefon) Console.Write("Telefon ");

			Console.WriteLine();
		}

		// Kérdések válaszok forrása: https://refresher.hu/2893-REFRESHER-KVIZ-Te-helyesen-tudsz-valaszolni-a-Legyen-On-is-Milliomos-kerdeseire
		// Plusz Wikipédia
		
	}
}
