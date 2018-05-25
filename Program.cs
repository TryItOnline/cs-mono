using System;
using System.Linq;
using MoreLinq;
using Newtonsoft.Json.Linq;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression;

namespace TIO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine(MoreEnumerable.Random().First());
			Console.WriteLine(JObject.Parse(@"{""foo"":42}"));
			var x = Expr.Symbol("x");
			Console.WriteLine(Infix.Format(x+x));
        }
    }
}
