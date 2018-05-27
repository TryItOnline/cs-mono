Imports System
Imports System.Linq
Imports MoreLinq
Imports Newtonsoft.Json.Linq
Imports MathNet.Symbolics
Imports Expr = MathNet.Symbolics.Expression

Public Class Application
	Public Shared Sub Main()
		Console.WriteLine(Enumerable.First(MoreEnumerable.Random()))
        Console.WriteLine(JObject.Parse("{""foo"":42}"))
        Dim x As Expr = Expr.Symbol("x")
        Console.WriteLine(Infix.Format(x+x))
	End Sub
End Class
