namespace InputOutDemo
{
    enum Category { Toys, Fashion, Electrical, Civil }
    enum Manufacturing { Local, International }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public Manufacturing Manufacturing { get; set; }
        public Date ExpiringDate { get; set; }

        public Product()
        {
            Id = 101;
            Name = "Product 1";
            Company = "Company A";
            Price = 100.00m;
            Category = Category.Toys;
            Manufacturing = Manufacturing.Local;
            ExpiringDate = new Date(2022, 12, 31);
        }

        public Product(int id, string name, string company, decimal price, Category category, Manufacturing manufacturing, Date expiringDate)
        {
            Id = id;
            Name = name;
            Company = company;
            Price = price;
            Category = category;
            Manufacturing = manufacturing;
            ExpiringDate = expiringDate;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Company: " + Company + ", Price: " + Price + ", Category: " + Category + ", Manufacturing: " + Manufacturing + ", Expiring Date: " + ExpiringDate;
        }
    }
}