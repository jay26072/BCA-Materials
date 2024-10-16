Module Module1

    Sub Main()
        Console.Title = "Student Mark Sheet"
        Dim name As String
        Console.Write("Enter Student Name: ")
        name = Console.ReadLine()
        Dim id, wd, vb, jpl, isy, iot, total, per As Integer
        Console.Write("Enter Student Id: ")
        id = Console.ReadLine()
        Console.Write("Enter Marks Of WD-2: ")
        wd = Console.ReadLine()
        Console.Write("Enter Marks Of VB: ")
        vb = Console.ReadLine()
        Console.Write("Enter Marks Of JPL: ")
        jpl = Console.ReadLine()
        Console.Write("Enter Marks Of IS: ")
        isy = Console.ReadLine()
        Console.Write("Enter Marks Of IOT: ")
        iot = Console.ReadLine()
        total = wd + vb + jpl + isy + iot
        per = total / 5
        Console.Clear()
        Console.BackgroundColor = ConsoleColor.Gray
        Console.ForegroundColor = ConsoleColor.Black
        Console.WindowHeight = Console.LargestWindowHeight - 9
        Console.WindowWidth = Console.LargestWindowWidth - 9
        Console.WriteLine("******************************")
        Console.WriteLine("Student Id Is: " & id)
        Console.WriteLine("Student Name Is: " & name)
        Console.WriteLine("Entered Marks Of WD-2: " & wd)
        Console.WriteLine("Entered Marks Of VB: " & vb)
        Console.WriteLine("Entered Marks Of JPL: " & jpl)
        Console.WriteLine("Entered Marks Of IS: " & isy)
        Console.WriteLine("Entered Marks Of IOT: " & iot)
        Console.WriteLine("Total Marks Is: " & total)
        Console.WriteLine("Percentage Is: " & per)
        Console.WriteLine("******************************")
        Console.ReadLine()






    End Sub

End Module
