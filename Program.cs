using System;
using System.Linq;
using MoreLinq;
using Newtonsoft.Json.Linq;

namespace TIO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine(MoreEnumerable.Random().First());
			Console.WriteLine(JObject.Parse(@"{""foo"":42}"));
        }
    }
}
