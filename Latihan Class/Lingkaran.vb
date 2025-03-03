Public Class Lingkaran
    Public jari_jari As Single
    Const phi = 3.14
    Public Function luaslingkaran() As Double
        Dim hasil As Double
        hasil = phi * jari_jari * jari_jari
        Return hasil
    End Function
    Public Function kelilinglingkaran() As Double
        Return 2 * phi * jari_jari
    End Function
End Class
