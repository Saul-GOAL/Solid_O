namespace Solid_O
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    
    }

    public class Drink
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }

    public class Invoice
    {
        //public decimal GetTotal(IEnumerable<Drink> lstDrink)
        //{
        //    decimal total = 0;
        //    foreach (var drink in lstDrink)
        //    {
        //        if (drink.Type == "Water")
        //            total += drink.Price;
        //        else if (drink.Type == "Sugar")
        //            total += drink.Price * 0.033m;
        //        else if (drink.Type == "Alcohol")
        //            total *= drink.Price * 0.16m;
        //        //New drink Type...
        //        else if (drink.Type == "Energy")
        //            total *= drink.Price * 0.25m;
        //    }
        //    return total;
        //}
        public decimal GetTotal(IEnumerable<IDrink> lstDrink)
        {
            decimal total = 0;
            foreach (var drink in lstDrink)
            {
                total += drink.GetPrice();
            }
            return total;
        }
    }

    public interface IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Invoice { get; set; }

        public decimal GetPrice();
    }

    public class Water : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Invoice { get; set; }
        public decimal GetPrice()
        {
                return Price * Invoice;   
        }
    }
    public class Alcohol : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Invoice { get; set; }
        public decimal Promo { get; set; }  
        public decimal GetPrice()
        {
            return (Price * Invoice) - Promo;
        }
    }
    public class Sugar : IDrink
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Invoice { get; set; }
        public decimal Expiration { get; set; }
        public decimal GetPrice()
        {
            return (Price * Invoice) - Expiration;
        }
    }
}