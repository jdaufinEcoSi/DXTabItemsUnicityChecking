using System;

namespace DXTabItemsUnicityChecking.Models
{
    public class Line
    {
        public Line(int id)
        {
            Id = id;
            Hash = Guid.NewGuid().ToString();
        }

        public int Id { get; set; }

        public string Hash { get; set; }
    }
}
