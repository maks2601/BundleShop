using System;
using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Location
{
    [Serializable]
    public class LocationSpendable : ISpendable
    {
        [SerializeField] private LocationType _location;
        
        public void Spend()
        {
            LocationManager.Instance.Location = _location;
        }

        public bool IsSpendable
        {
            get
            {
                return _location != LocationManager.Instance.Location;
            }
        }
    }
}