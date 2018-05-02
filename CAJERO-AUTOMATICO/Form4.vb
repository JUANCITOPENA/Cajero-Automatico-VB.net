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
        Timer1.Enabled = True


    End Sub


    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\Clientes.accdb")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Application.Exit()

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        seleccion_monto.Show()
        Hide()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        'DineroPTB.Visible = False
        Form1.txtMostrar.Text = Val(Form1.txtMostrar.Text) - Val(txtRetiros.Text)
        Call Modificar()
        Label2.Text = ""
        txtRetiros.Hide()
        Label2.Text = Form1.txtMostrar.Text
        Timer1.Enabled = True




    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DineroPTB.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Static C As Integer
        C = C + 1 'Inicializando
        If C = 1 Then
            DineroPTB.Visible = False

        ElseIf C = 2 Then
            DineroPTB.Visible = True


        ElseIf C = 3 Then
            DineroPTB.Visible = False

        ElseIf C = 4 Then
            DineroPTB.Visible = True

        Else : C = 5
            C = 0


        End If
    End Sub
End Class