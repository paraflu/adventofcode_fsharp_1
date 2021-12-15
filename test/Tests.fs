module Tests

open System
open Xunit

[<Fact>]
let ``Test AdventOfCode First`` () =
    Assert.Equal(
        7,
        [ 199
          200
          208
          210
          200
          207
          240
          269
          260
          263 ]
        |> AdventOfCode.count_increments
    )

[<Fact>]
let ``Test AdventOfCode Second`` () =
    Assert.Equal(
        5,
        [ 199
          200
          208
          210
          200
          207
          240
          269
          260
          263 ]
        |> AdventOfCode.window_seq |> AdventOfCode.get_increment |> Seq.length
    )