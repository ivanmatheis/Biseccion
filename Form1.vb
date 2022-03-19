﻿Imports info.lundin.math
Public Class Biseccion
    Dim a As Single
    Dim b As Single
    Dim c As Integer
    Dim x(50) As Single
    Dim err(50) As Single
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer
    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.values.Clear()
        parser.values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        x(i) = (a + b) / 2
        err(i) = 1
        Do While err(i) > ec
            If f(a) * f(x(i)) < 0 Then
                b = x(i)
            Else
                a = x(i)
            End If
            i = i + 1
            x(i) = (a + b) / 2
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon), Math.Round(b, redon),
Math.Round(f(a), redon), Math.Round(f(x(i)), redon), Math.Round(f(b), redon), Math.Round(err(i), redon))
        Loop
        tr.Text = Math.Round(x(i), redon)
    End Sub

    Private Sub LImpiar_Click(sender As Object, e As EventArgs) Handles LImpiar.Click
        tf.Clear()
        ta.Clear()
        tb.Clear()
        tc.Clear()
        tr.Clear()
        Salida.Rows.Clear()
    End Sub

    Private Sub tr_Click(sender As Object, e As EventArgs) Handles tr.Click

    End Sub
End Class