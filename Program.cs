using System;
using System.Linq;
using MoreLinq;
using Newtonsoft.Json.Linq;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression;
using DynamicExpresso;
using NDesk.Options;
using System.Collections.Immutable;
using Microsoft.Z3;

namespace TIO
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//MoreLinq
			Console.WriteLine(MoreEnumerable.Random().First());
			//Newtonsoft
			Console.WriteLine(JObject.Parse(@"{""foo"":42}"));
			//Mathnet
			var x = Expr.Symbol("x");
			Console.WriteLine(Infix.Format(x+x));
			//DynamicExpresso
			Console.WriteLine(new Interpreter().Eval("2+2"));
			//NDesk.Options
			Console.WriteLine(new OptionSet{
				{"v", v=>{}}
			}.Parse(new[] {"-v", "foo"})[0]);
			//System.Memory
			Console.WriteLine(new Span<int>(new[]{42})[0]);
			//System.Collections.Immutable
			Console.WriteLine(new[]{12}.ToImmutableArray()[0]);
			//Microsoft.Z3
			try {
				Console.WriteLine($"Z3: {Microsoft.Z3.Version.ToString()}");
			} catch(DllNotFoundException) {
				Console.WriteLine($"Warning, native Z3 library not detected");
			}
		}
	}
}
