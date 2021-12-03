namespace FisketorvetApp.Models

// Martin

{
    public abstract class AItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string StoreName { get; set; }

        public AItem(int id, string name, int price, string storeName)
        {
            Id = id;
            Name = name;
            Price = price;
            StoreName = storeName;
        }
    }
}