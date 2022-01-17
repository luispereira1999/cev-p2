using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenuController : MonoBehaviour
{
    public GameObject panel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panel.gameObject.active)
            {
                Time.timeScale = 1;
                panel.gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                panel.gameObject.SetActive(true);
            }
        }
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);
    }

    public void RestartLevel()
    {

    }

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
