using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                GlobalStats.Coin1 = 0;            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                GlobalStats.Coin2 = 0;            }
        }
    }
}
