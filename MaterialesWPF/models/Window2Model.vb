Imports MaterialesWPF.MaterialesWPF

Public Class Window2Model

    Private mActual As materiales

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

End Class
