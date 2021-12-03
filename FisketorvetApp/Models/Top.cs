namespace FisketorvetApp.Models

// Martin

{
    public class Top : Clothes
    {
        public string Size { get; set; }
        
        public Top(int id, string name, int price, string gender, string color, string size, string storeName) 
                   : base(id, name, price, gender, color, storeName)
        {
            Size = size;
        }
    }
}