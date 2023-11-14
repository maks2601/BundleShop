using System;
using BundleShop.Core;

namespace BundleShop.Gold
{
    public class GoldManager : Singleton<GoldManager>
    {
        public event Action<int> GoldChanged; 

        private int _gold;
        
        public int Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                GoldChanged?.Invoke(_gold);
            }
        }
    }
}