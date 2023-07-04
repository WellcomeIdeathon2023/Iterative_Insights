using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class TextInput : MonoBehaviour
{
    public GameObject chatView;

    public void sendChat()
    {
        if (GetComponent<TMPro.TMP_InputField>().text.Trim() == "")
        {
            return;
        }
        chatView.GetComponent<ChatScript>().addUserChat(GetComponent<TMPro.TMP_InputField>().text);
        GetComponent<TMPro.TMP_InputField>().text = "";
    }
}
