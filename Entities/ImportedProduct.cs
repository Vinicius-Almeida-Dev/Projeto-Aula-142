using System.Globalization;


namespace Projeto_Aula_142.Entities
{
    internal class ImportedProduct : Product
    {
        public double  customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            this.customsFee = customsFee;
        }

        public double TotalPrice() { return Price + customsFee; }

        public override string ToString()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
