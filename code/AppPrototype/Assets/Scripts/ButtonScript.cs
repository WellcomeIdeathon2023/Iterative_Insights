using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public string targetSceneName;

    // Start is called before the first frame update
    public void onClick()
    {
        Debug.Log("Loading: " + targetSceneName);
        SceneManager.LoadScene(targetSceneName);
    }
}
