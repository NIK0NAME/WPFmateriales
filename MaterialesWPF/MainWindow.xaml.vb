﻿
Class MainWindow
    Dim windowModel As MainWindowModel

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        windowModel = New MainWindowModel("app loaded")
        Me.DataContext = windowModel
    End Sub

    Private Sub ListBox_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        Dim m As materiales = liMats.SelectedItem

        Dim model2 As New Window2Model(m)
        Dim f2 As New Window1(model2)
        f2.ShowDialog()
        windowModel.updateLista()
    End Sub
End Class
