Imports System.Data.OleDb


Public Class Form1

    Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\Clientes.accdb;Persist Security Info=False;")
    'Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\myAccessFile.accdb")
    'Dim conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Clientes.accdb;Persist Security Info=False;")
    Public Function ask()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        conexion.Open()
        Dim da As New OleDbDataAdapter("select * from Cliente", conexion)
        da.Fill(dt)

        For Each DataRow In dt.Rows
            If txtEntrada_Datos.Text = DataRow(0) Then

                conexion.Close()
                Return True

            End If

        Next
        conexion.Close()
        Return False

    End Function
    Sub buscar()
   
            Dim CMD As New OleDb.OleDbCommand("select * from Cliente where clave ='" & txtEntrada_Datos.Text & "'", conexion)
            Dim dr As OleDb.OleDbDataReader
            conexion.Open()
            dr = CMD.ExecuteReader


        If dr.Read Then

            txtMostrar.Text = dr(1)
        Else
            If MessageBox.Show("Error En Cuenta", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If

        End If

        conexion.Close()


    End Sub


    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "1"

    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        txtEntrada_Datos.Text = txtEntrada_Datos.Text & "0"
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        txtEntrada_Datos.Text = ""
        txtMostrar.Text = ""


    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Call buscar()
        If ask() = True Then
            seleccion_monto.Show()
            Hide()


        ElseIf MessageBox.Show("Error En Cuenta", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ask() = True Then
                Form2.Show()
                'Hide()

            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Application.Exit()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
End Class
