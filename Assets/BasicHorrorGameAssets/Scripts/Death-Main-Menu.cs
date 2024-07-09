﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void B_LoadScene()
    {
       
        SceneManager.LoadScene("Game");
    }


    public void B_QuitGame()
    {
        Application.Quit();
    }
}
