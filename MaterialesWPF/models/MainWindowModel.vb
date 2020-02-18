

Imports System.ComponentModel

Public Class MainWindowModel
    Implements INotifyPropertyChanged

    Private liMateriales As List(Of materiales)

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub

    Public ReadOnly Property ListaMateriales() As List(Of materiales)
        Get
            Return liMateriales
        End Get
    End Property


    Public Sub New(m As String)
        liMateriales = Module1.db.materiales.Select(Function(u) u).ToList()
    End Sub

    Public Sub updateLista()
        liMateriales = Module1.db.materiales.Select(Function(u) u).ToList()
        OnPropertyChanged(New PropertyChangedEventArgs("ListaMateriales"))
    End Sub


End Class
