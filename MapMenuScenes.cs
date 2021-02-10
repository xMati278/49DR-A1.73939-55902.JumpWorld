using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMenuScenes : MonoBehaviour
{
    public void Map1()
    {
        SceneManager.LoadScene(2);
    }
    public void Map2()
    {
        SceneManager.LoadScene(3);
    }
}
