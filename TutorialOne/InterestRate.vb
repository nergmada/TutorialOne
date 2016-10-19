Module InterestRate
    Sub Main()
        Dim Amount As Double = Console.ReadLine()

        '£134.5343232
        Dim WithInterest As Double = Amount * 1.0134625
        '£13453.43232
        Dim byOneHundred As Double = WithInterest * 100
        '£13454
        Dim TotalByOneHundred As Integer = Math.Ceiling(byOneHundred)
        '£134.54
        Dim Total As Double = TotalByOneHundred / 100
    End Sub
End Module
