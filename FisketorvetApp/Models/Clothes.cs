namespace FisketorvetApp.Models

// Martin

{
    public class Clothes : AItem
    {
        public string Gender { get; set; }
        public string Color { get; set; }
        
        public Clothes(int id, string name, int price, string gender, string color) : base(id, name, price)
        {
            Gender = gender;
            Color = color;
        }
    }
}