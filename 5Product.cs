using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_5
{
    class Product : Goods
    {
        public int ExpirationDate;
        public int Number; //Кількість продукту
        public string Unit; //Кількість вимірювання

        public Product(int price, string name, string packingDate, string description, int expirationDate, int number, string unit)
            : base(price, name, packingDate, description)
        {
            ExpirationDate = expirationDate;
            Number = number;
            Unit = unit;
        }
    }
}
