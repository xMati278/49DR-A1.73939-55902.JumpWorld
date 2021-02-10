using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static int LoadAviable = 0;
    public GameObject LoadGameButton;
    public static bool isLoading = false;
    public void NewGame()
    {
        isLoading = false;
        GlobalStats.Coin1 = 0;
        GlobalStats.Coin2 = 0;
        GlobalStats.Map1Completed = 0;
        SceneManager.LoadScene(1);
    }
    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    void Update()
    {
        if (AutoSave.LoadAviable == 1)
        {
            LoadGameButton.GetComponent<Button>().interactable = true;

        }
        if (AutoSave.LoadAviable == 0)
        {
            LoadGameButton.GetComponent<Button>().interactable = false;

        }
    }
    }

