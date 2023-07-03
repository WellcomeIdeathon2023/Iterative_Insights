using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TextInput : MonoBehaviour
{
    public GameObject chatView;


    //public TMP_InputField mainInputField;

    //// Checks if there is anything entered into the input field.
    //void LockInput(TMP_InputField input)
    //{
    //    if (input.text.Length > 0)
    //    {
    //        Debug.Log("Text has been entered");
    //    }
    //    else if (input.text.Length == 0)
    //    {
    //        Debug.Log("Main Input Empty");
    //    }
    //}

    //public void Start()
    //{
    //    //Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
    //    //Passes the main input field into the method when "LockInput" is invoked
    //    mainInputField.onEndEdit.AddListener(delegate { LockInput(mainInputField); });
    //}



    public void sendChat()
    {
        chatView.GetComponent<ChatScript>().addUserChat(GetComponent<TMPro.TMP_InputField>().text);
        GetComponent<TMPro.TMP_InputField>().text = "";
    }
}
