﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class seimEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=seimEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property acciones() As DbSet(Of acciones)
    Public Overridable Property estados() As DbSet(Of estados)
    Public Overridable Property materiales() As DbSet(Of materiales)
    Public Overridable Property movimientos() As DbSet(Of movimientos)

End Class
