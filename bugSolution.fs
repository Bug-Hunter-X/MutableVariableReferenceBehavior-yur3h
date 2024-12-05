let x = ref 10
let y = x
:?> int ref y <- 20
printf "%d %d" x.Value y.Value