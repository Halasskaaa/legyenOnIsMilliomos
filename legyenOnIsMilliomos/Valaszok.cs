using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenOnIsMilliomos
{
	internal class Valaszok
	{
		string a;
		string b;
		string c;
		string d;

		public Valaszok(string a, string b, string c, string d)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
		}

		public string A { get => a; set => a = value; }
		public string B { get => b; set => b = value; }
		public string C { get => c; set => c = value; }
		public string D { get => d; set => d = value; }
	
		public override string ToString()
		{
			return $"A {a} \t B {b} \nC {c} \t D {d}";
		}


		char[] helyesValasz = new char[]
		{
			'c',
			'd',
			'd',
			'a',
			'b',
			'c',
			'a',
			'a',
			'b',
			'd',
			'b',
			'c',
			'd',
			'a',
			'c',
		};


	}
}
