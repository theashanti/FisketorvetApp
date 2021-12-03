namespace FisketorvetApp.Models

// Martin

{
    public class Shoes : Clothes
    {
        public int Size { get; set; }
        
        public Shoes(int id, string name, int price, string gender, string color, int size) 
                   : base(id, name, price, gender, color)
        {
            Size = size;
        }
    }
}