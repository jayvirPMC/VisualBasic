Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer = 10
        Dim Name As String = "jayvir"
        Dim isTrue As Boolean = True 
        Dim charVal As Char = "s"
        Dim salary As Decimal = 35.214
        Dim myDate As Date = Date.Now()
        Console.WriteLine("num: " & num)
        Console.WriteLine("name: " & Name)
        Console.WriteLine("isTrue: " & isTrue)
        Console.WriteLine("charVal: " & charVal)
        Console.WriteLine("salary: " & salary)
        Console.WriteLine("myDate: " & myDate)

        Console.Write("Enter your name: ")
        Dim myName As String = Console.ReadLine()
        PrintMessage(myName)
    End Sub

    Sub PrintMessage(ByVal myName As String)
        Console.WriteLine("Hello, " & myName)
    End Sub
    
End Module
