using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_5
{
    class Book : Goods
    {
        public string Author;
        public int NumberOfPage;
        public string PublishingHouse;

        public Book(int price, string name, string packingDate, string description, string author, int numberOfPage, string publishingHouse)
            : base(price, name, packingDate, description)
        {
            Author = author;
            NumberOfPage = numberOfPage;
            PublishingHouse = publishingHouse;
        }
    }
}
