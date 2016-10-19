Module Module1

    Sub Main()
        Dim x As Double = Console.ReadLine()
        Dim y As Double = Console.ReadLine()

        Dim Slabs As Integer = Math.Ceiling(x / 0.609) * Math.Ceiling(y / 0.609)
        Dim uncutSlabs As Integer = Math.Floor(x / 0.609) * Math.Floor(y / 0.609)

        Dim cutSlabs As Integer = Slabs - uncutSlabs
    End Sub

End Module
