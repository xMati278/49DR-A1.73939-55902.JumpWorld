using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Reset1()
    {
        SceneManager.LoadScene(1);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Reset2()
    {
        SceneManager.LoadScene(3);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Reset3()
    {
        SceneManager.LoadScene(4);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(2);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
