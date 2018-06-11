open MoreLinq
open System.Linq
open MathNet.Symbolics
open Newtonsoft.Json.Linq
open DynamicExpresso

open Operators

[<EntryPoint>]
let main argv =
    //MoreLinq
    MoreEnumerable.Random().First() |> printfn "%d"
    //Newtonsoft
    @"{""foo"":42}" |> JObject.Parse |> printfn "%O"
    //Mathnet
    let x = symbol "x"
    x+x |> Infix.format |> printfn "%s" 
    //DynamicExpresso
    let interpreter = new Interpreter ()
    "2+2" |> interpreter.Eval |> fun x -> x :?> int |> printfn "%d"

    0
