using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShopScript : MonoBehaviour
{
    int coins = 500;

    private void Start()
    {
        GetComponentInChildren<TMPro.TextMeshProUGUI>().text = coins.ToString();
    }

    public bool canBuy(int cost)
    {
        if (coins >= cost)
        {
            coins -= cost;
            GetComponentInChildren<TMPro.TextMeshProUGUI>().text = coins.ToString();
            return true;
        }
        else
        {
            return false;
        }
    }
}
