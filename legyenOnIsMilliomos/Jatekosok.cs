using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenOnIsMilliomos
{
	internal class Jatekosok
	{
		Random rnd = new Random();

		string name;
		int age;
		string gender;
		string occupation;

		public Jatekosok(string name, int age, string gender, string occupation)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.occupation = occupation;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Gender { get => gender; set => gender = value; }
		public string Occupation { get => occupation; set => occupation = value; }

		public override string ToString()
		{
			return $"Játékos neve: {name}, kora: {age}, neme: {gender}, foglalkozása: {occupation}";
		}
	}

}
