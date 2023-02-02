module LuciansLusciousLasagna

// TODO: define the 'expectedMinutesInOven' binding
let expectedMinutesInOven = 40

// TODO: define the 'remainingMinutesInOven' function
let remainingMinutesInOven x = expectedMinutesInOven - x

// TODO: define the 'preparationTimeInMinutes' function
let preparationTimeInMinutes x = 2 * x

// TODO: define the 'elapsedTimeInMinutes' function
let elapsedTimeInMinutes number_of_layers actual_minutes_in_oven =
    actual_minutes_in_oven + preparationTimeInMinutes number_of_layers
