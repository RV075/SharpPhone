namespace SharpPhone
{
    public class ClassSmartPhone
    {
        public int Id { get; set; }
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public int StorageSizeMb { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public ClassSmartPhone() { }

        public ClassSmartPhone(int id, string brand, string model, int storageSizeMb, decimal price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            StorageSizeMb = storageSizeMb;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }
    }
}