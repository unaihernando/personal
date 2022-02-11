Public Class Jokalaria
    Public Izena As String
    Public Erasoa As Integer
    Public Bizia As Integer
    Public Dirua As Integer
    Public Items As Dictionary(Of String, Integer)
    Public Nibela As Integer

    Sub New(izena As String, eraso As Integer, bizia As Integer, dirua As Integer,
           items As Dictionary(Of String, Integer), nibela As Integer)

        Me.Izena = izena
        Me.Erasoa = eraso
        Me.Bizia = bizia
        Me.Dirua = dirua
        Me.Items = items
        Me.Nibela = nibela

    End Sub

    Public Property Nibela1 As Integer
        Get
            Return Nibela
        End Get
        Set(value As Integer)
            Nibela = value
        End Set
    End Property

    Public Property Items1 As Dictionary(Of String, Integer)
        Get
            Return Items
        End Get
        Set(value As Dictionary(Of String, Integer))
            Items = value
        End Set
    End Property

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
