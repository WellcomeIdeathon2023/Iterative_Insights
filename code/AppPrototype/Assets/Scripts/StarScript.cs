using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StarScript : MonoBehaviour
{
    public Sprite empty;
    public Sprite full;

    bool selected = false;

    StarController starController;

    public int myNum;

    void Start()
    {
        starController = transform.parent.GetComponent<StarController>();
    }

    public void onClick()
    {
        starController.updateStars(myNum);
    }

    public void ResetStar()
    {
        selected = false;
        GetComponent<Image>().sprite = empty;
    }

    public void select()
    {
        GetComponent<Image>().sprite = full;
    }
}
