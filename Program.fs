open System
// Reverses number
let rec reverse number =
    if number < 10
    then number
    else (number % 10 * int (10.0 ** float (int (log10 (float number))))) + reverse (number / 10)

// Returns reversed Sum of two reversed numbers
let solve x y =
    reverse (reverse x + reverse y)
    
// Applies given function to the given list
let rec map (f: int[] -> unit) list=
        match list with
        | [] -> ()
        | head::tail ->
            let row: int[] = head
            f row
            
            map f tail


[<EntryPoint>]
let main argv =
    let input =
        [ [| 24; 1 |]
          [| 4358; 754 |]
          [| 305; 794 |] ]
        
    printfn "Output:"
    map (fun row -> printfn "%d" (solve row.[0] row.[1])) input
        
    0