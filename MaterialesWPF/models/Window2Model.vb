

Imports System.ComponentModel

Public Class Window2Model
    Implements INotifyPropertyChanged

    Private mActual As materiales

    Public Event PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub

    Public Property MaterialActual() As materiales
        Set(value As materiales)
            mActual = value

        End Set
        Get
            Return mActual
        End Get
    End Property

    Public ReadOnly Property Prestado() As Boolean
        Get
            Return mActual.estados.descri.Equals("prestado")
        End Get
    End Property

    Public ReadOnly Property Disponible() As Boolean
        Get
            Return mActual.estados.descri.Equals("disponible")
        End Get
    End Property

    Public Sub New(mSel As materiales)
        mActual = mSel

    End Sub

    Public Sub prestar()
        mActual.estado = 1

        Dim id As Integer = 1
        If Module1.db.movimientos.Count > 0 Then
            id = Module1.db.movimientos.Max(Function(x) x.idMovimiento) + 1
        End If
        Dim itm As New movimientos '= Module1.db.movimientos.FirstOrDefault(Function(x) x.idMovimiento = id)
        itm.idMovimiento = id
        itm.idMaterial = mActual.idMaterial
        itm.accion = 1
        itm.fecha = Date.Now
        Module1.db.movimientos.Add(itm)
        Module1.db.SaveChanges()
        Me.OnPropertyChanged(New PropertyChangedEventArgs("MaterialActual"))
        OnPropertyChanged(New PropertyChangedEventArgs("Prestado"))
        OnPropertyChanged(New PropertyChangedEventArgs("Disponible"))
    End Sub

    Public Sub devolver()
        mActual.estado = 2
        Dim id As Integer = 1
        If Module1.db.movimientos.Count > 0 Then
            id = Module1.db.movimientos.Max(Function(x) x.idMovimiento) + 1
        End If
        Dim itm As New movimientos '= Module1.db.movimientos.FirstOrDefault(Function(x) x.idMovimiento = id)
        itm.idMovimiento = id
        itm.idMaterial = mActual.idMaterial
        itm.accion = 2
        itm.fecha = Date.Now
        Module1.db.movimientos.Add(itm)
        Module1.db.SaveChanges()
        Me.OnPropertyChanged(New PropertyChangedEventArgs("MaterialActual"))
        OnPropertyChanged(New PropertyChangedEventArgs("Prestado"))
        OnPropertyChanged(New PropertyChangedEventArgs("Disponible"))
    End Sub

End Class
