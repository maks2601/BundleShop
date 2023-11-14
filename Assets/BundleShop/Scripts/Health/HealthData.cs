using System;
using BundleShop.Core;

namespace BundleShop.Health
{
    [Serializable]
    public class HealthData : ISpendable, IReward
    {
        public int health;
    }
}