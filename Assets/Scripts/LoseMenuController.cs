using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenuController : MonoBehaviour
{
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
