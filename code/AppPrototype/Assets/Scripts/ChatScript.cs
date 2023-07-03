using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatScript : MonoBehaviour
{

    public GameObject botPrefab;
    public GameObject userPrefab;

    public void addUserChat(string chat)
    {
        Instantiate(userPrefab, transform.GetChild(0).GetChild(0).transform).GetComponentInChildren<TMPro.TextMeshProUGUI>().text = chat;
    }

}
