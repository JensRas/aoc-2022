open System
open System.IO

let input = File.ReadLines "input.txt"

String.concat "\n" input |> Console.WriteLine
