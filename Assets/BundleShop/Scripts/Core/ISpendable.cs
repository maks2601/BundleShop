namespace BundleShop.Core
{
    public interface ISpendable
    {
        public void Spend();

        public bool IsSpendable { get; }
    }
}
