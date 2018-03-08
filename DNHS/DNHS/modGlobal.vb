Imports MetroFramework.Animation


Module modGlobal
    Public con As New OleDb.OleDbConnection
    Public ds As New DataSet
    Public da As New OleDb.OleDbDataAdapter
    Public sql As String
    Public row As Integer
    Public dr As OleDb.OleDbDataReader
    Public cmd As New OleDb.OleDbCommand
    Public inc As Integer
    Public xpos As New Integer
    Public ypos As New Integer
    Public pos As New Point
    Public loc As New Point
    Public chan As New kitchanismo.betsayda
    Public playername As String
    Public ma As New MoveAnimation
    Public ea As New ExpandAnimation
    Public lb As New ListBox
    Public ctr As Integer = 0
    Public i As Integer = 0
    Public timeleft As Integer
    Public correct As Integer = 0
    Public wrong As Integer = 0
    Public confirm As String
    Public togSE As Boolean = True
    Public togMusic As Boolean = True
    Public isonEquation As Boolean = False
    Public isonSquare As Boolean = False
    Public isonTime As Boolean = False
    Public isonMeasure As Boolean = False
    Public isonTemperature As Boolean = False
    Public startpath As String = Application.StartupPath
End Module
