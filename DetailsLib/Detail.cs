global using System.Reflection;
global using DetailsLib;
using System.ComponentModel.DataAnnotations;

namespace DetailsLib
{
    public class Detail
    {
        public Detail(string model, string manuf, double price, string intchab)
        {
            Model = model;
            Manufacturer = manuf;
            Price = price;
            Interchangeability = intchab;
        }

        [Key]
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Interchangeability { get; set; }

        public virtual string GetShortDetailType() => "Деталь";
    }
}