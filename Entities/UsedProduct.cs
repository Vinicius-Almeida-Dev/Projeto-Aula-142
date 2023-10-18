using System;
using System.Globalization;

namespace Projeto_Aula_142.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufactue date: {manufactureDate.ToString("dd/MM/yyyy")})";
        }

    }
}
