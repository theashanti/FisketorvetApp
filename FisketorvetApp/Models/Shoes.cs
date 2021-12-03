namespace FisketorvetApp.Models

// Martin

{
    public class Shoes : Clothes
    {
        public int Size { get; set; }
        
        public Shoes(int id, string name, int price, string gender, string color, int size, string storeName) 
                   : base(id, name, price, gender, color, storeName)
        {
            Size = size;
        }
    }
}