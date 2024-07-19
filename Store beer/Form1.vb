Public Class Form1
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Const AngkorBeer As Integer = 4500
        Const CambodiaBeer As Integer = 4300
        Const ABCBeer As Integer = 6000
        Const TigarBeer As Integer = 5000
        Const CrownBeer As Integer = 3000
        Dim sum As Integer
        If CheckBox1.Checked = True Then
            sum = sum + AngkorBeer
        End If
        If CheckBox2.Checked = True Then
            sum = sum + CambodiaBeer
        End If
        If CheckBox3.Checked = True Then
            sum = sum + ABCBeer
        End If
        If CheckBox4.Checked = True Then
            sum = sum + TigarBeer
        End If
        If CheckBox5.Checked = True Then
            sum = sum + CrownBeer
        End If
        Label7.Text = sum.ToString("c")

    End Sub
End Class
