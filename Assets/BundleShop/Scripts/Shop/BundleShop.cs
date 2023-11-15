using System.Collections.Generic;
using UnityEngine;

namespace BundleShop.Shop
{
    public class BundleShop : MonoBehaviour
    {
        [SerializeField] private BundleView _bundlePrefab;
        [SerializeField] private List<BundleSO> _bundlesData;

        private readonly List<BundleView> _bundles = new();
        
        private void Start()
        {
            foreach (BundleSO bundleData in _bundlesData)
            {
                BundleView bundle = Instantiate(_bundlePrefab, transform);
                bundle.Initialize(bundleData);
                _bundles.Add(bundle);
            }
        }

        private void Update()
        {
            foreach (BundleView bundle in _bundles)
            {
                bundle.UpdateBundleAvailability();
            }
        }
    }
}