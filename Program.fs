open System
open MoreLinq
open System.Linq
open MathNet.Symbolics
open Newtonsoft.Json.Linq
open DynamicExpresso
open NDesk.Options

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
    //NDesk.Options
    let optionSet = new OptionSet()
    optionSet.Add<string> ("v", (new Action<string>(fun x -> ()))) |> ignore
    [|"-v"; "foo"|] |> optionSet.Parse |> printfn "%A"

    0
