module AdventOfCode

type Deep =
    | Increase
    | Decrease

let readLines filePath =
    System.IO.File.ReadLines(filePath)
    |> Seq.map (fun it -> it |> int)


let get_increment (sequence: seq<int * int>) =
    sequence
    |> Seq.filter (fun (prev, curr) -> prev < curr)

let count_increments sequence =
    sequence
    |> Seq.pairwise
    |> get_increment
    |> Seq.length

let theList (file: string) = readLines file 

let window_seq (sequence: seq<int>) =
    sequence
    |> Seq.windowed 3
    |> Seq.map (Seq.reduce (fun t i -> t + i))
    |> Seq.pairwise
