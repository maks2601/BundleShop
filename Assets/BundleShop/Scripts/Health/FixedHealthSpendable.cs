using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Health
{
    [Serializable]
    public class FixedHealthSpendable : ISpendable
    {
        [SerializeField] private int _health;
        
        public void Spend()
        {
            HealthManager.Instance.Health -= _health;
        }

        public bool IsSpendable
        {
            get
            {
                return HealthManager.Instance.Health >= _health;
            }
        }
    }
}