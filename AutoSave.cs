using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{
    public static int LoadAviable = 0;

    public static void Save()
    {
        LoadAviable = 1;
        PlayerPrefs.SetInt("Coin1", GlobalStats.Coin1);
        PlayerPrefs.SetInt("Coin2", GlobalStats.Coin2);
        PlayerPrefs.SetInt("Map1", GlobalStats.Map1Completed);


    }

}
