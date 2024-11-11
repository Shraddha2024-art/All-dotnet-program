using System;

namespace Icomarable_Interface
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int quantity, decimal price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public int CompareTo(Product other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Quantity: {Quantity}, Price: {Price:C}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList products = new ArrayList();

            products.Add(new Product(3, "Product C", 10, 50m));
            products.Add(new Product(1, "Product A", 20, 30m));
            products.Add(new Product(4, "Product D", 5, 70m));
            products.Add(new Product(2, "Product B", 15, 40m));

            Console.WriteLine("Products:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            products.Sort();

            Console.WriteLine("\nSorted Products by Id:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadLine();
        }
    }
}