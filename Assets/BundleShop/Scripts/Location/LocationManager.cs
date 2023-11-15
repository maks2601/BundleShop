using System;
using BundleShop.Core;

namespace BundleShop.Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        public event Action<string> LocationChanged;

        public const string DEFAULT_LOCATION = "Default";

        private string _location = DEFAULT_LOCATION;
        
        public string Location
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