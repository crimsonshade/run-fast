using System;
using UnityEditor.SearchService;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
}
