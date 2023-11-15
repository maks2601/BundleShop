using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Health
{
    [Serializable]
    public class PercentHealthReward : IReward
    {
        [SerializeField] private int _healthPercent;
        
        public void Reward()
        {
            int healthReward = Mathf.CeilToInt(HealthManager.Instance.Health * _healthPercent / 100f);
            HealthManager.Instance.Health += healthReward;
        }
    }
}