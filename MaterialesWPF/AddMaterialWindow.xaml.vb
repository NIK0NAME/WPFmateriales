Public Class AddMaterialWindow
    Public mode As AddMaterialModel
    Private Sub AddMaterialWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        mode = New AddMaterialModel(Module1.db)
        Me.DataContext = mode
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        mode.nuevoMaterial()
        Me.Close()
    End Sub
End Class
