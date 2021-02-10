using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (GlobalStats.Coin1 < 15)
                {
                    GlobalStats.Coin1 += 1;
                }
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (GlobalStats.Coin2 < 15)
                {
                    GlobalStats.Coin2 += 1;
                }
            }

        }
    }
}
