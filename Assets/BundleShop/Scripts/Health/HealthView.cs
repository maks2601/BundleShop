using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BundleShop.Health
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _healthText;
        [SerializeField] private Button _increaseHealthButton;

        private void OnEnable()
        {
            _increaseHealthButton.onClick.AddListener(IncreaseHealth);
            HealthManager.Instance.HealthChanged += SetHealth;
            SetHealth(HealthManager.Instance.Health);
        }

        private void SetHealth(int health)
        {
            _healthText.SetText(health.ToString());
        }

        private void IncreaseHealth()
        {
            HealthManager.Instance.Health++;
        }
        
        private void OnDisable()
        {
            _increaseHealthButton.onClick.RemoveListener(IncreaseHealth);
            HealthManager.Instance.HealthChanged -= SetHealth;
        }
    }
}