using System;
using System.Linq;
using MoreLinq;
using Newtonsoft.Json.Linq;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression;
using DynamicExpresso;
using NDesk.Options;

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
		}
	}
}
