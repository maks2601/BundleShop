using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Health
{
    [Serializable]
    public class PercentHealthSpendable : ISpendable
    {
        [SerializeField] private int _healthPercent;
        
        public void Spend()
        {
            int healthSpend = HealthManager.Instance.Health * _healthPercent / 100;
            HealthManager.Instance.Health -= healthSpend;
        }

        public bool IsSpendable
        {
            get
            {
                int healthSpend = HealthManager.Instance.Health * _healthPercent / 100;
                return HealthManager.Instance.Health >= healthSpend;
            }
        }
    }
}