let x = 10
let y = 20

let swap x y = 
    (y, x) // Return a tuple containing swapped values

let x', y' = swap x y
printfn "%d %d" x' y' // Output: 20 10

//Alternative using a mutable record:
type MyRecord = {X : int; Y : int}
let mutable myRecord = {X = 10; Y = 20}

let swapRecord record = 
  let temp = record.X
  record.X <- record.Y
  record.Y <- temp

swapRecord myRecord
printfn "%d %d" myRecord.X myRecord.Y