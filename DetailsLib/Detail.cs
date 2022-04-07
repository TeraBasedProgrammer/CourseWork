global using DetailsLib;
namespace DetailsLib
{
    public abstract class Detail
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Interchangeability { get; set; }

        public Detail()
        {
            Model = "Undefined";
            Manufacturer = "Undefined";
            Price = 0;
            Interchangeability = "Undefined";
        }

        public Detail(string model, string manuf, double price, string intchab)
        {
            Model = model;
            Manufacturer = manuf;
            Price = price;
            Interchangeability = intchab;
        }
        public virtual string[] GetClassData()
        {
            // Возвращать название класса и поля

            return null;
        }

    }
}