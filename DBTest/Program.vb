Imports System
Imports System.Data
Imports System.Data.SqlClient



Module Program
    Sub Main(args As String())
        ' Console.WriteLine("Hello World!")

        Dim connection As SqlConnection
        connection = new SqlConnection("Data Source=PMCLAP1248; initial catalog=school; user id=sa; password=PmcIndia@123;")

    End Sub
End Module
