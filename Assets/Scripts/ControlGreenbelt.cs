﻿using UnityEngine;
using UnityEngine.SceneManagement;



public class ControlGreenbelt : MonoBehaviour
{

    private float startTIme;
    public GameObject button;

    private bool isItOkayToSwitch = false;

    public void Start()
    {
        button.SetActive(false);
        startTIme = Time.time;
    }

    public void Update()
    {
        if (Time.time - startTIme > 26f)
        {
            isItOkayToSwitch = true;
            button.SetActive(true);
        }
    }

    public void NextScene()
    {
        if (isItOkayToSwitch)
        {
            SceneManager.LoadScene("4_Greenbelt");
        }
    }

}