using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectScript : MonoBehaviour
{
    bool selected = false;
    EquipScript equipScript;
    BuyScript buyScript;


    //hat = 1, tail = 2, glasses = 3
    public int item;
    public int num;

    private void Start()
    {
        equipScript = GameObject.Find("Equipper").GetComponent<EquipScript>();
        buyScript = transform.parent.GetComponentInChildren<BuyScript>();
    }

    public void onClick()
    {
        if (!buyScript.getIsBought())
        {
            return;
        }
        if (selected)
        {
            GetComponent<Image>().color = new Color(0.1686275f, 0.8274511f, 0.5764706f, 0);
            selected = false;
            equipScript.selectItem(item, 0);
        }
        else
        {
            if (equipScript.selectItem(item, num))
            {
                GetComponent<Image>().color = new Color(0.1686275f, 0.8274511f, 0.5764706f, 0.36f);
                selected = true;
            }
        }
        
    }
}
