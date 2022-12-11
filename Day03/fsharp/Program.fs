open System
open System.IO
open System.Text.Json

let part1 (input:String seq) =
    input
        |> Seq.map(fun x -> seq {x.Substring(0, x.Length / 2)
                                 x.Substring(x.Length / 2)})
        |> Seq.map(fun y -> y |> Seq.map Set)
        |> Seq.map(Set.intersectMany)
        |> Seq.map(Seq.exactlyOne >> int)
        |> Seq.map(fun z -> if z >= 97 then z - 96 else z - 38)
        |> Seq.sum

let part2 (input: String seq) =
    input
        |> Seq.map Set
        |> Seq.chunkBySize(3)
        |> Seq.map(Set.intersectMany)
        |> Seq.map(Seq.exactlyOne >> int)
        |> Seq.map(fun z -> if z >= 97 then z - 96 else z - 38)
        |> Seq.sum

let input = File.ReadLines "input.txt"

part1 input |> JsonSerializer.Serialize |> Console.WriteLine
part2 input |> JsonSerializer.Serialize |> Console.WriteLine
