let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // Output: 20 10

// However, if we try to swap immutable values:
let x = 10
let y = 20

let swap x y = 
    let temp = x
    x <- y // Error: This will not work as x is immutable
    y <- temp

swap x y
printfn "%d %d" x y