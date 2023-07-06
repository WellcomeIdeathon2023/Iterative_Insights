using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    public GameObject[] stars;


    public void updateStars(int num)
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (i < num)
            {
                stars[i].GetComponent<StarScript>().select();
            }
            else
            {
                stars[i].GetComponent<StarScript>().ResetStar();
            }
        }
    }

    public void ResetStars()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].GetComponent<StarScript>().ResetStar();
        }
    }

}
