using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Health
{
    [Serializable]
    public class FixedHealthReward : IReward
    {
        [SerializeField] private int _health;
        
        public void Reward()
        {
            HealthManager.Instance.Health += _health;
        }
    }
}