using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_5
{
    class Goods
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PackingDate { get; set; }

        public Goods(int price, string name, string packingDate, string description)
            : base(price, name, packingDate, description)
        {
            Price = price;
            Name = name;
            Description = description;
            PackingDate = packingDate;
        }
    }
}