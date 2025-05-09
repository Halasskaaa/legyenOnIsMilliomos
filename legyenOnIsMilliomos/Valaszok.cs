using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legyenOnIsMilliomos
{
	internal class Valaszok
	{
		char a;
		char b;
		char c;
		char d;

		public Valaszok(char a, char b, char c, char d)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
		}

		public char A { get => a; set => a = value; }
		public char B { get => b; set => b = value; }
		public char C { get => c; set => c = value; }
		public char D { get => d; set => d = value; }
	
		public override string ToString()
		{
			return $"A {a} \t B {b} \nC {c} \t D {d}";
		}
	}
}
