using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    private GameObject mainMenu;
    private GameObject optionsMenu;

    private void Awake()
    {
        mainMenu = GameObject.Find("MainMenu");
        optionsMenu = GameObject.Find("OptionsPanel");
    }

    private void Start()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenOptions()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void ApplyChanges()
    {
        
    }

    public void ReturnToMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
