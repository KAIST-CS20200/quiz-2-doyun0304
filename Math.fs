module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec f (t:uint64) result = 
    if t=1UL then result
    elif t%2UL=0UL then f (t/2UL) (result+1)
    else f (3UL*t+1UL) (result+1)
  
  f (uint64 n) 0
