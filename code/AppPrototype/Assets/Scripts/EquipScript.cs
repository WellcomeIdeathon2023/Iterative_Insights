using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipScript : MonoBehaviour
{

    public int selectedHats = 0;
    public int selectedTails = 0;
    public int selectedGlasses = 0;

    public Sprite V0;
    public Sprite V1;
    public Sprite V2;
    public Sprite V3;
    public Sprite V4;
    public Sprite V5;
    public Sprite V6;


    // 1 = hat, 2 = tail, 3 = glasses

    public bool selectItem(int item, int num)
    {
        if (item == 1)
        {
            if (num != 0 && selectedHats != 0)
            {
                return false;
            }

            selectedHats = num;
        }
        if (item == 2)
        {
            if (num != 0 && selectedTails != 0)
            {
                return false;
            }

            selectedTails = num;
        }
        if (item == 3)
        {
            if (num != 0 && selectedGlasses != 0)
            {
                return false;
            }

            selectedGlasses = num;
        }
        return true;
    }

    public void onClick()
    {
        if (selectedGlasses == 0 && selectedHats == 0 && selectedTails == 0)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V0;
        }
        else if (selectedGlasses == 2 && selectedHats == 0 && selectedTails == 0)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V1;
        }
        else if (selectedGlasses == 0 && selectedHats == 4 && selectedTails == 4)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V2;
        }else if (selectedGlasses == 0 && selectedHats == 3 && selectedTails == 3)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V3;
        }
        else if (selectedGlasses == 0 && selectedHats == 2 && selectedTails == 2)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V4;
        }
        else if (selectedGlasses == 2 && selectedHats == 1 && selectedTails == 1)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V5;
        }
        else if (selectedGlasses == 1 && selectedHats == 0 && selectedTails == 0)
        {
            GameObject.Find("Ruffles").GetComponent<Image>().sprite = V6;
        }


    }
}
