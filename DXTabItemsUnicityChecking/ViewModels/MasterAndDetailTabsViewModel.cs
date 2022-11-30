using DXTabItemsUnicityChecking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXTabItemsUnicityChecking.ViewModels
{
    public class MasterAndDetailTabsViewModel : ViewModelBase
    {
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
