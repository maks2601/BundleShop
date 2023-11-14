using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BundleShop.Gold
{
    public class GoldView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _goldText;
        [SerializeField] private Button _increaseGoldButton;

        private void OnEnable()
        {
            _increaseGoldButton.onClick.AddListener(IncreaseGold);
            GoldManager.Instance.GoldChanged += SetGold;
            SetGold(GoldManager.Instance.Gold);
        }

        private void SetGold(int gold)
        {
            _goldText.SetText(gold.ToString());
        }

        private void IncreaseGold()
        {
            GoldManager.Instance.Gold++;
        }
        
        private void OnDisable()
        {
            _increaseGoldButton.onClick.RemoveListener(IncreaseGold);
            GoldManager.Instance.GoldChanged -= SetGold;
        }
    }
}