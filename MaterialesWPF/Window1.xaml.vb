Public Class Window1

    Public modelo As Window2Model

    Public Sub New(m As Window2Model)
        modelo = m
        Me.DataContext = modelo
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Window1_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        modelo.prestar()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        modelo.devolver()
    End Sub
End Class
