using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string sceneName;

    public void PlayGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
