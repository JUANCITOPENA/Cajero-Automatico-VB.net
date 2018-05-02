Imports System.Data.OleDb
Public Class Form4

    Dim conexion As New OleDb.OleDbConnection

    Sub Modificar()

        Dim CMD As New OleDb.OleDbCommand("update Cliente set saldo ='" & Form1.txtMostrar.Text & "' where clave= '" & Form1.txtEntrada_Datos.Text & "'", conexion)

        conexion.Open()
        CMD.ExecuteNonQuery()
        conexion.Close()

        MsgBox("Retire su Dienero Por favor")
        'Application.Exit()

    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form1.txtMostrar.Text = Val(Form1.txtMostrar.Text) - Val(txtRetiros.Text)
        Call Modificar()
        Label2.Text = ""
        txtRetiros.Hide()
        Label2.Text = Form1.txtMostrar.Text

    End Sub


    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\Clientes.accdb")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Application.Exit()

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Form1.txtMostrar.Text = Val(Form1.txtMostrar.Text) - Val(txtRetiros.Text)
        Call Modificar()
        Label2.Text = ""
        txtRetiros.Hide()
        Label2.Text = Form1.txtMostrar.Text
    End Sub
End Class