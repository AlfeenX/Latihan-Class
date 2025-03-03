Public Class Tabung
    Public Tinggi As Single
    Public jari_jari As Single
    Const phi = 3.14
    Public Function volumetabung() As Double
        Return phi * (jari_jari * jari_jari) * Tinggi
    End Function
End Class
