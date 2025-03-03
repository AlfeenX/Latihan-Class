Public Class Form1
    Dim lingkar As New Lingkaran
    Dim tabung As New Tabung
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With lingkar
            .jari_jari = TextBox1.Text
            TextBox2.Text = .luaslingkaran()
            TextBox3.Text = .kelilinglingkaran()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With tabung
            .jari_jari = TextBox6.Text
            .Tinggi = TextBox5.Text
            TextBox4.Text = .volumetabung()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class
