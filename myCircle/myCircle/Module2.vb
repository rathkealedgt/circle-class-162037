Module Module2
    Sub Main()
        Dim p2 As New Point(3, 5)
        Dim c2 As New Circle(3, p2)

        Console.WriteLine(c2.ToString)
        Console.WriteLine("Diameter = " & c2.GetDiameter())
        Console.WriteLine("Area = " & c2.GetArea())
        Console.WriteLine("Perimeter = " & c2.GetCircumference())
        Console.WriteLine("Centre Point is = " & c2.GetPoint().ToString())
        Console.WriteLine("Distance From Origin = " & c2.GetPoint().Distance().ToString)
        Console.WriteLine("Radius = " & c2.GetRadius())
        Console.Read()



    End Sub
End Module
