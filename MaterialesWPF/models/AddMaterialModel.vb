Imports System.ComponentModel
Public Class AddMaterialModel
    Private _marca As String
    Private _desc As String
    Public dbCon As seimEntities
    Public WriteOnly Property Marca() As String
        Set(v As String)
            _marca = v
        End Set
    End Property

    Public WriteOnly Property Desc() As String
        Set(v As String)
            _desc = v
        End Set
    End Property

    Public Sub New(db As seimEntities)
        dbCon = db
    End Sub

    Public Sub nuevoMaterial()
        Dim m As New materiales
        Dim id As Integer = 1
        If dbCon.materiales.Count > 0 Then
            id = dbCon.materiales.Max(Function(x) x.idMaterial) + 1
        End If
        'm = dbCon.materiales.FirstOrDefault(Function(x) x.idMaterial = id)
        m.idMaterial = id
        m.marca = _marca
        m.descri = _desc
        m.estado = 2
        dbCon.materiales.Add(m)
        dbCon.SaveChanges()
    End Sub

End Class
