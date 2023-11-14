using BundleShop.Core;
using UnityEngine;

namespace BundleShop.Shop
{
    [CreateAssetMenu(fileName = "Bundle", menuName = "BundleShop/Bundle", order = 1)]
    public class BundleSO : ScriptableObject
    {
        [SerializeReference] public ISpendable spendable;
        [SerializeReference] public IReward reward;
    }
}