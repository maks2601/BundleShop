using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BundleShop.Shop
{
    public class BundleView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _bundleNameText;
        [SerializeField] private Button _buyButton;

        private BundleSO _bundleData;
        
        public void Initialize(BundleSO bundleData)
        {
            _bundleData = bundleData;
            _bundleNameText.SetText(_bundleData.bundleName);
            _buyButton.onClick.AddListener(BuyBundle);
        }

        private void BuyBundle()
        {
            _bundleData.spendable.Spend();
            _bundleData.reward.Reward();
        }

        public void UpdateBundleAvailability()
        {
            _buyButton.interactable = _bundleData.spendable.IsSpendable;
        }
    }
}