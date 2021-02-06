using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalStats : MonoBehaviour
{
    public int Coin1 = 0;
    public int Secret1 = 0; 
    public int Coin2 = 0;
    public int Secret2 = 0;
    public int Coin3 = 0;
    public int Secret3 = 0;
    public int CoinAll;
    public int SecretAll;

    public GameObject Coin1Amount;
    public GameObject Secret1Amount;
    public GameObject Coin2Amount;
    public GameObject Secret2Amount;
    public GameObject Coin3Amount;
    public GameObject Secret3Amount;
    public GameObject GlobalCoinAmount;
    public GameObject GlobalSecretAmount;

    public GameObject Map2;
    public GameObject Map3;

    public bool Map1Completed = false;
    public bool Map2Completed = false;

    void Update()
    {
        CoinAll = Coin1 + Coin2 + Coin3;
        SecretAll = Secret1 + Secret2 + Secret3;

        Coin1Amount.GetComponent<Text>().text = Coin1 + " / 10";
        Secret1Amount.GetComponent<Text>().text = Secret1 + " / 1";
        Coin2Amount.GetComponent<Text>().text = Coin2 + " / 10";
        Secret2Amount.GetComponent<Text>().text = Secret2 + " / 1";
        Coin3Amount.GetComponent<Text>().text = Coin3 + " / 10";
        Secret3Amount.GetComponent<Text>().text = Secret3 + " / 1";
        GlobalCoinAmount.GetComponent<Text>().text = CoinAll + "";
        GlobalSecretAmount.GetComponent<Text>().text = SecretAll + "";

        if (Map1Completed == true)
        {
            Map2.GetComponent<Button>().interactable = true;
            Coin2Amount.gameObject.SetActive(true);
            Secret2Amount.gameObject.SetActive(true);

        }
        else if (Map1Completed ==false)
        {
            Map2.GetComponent<Button>().interactable = false;
            Coin2Amount.gameObject.SetActive(false);
            Secret2Amount.gameObject.SetActive(false);


        }
        if (Map2Completed == true && Map1Completed == true)
        {
            Map3.GetComponent<Button>().interactable = true;
            Coin3Amount.gameObject.SetActive(true);
            Secret3Amount.gameObject.SetActive(true);


        }
        else if( Map2Completed == false)
        {
            Map3.GetComponent<Button>().interactable = false;
            Coin3Amount.gameObject.SetActive(false);
            Secret3Amount.gameObject.SetActive(false);



        }
    }
}
