using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackButtonScript : MonoBehaviour
{
    
    StarController starController;
    public GameObject sController;
    public GameObject textBox;

    private void Start()
    {
        starController = sController.GetComponent<StarController>();
    }

    public void onClick()
    {
        starController.ResetStars();
        textBox.GetComponent<TMPro.TMP_InputField>().text = "";
    }


}
