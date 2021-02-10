using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedCoin1;
    public int savedCoin2;
    void Start()
    {
        if (MainMenu.isLoading == true)
        {
            savedCoin1 = PlayerPrefs.GetInt("Coin1");
            GlobalStats.Coin1 = savedCoin1;
            savedCoin1 = PlayerPrefs.GetInt("Coin2");
            GlobalStats.Coin1 = savedCoin1;
        }
    }

}
