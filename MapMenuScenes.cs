﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMenuScenes : MonoBehaviour
{
    public void Map1()
    {
        SceneManager.LoadScene(1);
    }
    public void Map2()
    {
        SceneManager.LoadScene(3);
    }
    public void Map3()
    {
        SceneManager.LoadScene(4);

    }
}
