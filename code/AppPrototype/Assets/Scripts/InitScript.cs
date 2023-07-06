using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitScript : MonoBehaviour
{
    // Start is called before the first frame update

    private void Update()
    {
        Debug.Log("Loading: MainMenu");
        SceneManager.LoadScene("MainMenu");
    }

}
