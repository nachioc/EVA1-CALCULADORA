Public Class Form1
    Dim operacion As String
    Dim valor1 As Double
    Dim valor2 As Double
    Dim resultado As Double

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim boton As Button = CType(sender, Button)
        txtDisplay.Text &= boton.Text
    End Sub

    Private Sub btnOperacion_Click(sender As Object, e As EventArgs) Handles btnSuma.Click, btnResta.Click, btnMult.Click, btnDiv.Click
        Dim boton As Button = CType(sender, Button)
        valor1 = Val(txtDisplay.Text)
        operacion = boton.Text
        txtDisplay.Clear()
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        valor2 = Val(txtDisplay.Text)

        Select Case operacion
            Case "+"
                resultado = valor1 + valor2
            Case "-"
                resultado = valor1 - valor2
            Case "*"
                resultado = valor1 * valor2
            Case "/"
                If valor2 = 0 Then
                    MessageBox.Show("No se puede dividir entre cero")
                    Exit Sub
                End If
                resultado = valor1 / valor2
        End Select

        txtDisplay.Text = resultado.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Clear()
        valor1 = 0
        valor2 = 0
        operacion = ""
    End Sub
End Class