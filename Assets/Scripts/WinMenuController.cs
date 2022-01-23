using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenuController : MonoBehaviour
{
    public void GoToNextLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
