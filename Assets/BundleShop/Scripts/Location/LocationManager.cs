using System;
using BundleShop.Core;

namespace BundleShop.Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        public event Action<LocationType> LocationChanged; 

        private LocationType _location;
        
        public LocationType Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                LocationChanged?.Invoke(_location);
            }
        }
    }
}