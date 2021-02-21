namespace CSharpHeritage.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomFee { get; protected set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price += CustomFee;
        }
        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + $" (Customs fee: $ {CustomFee})";
        }
    }
}