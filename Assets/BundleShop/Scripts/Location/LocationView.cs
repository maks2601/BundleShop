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

        private void SetLocation(LocationType locationType)
        {
            _locationText.SetText(locationType.ToString());
        }

        private void SetDefaultLocation()
        {
            LocationManager.Instance.Location = LocationType.DEFAULT;
        }
        
        private void OnDisable()
        {
            _setDefaultLocationButton.onClick.RemoveListener(SetDefaultLocation);
            LocationManager.Instance.LocationChanged -= SetLocation;
        }
    }
}