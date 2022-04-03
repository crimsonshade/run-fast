using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainScreen;
    [SerializeField] private GameObject infoScreen;

    private void Start()
    {
        mainScreen.SetActive(true);
        infoScreen.SetActive(false);
    }

    public void StartGamer()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void InfoScreen()
    {
        mainScreen.SetActive(false);
        infoScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Soiclas()
    {
        Application.OpenURL("https://linktr.ee/crimsonshade_");
    }
}
