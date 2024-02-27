Imports System

Module Program
    Sub Main(args As String())
        ' Console.WriteLine("Hello World!")
        Dim num1 As Integer = 10
        Dim num2 As Integer = 3


        ' creating object of class ArithmeticOperator

        ' Dim AOObj As New ArithmeticOperator

        ' Console.WriteLine("Addition: " & AOObj.Addition(12, 12))  ' direct passing value
        ' Console.WriteLine("Substraction: " & AOObj.Substraction(num1, num2))
        ' Console.WriteLine("Multiplication: " & AOObj.Multiplication(num1, num2))
        ' Console.WriteLine("DivisionReturnDeci: " & AOObj.DivisionReturnDeci(num1, num2))
        ' Console.WriteLine("DivisionReturnInt: " & AOObj.DivisionReturnInt(num1, num2))
        ' Console.WriteLine("IntDivision: " & AOObj.IntDivision(num1, num2))
        ' Console.WriteLine("Modulus: " & AOObj.Modulus(num1, num2))


        ' creating object of ComparisonOpetator

        ' Dim COObj As New ComparisonOperator

        ' Dim obj1 As Object = "Hello"
        ' Dim obj2 As Object = "Hello"

        ' Dim str1 As String = "Apple"
        ' Dim Str2 As String = "A*" ' Starts with A
        ' Dim Str3 As String = "*l*" ' Contains l
        ' Dim Str4 As String = "*e" ' Ends with e

        ' COObj.EqualTo(num1, num2)
        ' COObj.NotEqualTo(num1, num2)
        ' COObj.GreaterThan(num1, num2)
        ' COObj.LessThan(num1, num2)
        ' COObj.GreaterThanEqualTo(num1, num2)
        ' COObj.LessThanEqualTo(num1, num2)
        ' COObj.IsOperator(obj1, obj2)
        ' COObj.IsNotOperator(obj1, obj2)
        ' COObj.LikeOperator(str1, str2)
        ' COObj.LikeOperator(str1, str3)
        ' COObj.LikeOperator(str1, str4)

        Dim LOObj As New LogicalOperator

        LOObj.DisplayOperations()

    End Sub

    ' class for arithmetic operator example
    Public Class ArithmeticOperator

        Public Sub New ()
            Console.WriteLine("ArithmeticOperator class constructor called.")
        End Sub
        

        Public Function Addition(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Return num1 + num2
        End Function

        Public Function Substraction(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Return num1 - num2
        End Function
        
        Public Function Multiplication(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Dim sum As Integer = num1 * num2
            Return sum
        End Function
        
        Public Function DivisionReturnDeci(ByVal num1 As Integer, ByVal num2 As Integer) As Decimal 
            Return num1 /num2
        End Function

        Public Function DivisionReturnInt(ByVal num1 As Integer, ByVal num2 As Integer) As Integer 
            Return num1 /num2
        End Function

        Public Function IntDivision(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Dim sum As Integer = num1 \ num2
            Return sum
        End Function

        Public Function Modulus(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
            Return num1 Mod num2
        End Function
        
        
    End Class


    ' class for comparison operator example
    Public Class ComparisonOperator
        
        ' constructure 
        Public Sub New()
            Console.WriteLine("ComparisonOperator class constructure called.")
        End Sub

        Public Sub EqualTo(ByVal num1 As Integer, ByVal num2 As Integer) 
            Console.WriteLine("Equal to: {0} = {1}? = {2}", num1, num2, (num1 = num2))
        End Sub

        Public Sub NotEqualTo(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Not Equal to: {0} <> {1}? = {2}", num1, num2, (num1 <> num2))
        End Sub

        Public Sub GreaterThan(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Greater Than: {0} > {1}? = {2}", num1, num2, (num1 > num2))
        End Sub

        Public Sub LessThan(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Less Than: {0} < {1}? = {2}", num1, num2, (num1 < num2))
        End Sub

        Public Sub GreaterThanEqualTo(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Greater Than Equal to: {0} >= {1}? = {2}", num1, num2, (num1 >= num2))
        End Sub

        Public Sub LessThanEqualTo(ByVal num1 As Integer, ByVal num2 As Integer)
            Console.WriteLine("Less Than Equal to: {0} <= {1}? = {2}", num1, num2, (num1 <= num2))
        End Sub

        Public Sub IsOperator(ByVal obj1 As Object, ByVal obj2 As Object)
            Console.WriteLine("obj1 IS obj2: " & (obj1 Is obj2))
        End Sub

        Public Sub IsNotOperator(ByVal obj1 As Object, ByVal obj2 As Object)
            Console.WriteLine("obj1 IS NOT obj2: " & (obj1 IsNot obj2))
        End Sub

        Public Sub LikeOperator(ByVal str1 As String, ByVal str2 As String)
            Console.WriteLine("obj1 Like obj2: " & (str1 Like str2))
        End Sub

    End Class
    
    ' class for logical operator example
    Public Class LogicalOperator

        Public Sub DisplayOperations()
            Dim a As Boolean = False 
            Dim b As Boolean = True 

            Console.WriteLine("A AndAlso B = {0}", (a AndAlso b))
            Console.WriteLine("A And B = {0}", (a And b))
            Console.WriteLine("A OrElse B = {0}", (a OrElse b))
            Console.WriteLine("A Or B = {0}", (a Or b))
            Console.WriteLine("A Xor B = {0}", (a Xor b))
            Console.WriteLine("Not A = {0}", (Not a))
            Console.WriteLine("Not B = {0}", (Not b))
        End Sub
    End Class
End Module


