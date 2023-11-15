using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Gold
{
    [Serializable]
    public class GoldSpendable : ISpendable
    {
        [SerializeField] private int _gold;
        
        public void Spend()
        {
            GoldManager.Instance.Gold -= _gold;
        }

        public bool IsSpendable
        {
            get
            {
                return GoldManager.Instance.Gold >= _gold;
            }
        }
    }
}