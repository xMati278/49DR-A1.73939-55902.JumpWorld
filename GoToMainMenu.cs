﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToMainMenu : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
