using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class ChatScript : MonoBehaviour
{

    public GameObject botPrefab;
    public GameObject userPrefab;

    public void addUserChat(string chat)
    {
        Instantiate(userPrefab, transform.GetChild(0).GetChild(0).transform).GetComponentInChildren<TMPro.TextMeshProUGUI>().text = chat;
    }


    public void addBotChat(string chat)
    {
        StartCoroutine(addText(chat));
    }

    float timeBetweenWords = 0.08f;
    IEnumerator addText(string text)
    {
        string[] tokens = text.Split(' ');
        GameObject textBox = Instantiate(botPrefab, transform.GetChild(0).GetChild(0).transform);
        textBox.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "";
        foreach (string token in tokens)
        {
            textBox.GetComponentInChildren<TMPro.TextMeshProUGUI>().text += token + " ";
            yield return new WaitForSeconds(timeBetweenWords + Random.Range(-timeBetweenWords, timeBetweenWords));
        }
    }

    string botText = "Hello, I am a bot. I am here to help you with your problems. What is your name?";

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            addBotChat(botText);
        }
    }

}
