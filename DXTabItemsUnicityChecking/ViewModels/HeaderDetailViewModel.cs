using DXTabItemsUnicityChecking.Models;

namespace DXTabItemsUnicityChecking.ViewModels
{
    public class HeaderDetailViewModel : ViewModelBase
    {
        public HeaderDetailViewModel(Header header)
        {
            Header = header;
        }

        private Header header;

        public Header Header
        {
            get => header;
            set => SetProperty(ref header, value);
        }
    }
}
