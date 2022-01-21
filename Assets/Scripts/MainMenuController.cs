using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button buttonVolume;
    public Sprite imageSoundOn;
    public Sprite imageSoundOff;

    public void PlayGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ViewInfo(GameObject panel)
    {
        panel.gameObject.SetActive(true);
    }

    public void CloseInfo(GameObject panel)
    {
        panel.gameObject.SetActive(false);
    }

    public void TriggerSound()
    {
        bool sound = AudioListener.pause;

        if (sound == true)
        {
            buttonVolume.image.sprite = imageSoundOn;
            ActivateSound();
        }
        else
        {
            buttonVolume.image.sprite = imageSoundOff;
            DesactivateSound();
        }
    }

    private void ActivateSound()
    {
        AudioListener.pause = false;
    }

    private void DesactivateSound()
    {
        AudioListener.pause = true;
    }
}
