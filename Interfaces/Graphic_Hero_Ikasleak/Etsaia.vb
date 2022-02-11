Public Class Etsaia
    Public Izena As String
    Public Erasoa As Integer
    Public Bizia As Integer
    Public Dirua As Integer

    Sub New(izena As String, erasoa As Integer, bizia As Integer, dirua As Integer)

        Me.Izena = izena
        Me.Erasoa = erasoa
        Me.Bizia = bizia
        Me.Dirua = dirua

    End Sub

    Public Property Izena1 As String
        Get
            Return Izena
        End Get
        Set(value As String)
            Izena = value
        End Set
    End Property

    Public Property Erasoa1 As Integer
        Get
            Return Erasoa
        End Get
        Set(value As Integer)
            Erasoa = value
        End Set
    End Property

    Public Property Bizia1 As Integer
        Get
            Return Bizia
        End Get
        Set(value As Integer)
            Bizia = value
        End Set
    End Property

    Public Property Dirua1 As Integer
        Get
            Return Dirua
        End Get
        Set(value As Integer)
            Dirua = value
        End Set
    End Property
End Class
