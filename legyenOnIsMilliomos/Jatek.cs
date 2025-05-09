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

		List<Kerdesek> Questions = new List<Kerdesek>();
		List<Valaszok> Answers = new List<Valaszok>();


		Kerdesek k01 = new Kerdesek("Folytassa az alábbi népi gyermekdalt: „Szita szita péntek, szerelem csütörtök...”");
		Valaszok v01 = new Valaszok("hódeszka", "lómenza", "dobszerda", "gólszerva");

		Kerdesek k02 = new Kerdesek("Melyik Disney-karakter hagyja el üvegcipellőjét egy bálon az alábbiak közül?");
		Valaszok v02 = new Valaszok("Pocahontas", "Elsa", "Csipkerózsika", "Hamupipőke");

		public void QuestionAnswers()
		{
			Questions.Add(k01);
			Questions.Add(k02);

			Answers.Add(v01);
			Answers.Add(v02);

		}

		public void Experimental()
		{

			for (int i = 0; i < Questions.Count; i++)
			{
				Console.WriteLine(Questions[0]);
				Console.WriteLine(Answers[0]);
				string charCode = Console.ReadLine();
				//if (charCode == helyesValasz[0])
				//{
    //                Console.WriteLine();
    //            }

			}
		}

	}
}
