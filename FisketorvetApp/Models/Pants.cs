namespace FisketorvetApp.Models

// Martin

{
    public class Pants : Clothes
    {
        public int Waist { get; set; }
        public int Length { get; set; }
        
        public Pants(int id, string name, int price, string gender, string color, int waist, int length) 
                   : base(id, name, price, gender, color)
        {
            Waist = waist;
            Length = length;
        }
    }
}