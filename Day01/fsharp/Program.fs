open System
open System.Collections.Generic
open System.IO

let input = File.ReadLines "input.txt"

let part1 input =
    let mutable curSum = List<int>()
    let sums = List<List<int>>()

    for i in input do
        if String.IsNullOrWhiteSpace i then
            sums.Add(curSum)
            curSum <- List<int>()
        else
            curSum.Add(Int32.Parse(i))

    let max = sums
            |> Seq.map(fun x -> List.sum(List.ofSeq(x)))
    List.max(List.ofSeq(max))

let part2 input =
    let mutable group = List<int>()
    let groups = List<List<int>>()

    for i in input do
        if String.IsNullOrWhiteSpace i then
            groups.Add(group)
            group <- List<int>()
        else
            group.Add(Int32.Parse(i))

    let sums = groups
            |> Seq.map(fun x -> List.sum(List.ofSeq(x)))
            |> Seq.sortDescending
            |> Seq.take 3
    List.sum(List.ofSeq(sums))

part1 input |> Console.WriteLine
part2 input |> Console.WriteLine
