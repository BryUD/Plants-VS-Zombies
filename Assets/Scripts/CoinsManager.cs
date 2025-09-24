using UnityEngine;
using UnityEngine.Events;

public class CoinsManager : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<string> onCoinsChanged;
    private int numberOfcoins = 0;

    public void SetNumberOfCoins(int amount)
    {
        numberOfcoins = amount;
        onCoinsChanged.Invoke(numberOfcoins.ToString());
    }

    public bool CanBuy(int cost)
    {
        if (numberOfcoins >= cost)
        {
            SetNumberOfCoins(numberOfcoins - cost);
            return true;
        }
        return false;
    }

    public void AddCoins(int amount)
    {
        SetNumberOfCoins(numberOfcoins + amount);
    }
}

   


