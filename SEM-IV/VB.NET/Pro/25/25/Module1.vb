Module Module1

    Sub Main()
        Dim str As String = "abc"
        Dim ans As String
        ans = str.Length()
        System.Console.WriteLine(ans)

        Dim ans1 As String
        ans1 = String.Compare("KEVAL", "keval")
        System.Console.WriteLine(ans1)

        Dim ans3 As String
        Dim str1 As String = "Keval "
        Dim str2 As String = "Prajapati"
        ans3 = String.Concat(str1, str2)
        System.Console.WriteLine(ans3)

        Dim ans4 As String
        ans4 = String.Equals("ABC", "ABC")
        System.Console.WriteLine(ans4)

        Dim ans5 As String
        ans5 = str.Insert(3, "def")
        System.Console.WriteLine(ans5)
        System.Console.ReadLine()
    End Sub

End Module