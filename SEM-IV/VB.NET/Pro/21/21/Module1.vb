Module Module1
    Public Class calc
        Public Sub sum(ByVal a As Integer, ByVal b As Integer)
            System.Console.WriteLine("a + b = {0}", a + b)
        End Sub
        Public Sub sum(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
            System.Console.WriteLine("a + b + c = {0}", a + b + c)
        End Sub
    End Class
    Sub main(ByVal args As String())
        Dim c As calc = New calc
        c.sum(3, 3)
        c.sum(3, 3, 3)

        System.Console.WriteLine("Press Enter to Exit....")
        System.Console.ReadLine()

    End Sub

End Module
