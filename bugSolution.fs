let add x y = 
    let sum = x + y
    (sum, sum + x)

let x = 10
let y = 20

let (x1,y1) = add x y

printf "%d %d" x1 y1 //This will output 30 50 which is correct