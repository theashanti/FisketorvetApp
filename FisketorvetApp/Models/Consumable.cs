namespace FisketorvetApp.Models

// Martin

{
    public class Consumable : AItem
    {
        public string Size { get; set; }

        public Consumable(int id, string name, int price, string size, string storeName) : base(id, name, price, storeName)
        {
            Size = size;
        }
    }
}