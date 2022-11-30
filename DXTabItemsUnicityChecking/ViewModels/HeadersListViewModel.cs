using DXTabItemsUnicityChecking.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DXTabItemsUnicityChecking.ViewModels
{
    public class HeadersListViewModel : ViewModelBase
    {
        public HeadersListViewModel(List<Header> headers)
        {
            Headers = new ObservableCollection<Header>(headers);
        }

        private ObservableCollection<Header> headers;

        public ObservableCollection<Header> Headers
        {
            get => headers;
            set => SetProperty(ref headers, value);
        }
    }
}
