namespace FisketorvetApp.Models

// Martin

{
    public class Clothes : AItem
    {
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        
        public Clothes(int id, string name, int price, string gender, string color, string type, string size, string storeName) : base(id, name, price, storeName)
        {
            Gender = gender;
            Color = color;
            Size = size;
            Type = type;
        }
    }
}