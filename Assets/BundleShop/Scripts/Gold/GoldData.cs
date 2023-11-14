using System;
using BundleShop.Core;

namespace BundleShop.Gold
{
    [Serializable]
    public class GoldData : ISpendable, IReward
    {
        public int gold;
    }
}