using System;
using BundleShop.Core;

namespace BundleShop.Health
{
    public class HealthManager : Singleton<HealthManager>
    {
        public event Action<int> HealthChanged; 

        private int _health;
        
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                HealthChanged?.Invoke(_health);
            }
        }
    }
}