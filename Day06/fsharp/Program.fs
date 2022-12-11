open System
open System.IO

let part1 (input:String) =
    input
        |> Seq.windowed(4)
        |> Seq.map Set
        |> Seq.findIndex(fun x -> x.Count = 4)
        |> (+) 4

let part2 input =
    input
        |> Seq.windowed(14)
        |> Seq.map Set
        |> Seq.findIndex(fun x -> x.Count = 14)
        |> (+) 14

let input = File.ReadLines "input.txt"
part1 (Seq.exactlyOne input) |> Console.WriteLine
part2 (Seq.exactlyOne input) |> Console.WriteLine
