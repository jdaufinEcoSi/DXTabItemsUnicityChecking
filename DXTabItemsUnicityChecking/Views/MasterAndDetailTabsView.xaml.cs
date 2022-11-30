using DXTabItemsUnicityChecking.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DXTabItemsUnicityChecking.Views
{
    /// <summary>
    /// Interaction logic for MasterAndDetailTabsView.xaml
    /// </summary>
    public partial class MasterAndDetailTabsView : UserControl
    {
        private MasterAndDetailTabsViewModel viewModel => DataContext as MasterAndDetailTabsViewModel;

        public MasterAndDetailTabsView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.Initialize();
        }
    }
}
