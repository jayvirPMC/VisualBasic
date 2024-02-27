' Imports System

' Module Program
'     Sub Main(args As String())
'         Dim num As Integer

'         Console.WriteLine(num)
'         num = 133
'         Console.WriteLine(num)

'         Dim Name As String = "jayvir"
'         Dim isTrue As Boolean = True 
'         Dim charVal As Char = "s"
'         Dim salary As Decimal = 35.214
'         Dim myDate As Date = Date.Now()
'         Console.WriteLine("num: " & num)
'         Console.WriteLine("name: " & Name)
'         Console.WriteLine("isTrue: " & isTrue)
'         Console.WriteLine("charVal: " & charVal)
'         Console.WriteLine("salary: " & salary)
'         Console.WriteLine("myDate: " & myDate)

'         Console.Write("Enter your name: ")
'         Dim myName As String = Console.ReadLine()
'         PrintMessage(myName)
'     End Sub

'     Sub PrintMessage(ByVal myName As String)
'         Console.WriteLine("Hello, " & myName)
'     End Sub
    
' End Module





Imports System

Public Class Circle
    
End Class


Module Program
    Sub Main()
        Dim name As String
        Dim age As Integer
        Dim gender As Char

        Console.Write("Enter your name: ")
        name = Console.ReadLine()
        Console.Write("Enter your age: ")
        age = Integer.Parse(Console.ReadLine())
        Console.Write("Enter your gender(M/F): ")
        Dim genderKey As ConsoleKeyInfo = Console.ReadKey()
        gender = genderKey.KeyChar

        DisplayDetails(name, age, gender)


    End Sub

    Public Sub DisplayDetails(ByVal name as String, ByVal age as Integer, ByVal gender as Char)
        Console.WriteLine()
        Console.WriteLine("Name: " & name)
        Console.WriteLine("age: " & age)
        Console.WriteLine("gender: " & gender)
    End Sub
    
End Module