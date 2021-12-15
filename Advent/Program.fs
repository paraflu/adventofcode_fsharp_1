open Printf
open AdventOfCode

theList "input.txt"
|> window_seq
|> get_increment
|> Seq.length
|> printf "2021.12.2 result is %d\n"
