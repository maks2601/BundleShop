using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Gold
{
    [Serializable]
    public class GoldReward : IReward
    {
        [SerializeField] private int _gold;
        
        public void Reward()
        {
            GoldManager.Instance.Gold += _gold;
        }
    }
}