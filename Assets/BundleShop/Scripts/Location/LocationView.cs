using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BundleShop.Location
{
    public class LocationView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _locationText;
        [SerializeField] private Button _setDefaultLocationButton;

        private void OnEnable()
        {
            _setDefaultLocationButton.onClick.AddListener(SetDefaultLocation);
            LocationManager.Instance.LocationChanged += SetLocation;
            SetLocation(LocationManager.Instance.Location);
        }

        private void SetLocation(string location)
        {
            _locationText.SetText(location);
        }

        private void SetDefaultLocation()
        {
            LocationManager.Instance.Location = LocationManager.DEFAULT_LOCATION;
        }
        
        private void OnDisable()
        {
            _setDefaultLocationButton.onClick.RemoveListener(SetDefaultLocation);
            LocationManager.Instance.LocationChanged -= SetLocation;
        }
    }
}