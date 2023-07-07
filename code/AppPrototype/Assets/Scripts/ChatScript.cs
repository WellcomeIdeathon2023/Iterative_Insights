using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChatScript : MonoBehaviour
{

    public GameObject botPrefab;
    public GameObject userPrefab;

    public void addUserChat(string chat)
    {
        GameObject newChat = Instantiate(userPrefab, transform.GetChild(0).GetChild(0).transform);
        newChat.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = chat;

        newChat.transform.GetChild(0).GetComponent<ContentSizeFitter>().SetLayoutVertical();

        if (chat == "...yes")
        {
            StartCoroutine(addScript());
        }
    }


    public void addBotChat(string chat)
    {
        StartCoroutine(addText(chat));
    }


    IEnumerator addScript()
    {
        yield return StartCoroutine(addText(botMessages[0]));
        yield return StartCoroutine(addText(botMessages[1]));
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

        textBox.GetComponent<ContentSizeFitter>().SetLayoutVertical();
        textBox.transform.GetChild(0).GetComponent<ContentSizeFitter>().SetLayoutVertical();
        textBox.transform.GetChild(0).GetChild(0).GetComponent<ContentSizeFitter>().SetLayoutVertical();
        textBox.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<ContentSizeFitter>().SetLayoutVertical();

    }

    string[] botMessages =
    {
        "Chatbot: I am so sorry you are feeling that way, I will alert those that you have noted down as permitted to support you",
        "Remember you can also always call ‘+0123467899’ to get immediate emergency support"
    };

}
