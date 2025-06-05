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




		
		// https://refresher.hu/2893-REFRESHER-KVIZ-Te-helyesen-tudsz-valaszolni-a-Legyen-On-is-Milliomos-kerdeseire
		// https://www.google.com/search?q=legy%C3%A9l+te+is+milliomos+k%C3%A9rd%C3%A9sek+neh%C3%A9zs%C3%A9g+szerint&oq=legy%C3%A9l+te+is+milliomos+k%C3%A9rd%C3%A9sek+neh%C3%A9zs%C3%A9g+szerint&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIKCAEQABiABBiiBDIKCAIQABiABBiiBDIHCAMQABjvBTIKCAQQABiABBiiBDIKCAUQABiABBiiBNIBCDg2MzZqMGo3qAIAsAIA&sourceid=chrome&ie=UTF-8

		// Folytassa az alábbi népi gyermekdalt: 'szita szita péntek, szerelem csütörtök...' 
// hódeszka
// lómenza
// dobszerda
// gólszerva

// Melyik Disney-karakter hagyja el üvegcipellőjét egy bálon az alábbiak közül?
// Pocahontas
// Elsa
// Csipkerózsika
// Hamupipőke

// Milyen intézmény a Harry Potter-könyvekben szereplő Azkaban?
// iskola
// stadion
// múzeum
// börtön

// Mi a gépjárművek tengelykapcsolójának ismertebb neve?
// porlasztó
// kuplung
// gyertya
// akkumulátor

// Az alábbi történelmi alakok közül kit NEM Ádám személyesít meg Az ember tragédiájában?
// Miltiadész
// Kepler
// Michelangelo
// Danton

// Ki a szerelem istene az ősi hindu mitológiában?
// Coitus
// Káma
// Szutra
// Interruptus

// Az alábbiak közül melyik tudományágban NEM osztanak ki Nobel-díjat?
// fizika
// kémia
// matematika
// orvostudomány

// Ki a főhőse A világ nem elég című, 1999-ben bemutatott filmnek?
// Batman
// Superman
// James Bond
// Sherlock Holmes

// Melyik szervünk termeli az adrenalint?
// mellékvese
// pajzsmirigy
// hasnálmirigy
// hipotalamusz

// Ki fedezte fel távcsövével a Hold hegyeit és a Jupiter négy holdját?
// Nikolausz Kopernikusz
// Galileo Galilei
// Karl Friedrich Gauss
// Johannes Kepler

// Milyen nemzetiségű volt Jean Sibelius zeneszerző?
// belga
// finn
// norvég
// német

// Kik rabolták el a szabin nőket?
// Római ifjak
// Zeusz és testvérei
// Hunor és Magor
// Nagy Sándor katonái

// Melyik regény főhőse Raszkolnyikov az alábbiak közül?
// A Karamazon testvérek
// Háború és béke
// Az orr
// Bűn és bűnhődés

// Következzen egy olyan kérdés, amely 2000-ben egymillió dollárt hozott a nyertes David Goodman konyhájára: Eredetileg melyik országból származik Paddington mackó, a híres gyerekkönyv-sorozat főszereplője?
// Izland
// Peru
// Skócia
// Bolívia

// Szintén millió dolláros kérdés az amerikai Legyen Ön is Milliomos!-ból: A híres Amerikai gótika című festményen kiről mintázta a férfi karakterét a művész Grant Wood?
// az apjáról
// a henteséről
// a helyi seriffről
// a fogorvosáról
	}
}
