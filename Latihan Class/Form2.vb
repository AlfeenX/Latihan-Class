Public Class Form2
    Dim perpan As New Persegipanjang
    Dim persegi As New Persegi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With perpan
            .p = TextBox1.Text
            .l = TextBox2.Text
            TextBox3.Text = .luaspersegipanjang()
            TextBox7.Text = .kelpersegipanjang()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With persegi
            .s = TextBox6.Text
            TextBox5.Text = .luaspersegi()
            TextBox4.Text = .kelpersegi()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class