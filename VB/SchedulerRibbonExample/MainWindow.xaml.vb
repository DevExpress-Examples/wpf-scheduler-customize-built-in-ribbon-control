Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace DXSchedulingRibbon

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub About_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            DXMessageBox.Show("This example demonstrates how to customize the WPF Scheduler's integrated ribbon UI. Use the Scheduler's RibbonActions collection to create, remove or modify ribbon elements.", "Scheduler Ribbon Example", MessageBoxButton.OK, MessageBoxImage.Information)
        End Sub
    End Class
End Namespace
