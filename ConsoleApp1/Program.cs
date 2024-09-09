CustomConverter conv = new CustomConverter();
int a;
char b;
double c;
conv.Convert("123", out a);
conv.Convert("a", out b);
conv.Convert("1,2", out c);



Product[] products = { new Toys(19.99, false), new Meats(19.99, DateTime.Now), new Drinks(19.99, (float)1.5), new Tires(19.99, 42), new Cars(19.99, "A768XE") };
for (int i = 0; i < products.Length; i++) Console.WriteLine(products[i].GetInformation());



class CustomConverter
{
    internal void Convert(string input, out int output) { output = System.Convert.ToInt32(input); }
    internal void Convert(string input, out char output) { output = System.Convert.ToChar(input); }
    internal void Convert(string input, out double output) { output = System.Convert.ToDouble(input); }
}



abstract class Product
{
    virtual private protected double Price { get; set; }
    abstract internal string GetInformation();
}

class Toys : Product
{
    internal Toys(double price, bool is_for_boys)
    {
        Price = price;
        Is_for_boys = is_for_boys;
    }
    private protected bool Is_for_boys;
    override private protected double Price { get => base.Price; set => base.Price = value * 0.9; }
    internal override string GetInformation() => Convert.ToString(Price) + " " + Convert.ToString(Is_for_boys);
}
class Meats : Product
{
    internal Meats(double price, DateTime expiration_date)
    {
        Price = price;
        Expiration_date = expiration_date;
    }
    private protected DateTime Expiration_date;
    override private protected double Price { get => base.Price; set => base.Price = value * 0.95; }
    internal override string GetInformation() => Convert.ToString(Price) + " " + Convert.ToString(Expiration_date);
}
class Drinks : Product
{
    internal Drinks(double price, float volume)
    {
        Price = price;
        Volume = volume;
    }
    private protected float Volume;
    override private protected double Price { get => base.Price; set => base.Price = value * 0.85; }
    internal override string GetInformation() => Convert.ToString(Price) + " " + Convert.ToString(Volume);
}
class Tires : Product
{
    internal Tires(double price, int size)
    {
        Price = price;
        Size = size;
    }
    private protected int Size;
    override private protected double Price { get => base.Price; set => base.Price = value * 0.70; }
    internal override string GetInformation() => Convert.ToString(Price) + " " + Convert.ToString(Size);
}
class Cars : Product
{
    internal Cars(double price, string registration_plate)
    {
        Price = price;
        Registration_plate = registration_plate;
    }
    private protected string Registration_plate;
    override private protected double Price { get => base.Price; set => base.Price = value * 0.99; }
    internal override string GetInformation() => Convert.ToString(Price) + " " + Registration_plate;
}