
Imports MaterialesWPF.MaterialesWPF

Public Class MainWindowModel

    Private mensaje As String
    Private liMateriales As List(Of materiales)
    Dim db As New DAM_nikolayzabaleta_DEVEntities()
    Public Property Msg() As String
        Get
            Return mensaje
        End Get
        Set(value As String)
            mensaje = value
        End Set
    End Property

    Public ReadOnly Property ListaMateriales() As List(Of materiales)
        Get
            Return liMateriales
        End Get
    End Property


    Public Sub New(m As String)
        Msg = m
        liMateriales = db.materiales.Select(Function(u) u).ToList()
    End Sub

End Class
