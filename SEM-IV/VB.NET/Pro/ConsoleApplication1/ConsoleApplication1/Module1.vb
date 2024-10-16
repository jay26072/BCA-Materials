Imports System.StringComparer
Module Module1

    Sub Main()
        Dim str, str1, ans As String
        Dim com As Integer
        str = "Yash and Karan are Good Boys"
        str1 = "Hello"

        ans = Len(str)
        Console.WriteLine(ans)
        com = String.Compare(str, str1)
        Console.WriteLine(com)
        Console.ReadLine()


    End Sub

End Module
