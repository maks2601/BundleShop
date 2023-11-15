using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Location
{
    [Serializable]
    public class LocationReward : IReward
    {
        [SerializeField] private LocationType _location;
        
        public void Reward()
        {
            LocationManager.Instance.Location = _location;
        }
    }
}