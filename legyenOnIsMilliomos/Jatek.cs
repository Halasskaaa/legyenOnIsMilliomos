using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace legyenOnIsMilliomos
{
	internal class Jatek
	{
		private List<Kerdesek> questions = new List<Kerdesek>();
		private List<Valaszok> answers = new List<Valaszok>();
		private List<char> helyesValaszok = new List<char>();
		private Segitseg segitseg = new Segitseg();

		private int[] nyeremenyek = { 10000, 20000, 50000, 100000, 250000, 500000, 750000, 1000000, 1500000, 2000000, 5000000, 10000000, 15000000, 25000000, 50000000 };

		public void Feltolt()
		{
			questions.Add(new Kerdesek("Folytassa az alábbi népi gyermekdalt: Szita szita péntek, szerelem csütörtök... "));
			answers.Add(new Valaszok("hódeszka", "lómenza", "dobszerda", "gólszerva"));
			helyesValaszok.Add('C');

			questions.Add(new Kerdesek("Melyik Disney-karakter hagyja el üvegcipellőjét egy bálon az alábbiak közül?"));
			answers.Add(new Valaszok("Pocahontas", "Elsa", "Csipkerózsika", "Hamupipőke"));
			helyesValaszok.Add('D');

			questions.Add(new Kerdesek("Milyen intézmény a Harry Potter-könyvekben szereplő Azkaban?"));
			answers.Add(new Valaszok("iskola", "stadion", "múzeum", "börtön"));
			helyesValaszok.Add('D');

			questions.Add(new Kerdesek("Mi a gépjárművek tengelykapcsolójának ismertebb neve?"));
			answers.Add(new Valaszok("porlasztó", "kuplung", "gyertya", "akkumulátor"));
			helyesValaszok.Add('B');

			questions.Add(new Kerdesek("Az alábbi történelmi alakok közül kit NEM Ádám személyesít meg Az ember tragédiájában?"));
			answers.Add(new Valaszok("Miltiadész", "Kepler", "Michelangelo", "Danton"));
			helyesValaszok.Add('C');

			questions.Add(new Kerdesek("Ki a szerelem istene az ősi hindu mitológiában?"));
			answers.Add(new Valaszok("Coitus", "Káma", "Szutra", "Interruptus"));
			helyesValaszok.Add('B');
			
			questions.Add(new Kerdesek("Az alábbiak közül melyik tudományágban NEM osztanak ki Nobel-díjat?"));
			answers.Add(new Valaszok("fizika", "kémia", "matematika", "orvostudomány"));
			helyesValaszok.Add('C');
			
			questions.Add(new Kerdesek("Ki a főhőse A világ nem elég című, 1999-ben bemutatott filmnek?"));
			answers.Add(new Valaszok("Batman", "Superman", "James Bond", "Sherlock Holmes"));
			helyesValaszok.Add('C');
			
			questions.Add(new Kerdesek("Melyik szervünk termeli az adrenalint?"));
			answers.Add(new Valaszok("mellékvese", "pajzsmirigy", "hasnálmirigy", "hipotalamusz"));
			helyesValaszok.Add('A');
			
			questions.Add(new Kerdesek("Ki fedezte fel távcsövével a Hold hegyeit és a Jupiter négy holdját?"));
			answers.Add(new Valaszok("Nikolausz Kopernikusz", "Galileo Galilei", "Karl Friedrich Gauss", "Johannes Kepler"));
			helyesValaszok.Add('B');
			
			questions.Add(new Kerdesek("Milyen nemzetiségű volt Jean Sibelius zeneszerző?"));
			answers.Add(new Valaszok("belga", "finn", "norvég", "német"));
			helyesValaszok.Add('B');
			
			questions.Add(new Kerdesek("Kik rabolták el a szabin nőket?"));
			answers.Add(new Valaszok("Római ifjak", "Zeusz és testvérei", "Hunor és Magor", "Nagy Sándor katonái"));
			helyesValaszok.Add('A');
						
			questions.Add(new Kerdesek("Melyik regény főhőse Raszkolnyikov az alábbiak közül?"));
			answers.Add(new Valaszok("A Karamazon testvérek", "Háború és béke", "Az orr", "Bűn és bűnhődés"));
			helyesValaszok.Add('D');
						
			questions.Add(new Kerdesek("Következzen egy olyan kérdés, amely 2000-ben egymillió dollárt hozott a nyertes David Goodman konyhájára: Eredetileg melyik országból származik Paddington mackó, a híres gyerekkönyv-sorozat főszereplője?"));
			answers.Add(new Valaszok("Izland", "Peru", "Skócia", "Bolívia"));
			helyesValaszok.Add('B');
						
			questions.Add(new Kerdesek("Szintén millió dolláros kérdés az amerikai Legyen Ön is Milliomos!-ból: A híres Amerikai gótika című festményen kiről mintázta a férfi karakterét a művész Grant Wood?"));
			answers.Add(new Valaszok("az apjáról", "a henteséről", "a helyi seriffről", "a fogorvosáról"));
			helyesValaszok.Add('D');
		}

		public void Indit() 
		{
			Feltolt();

			for (int i = 0; i < questions.Count; i++)
			{
				Console.WriteLine($"\nKérdés {i + 1} - Nyeremény: {nyeremenyek[i]} Ft");
				Console.WriteLine(questions[i]);

				char helyes = helyesValaszok[i];
				bool felezoHasznalva = false;

				while (true) 
				{
					segitseg.MutatElerheto();
					Console.WriteLine("Írd be a válasz betűjét (A/B/C/D) vagy egy segítséget (kozonseg, felezo, telefon):");
					string input = Console.ReadLine().Trim().ToLower();

					if (input == "kozonseg" || input == "felezo" || input == "telefon") 
					{
						segitseg.Hasznal(input, helyes);
						if (input == "felezo" && !felezoHasznalva)
						{
							felezoHasznalva = true;
							answers[i].Megjelenit(new char[] { helyes, RandomWrong(helyes) });
						}
						continue;
					}

					if (input.Length == 1 && "abcd".Contains(input)) 
					{
						char valasz = char.ToUpper(input[0]);
						if (valasz == helyes) 
						{
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("Helyes válasz!");
							Console.ResetColor();
							break;
						}
						else 
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Rossz válasz!");
							Console.ResetColor();
							Console.WriteLine($"Biztonságos nyeremény: {GetSafePrize(i)} Ft");
							return;
						}
					}
					Console.WriteLine("Érvénytelen bemenet.");
				}
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Gratulálok! Megnyerte a fődíjat: 50 millió Ft!");
			Console.ResetColor();
		}

		private char RandomWrong(char helyes) 
		{
			char[] options = new char[] { 'A', 'B', 'C', 'D' };
			Random rand = new Random();
			char val;
			do
			{
				val = options[rand.Next(4)];
			} while (val == helyes);
			return val;
		}

		private int GetSafePrize(int index) 
		{
			if (index >= 10) return 5000000;
			if (index >= 5) return 250000;
			return 0;
		}
	}
}
