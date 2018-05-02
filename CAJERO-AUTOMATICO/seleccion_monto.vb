Public Class seleccion_monto
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form4.Show()
        Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form3.Show()
        Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Timer1.Enabled = True
        Timer2.Enabled = False
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

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Static C As Integer
        C = C + 1 'Inicializando
        If C = 1 Then
            PTB_100Pesos.Visible = False

        ElseIf C = 2 Then
            PTB_100Pesos.Visible = True


        ElseIf C = 3 Then
            PTB_100Pesos.Visible = False

        ElseIf C = 4 Then
            PTB_100Pesos.Visible = True

        Else : C = 5
            C = 0

        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'Timer3.Enabled = True
        'Timer2.Enabled = False
        'Timer1.Enabled = False

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'Static C As Integer
        'C = C + 1 'Inicializando
        'If C = 1 Then
        '    PTB_100Pesos.Visible = True

        'ElseIf C = 2 Then
        '    DineroPTB.Visible = True


        'ElseIf C = 3 Then
        '    PTB_100Pesos.Visible = False

        'ElseIf C = 4 Then
        '    PTB_100Pesos.Visible = False

        'Else : C = 5
        '    C = 0

        'End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()


    End Sub
End Class