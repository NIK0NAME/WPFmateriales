
Class MainWindow
    Dim windowModel As MainWindowModel

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        windowModel = New MainWindowModel("app loaded")
        Me.DataContext = windowModel
        add_button.IsEnabled = True
    End Sub

    Private Sub ListBox_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        If liMats.Items.Count > 0 Then
            Dim m As materiales = liMats.SelectedItem

            Dim model2 As New Window2Model(m)
            Dim f2 As New Window1(model2)
            f2.ShowDialog()
            windowModel.updateLista()
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim f3 As New AddMaterialWindow()
        f3.ShowDialog()
        windowModel.updateLista()
    End Sub

    Private Sub LiMats_MouseRightButtonUp(sender As Object, e As MouseButtonEventArgs) Handles liMats.MouseRightButtonUp

        If liMats.Items.Count > 0 Then
            windowModel.removeMaterial(liMats.SelectedItem)
        End If
    End Sub
End Class
