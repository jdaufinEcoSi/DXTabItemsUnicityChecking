using DXTabItemsUnicityChecking.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DXTabItemsUnicityChecking.ViewModels
{
    public class MasterAndDetailTabsViewModel : ViewModelBase
    {
        public MasterAndDetailTabsViewModel()
        {
            TabItems = new ObservableCollection<ViewModelBase>();
        }

        private ObservableCollection<ViewModelBase> tabItems;

        public ObservableCollection<ViewModelBase> TabItems
        {
            get => tabItems;
            set => SetProperty(ref tabItems, value);
        }

        public void Initialize()
        {
            var dataset = Populate();
            var listViewModel = new HeadersListViewModel(dataset);
            TabItems.Add(listViewModel);
        }


        private static List<Header> Populate()
        {
            Header GenerateHeader(int index)
            {
                var header = new Header(index, $"Collection n°{index}");
                header.Lines = Enumerable.Range(1, 20)
                    .Select(i => new Line(i))
                    .ToList();

                return header;
            }

            return Enumerable.Range(1, 40).Select(i => GenerateHeader(i)).ToList();
        }
    }
}
