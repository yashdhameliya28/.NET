using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Manual.lab_2
{
    internal class Furniture
    {
        public string material;
        public double price;

        public Furniture(){}

        public Furniture(string material, double price)
        {
            this.material = material;
            this.price = price;
        }
    }

    class Table : Furniture
    {
        public double height, surfaceArea;

        public Table(double height, double surfaceArea, string material, double price) : base(material,price) {
            
        this.height = height;
        this.surfaceArea = surfaceArea;
        }

        public void displayTableDetails()
        {
            Console.WriteLine($"Furniture meterial is {material}");
            Console.WriteLine($"Furniture price {price}");
            Console.WriteLine($"Table height {height}");
            Console.WriteLine($"Table surface area {surfaceArea}");

        }

    }
}
