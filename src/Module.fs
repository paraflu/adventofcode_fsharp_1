module AdventOfCode

type Deep =
    | Increase
    | Decrease

let readLines filePath =
    System.IO.File.ReadLines(filePath)
    |> Seq.map (fun it -> it |> int)

let count_increments sequence =
    sequence
    |> Seq.pairwise
    |> Seq.filter (fun (prev, curr) -> prev < curr) |> Seq.length

let theList (file: string) = readLines file |> count_increments
