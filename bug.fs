let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y <- y + x
    x + y

printf "%d %d" x y  //This will output 30 50 which is incorrect
printf "%d" (add x y)