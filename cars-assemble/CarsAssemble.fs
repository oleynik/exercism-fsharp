module CarsAssemble

let CARS_PER_HOUR = 221;
let MINUTES_PER_HOUR = 60;

let successRate (speed: int): float =
    match speed with
    | speed when speed >= 1 && speed <= 4 -> 1
    | speed when speed >= 5 && speed <=8 -> 0.9
    | 9  -> 0.8
    | 10 -> 0.77
    | _ -> 0

let productionRatePerHour (speed: int): float =
     successRate speed * (float speed) * (float CARS_PER_HOUR)

let workingItemsPerMinute (speed: int): int =
    (productionRatePerHour speed |> int) / MINUTES_PER_HOUR