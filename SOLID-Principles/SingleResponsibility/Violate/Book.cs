using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SingleResponsibility.Violate
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; } // 2026
        public Book(int id, string name, string author, decimal price, int year) { 
            Id = id;
            Name = name;
            Author = author;
            Price = price;
            Year = year;
        }
    }
}
