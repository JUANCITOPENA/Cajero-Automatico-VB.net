Public Class Bienvenido
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta Seguro que Desea Cansarla la Transaccion", "Cajero de Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmPrincipal_Click(sender As Object, e As EventArgs) Handles FrmPrincipal.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MessageBox.Show("Esta Seguro que Desea Cansarla la Transaccion", "Cajero de Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static C As Integer
        C = C + 1
        If C = 1 Then
            btnParpadeo.ForeColor = Color.White

        ElseIf C = 2 Then
            btnParpadeo.ForeColor = Color.YellowGreen


        ElseIf C = 3 Then
            btnParpadeo.ForeColor = Color.Violet

        Else : C = 4
            C = 0
        End If

    End Sub
End Class