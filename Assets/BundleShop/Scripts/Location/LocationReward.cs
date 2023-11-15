using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Location
{
    [Serializable]
    public class LocationReward : IReward
    {
        [SerializeField] private string _location;
        
        public void Reward()
        {
            LocationManager.Instance.Location = _location;
        }
    }
}