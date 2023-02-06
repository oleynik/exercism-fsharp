module InterestIsInteresting

let interestRate(balance: decimal): single =
    match balance with
    | x when x < 0m -> 3.213f
    | x when x < 1_000m -> 0.5f
    | x when x < 5_000m -> 1.621f
    | _ -> 2.475f

let interest (balance: decimal): decimal =
   System.Convert.ToDecimal(interestRate balance) * balance / 100m

let annualBalanceUpdate(balance: decimal): decimal =
   balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
   match balance with
   | balance when balance <= 0m -> 0
   | _ -> ((taxFreePercentage |> decimal) * balance * 2m / 100m) |> int