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
            int healthSpend = Mathf.CeilToInt(HealthManager.Instance.Health * _healthPercent / 100f);
            HealthManager.Instance.Health -= healthSpend;
        }

        public bool IsSpendable
        {
            get
            {
                int healthSpend = Mathf.CeilToInt(HealthManager.Instance.Health * _healthPercent / 100f);
                return HealthManager.Instance.Health > healthSpend;
            }
        }
    }
}