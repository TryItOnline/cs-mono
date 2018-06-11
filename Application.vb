Imports MoreLinq
Imports Newtonsoft.Json.Linq
Imports MathNet.Symbolics
Imports Expr = MathNet.Symbolics.Expression
Imports DynamicExpresso
Imports NDesk.Options

Public Class Application
	Public Shared Sub Main()
        'MoreLinq
		Console.WriteLine(Enumerable.First(MoreEnumerable.Random()))
        'Newtonsoft
		Console.WriteLine(JObject.Parse("{""foo"":42}"))
        'MathNet
		Dim x As Expr = Expr.Symbol("x")
		Console.WriteLine(Infix.Format(x+x))
        'DynamicExpresso
        Console.WriteLine(New Interpreter().Eval("2+2"))
	End Sub
End Class
