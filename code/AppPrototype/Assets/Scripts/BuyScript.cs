using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyScript : MonoBehaviour
{
    public ShopScript shopScript;
    
    bool isBought = false;

    private void Start()
    {
        shopScript = GameObject.Find("ShopController").GetComponent<ShopScript>();
        GetComponentInChildren<TMPro.TextMeshProUGUI>().text = Random.Range(30, 100).ToString();
    }

    public bool getIsBought()
    {
        return isBought;
    }

    // Start is called before the first frame update
    public void onClick()
    {
        Debug.Log(GetComponentInChildren<TMPro.TextMeshProUGUI>().text);

        if (shopScript.canBuy(int.Parse(GetComponentInChildren<TMPro.TextMeshProUGUI>().text)))
        {
            //Hide this game object
            gameObject.SetActive(false);
            isBought = true;
        }
    }
}
