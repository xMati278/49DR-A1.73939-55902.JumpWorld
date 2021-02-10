using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalStats : MonoBehaviour
{
    public static int Coin1 = 0;
    public static int Coin2 = 0;
    public int CoinAll;

    public GameObject Coin1Amount;
    public GameObject Coin2Amount;
    public GameObject GlobalCoinAmount;

    public GameObject Map2;

    public static int Map1Completed = 0;

    void Update()
    {
        CoinAll = Coin1 + Coin2;
        Coin1Amount.GetComponent<Text>().text = Coin1 + " Cherries";
        Coin2Amount.GetComponent<Text>().text = Coin2 + " Cherries";
        GlobalCoinAmount.GetComponent<Text>().text = "Cherries: " + CoinAll;

        if (Map1Completed == 1)
        {
            Map2.GetComponent<Button>().interactable = true;
            Coin2Amount.gameObject.SetActive(true);

        }
        else if (Map1Completed ==0)
        {
            Map2.GetComponent<Button>().interactable = false;
            Coin2Amount.gameObject.SetActive(false);


        }
    }
}
