Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Ribbon
Imports System.Windows

Namespace DXSchedulingRibbon
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXRibbonWindow

        Public Sub New()
            InitializeComponent()
        End Sub
        #Region "#About_ItemClick"
        Private Sub About_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            DXMessageBox.Show("This example demonstrates how to customize the WPF Scheduler's integrated ribbon UI. Use the Scheduler's RibbonActions collection to create, remove or modify ribbon elements.", "Scheduler Ribbon Example", MessageBoxButton.OK, MessageBoxImage.Information)
        End Sub
        #End Region ' #About_ItemClick
    End Class
End Namespace
