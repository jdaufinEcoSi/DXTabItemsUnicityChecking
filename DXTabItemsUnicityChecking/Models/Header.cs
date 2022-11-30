using System;
using System.Collections.Generic;

namespace DXTabItemsUnicityChecking.Models
{
    public class Header
    {
        public Header(int id, string title)
        {
            Id = id;
            Title = title;
            CreationDate = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public string Title { get; set; }

        public List<Line> Lines { get; set; }
    }
}
