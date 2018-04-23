using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using System.Windows;

namespace DXSchedulingRibbon {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
        }
        #region #About_ItemClick
        void About_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            DXMessageBox.Show(@"This example demonstrates how to customize the WPF Scheduler's integrated ribbon UI. Use the Scheduler's RibbonActions collection to create, remove or modify ribbon elements.",
                "Scheduler Ribbon Example", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        #endregion #About_ItemClick
    }
}
