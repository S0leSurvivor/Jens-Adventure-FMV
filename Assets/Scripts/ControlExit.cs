using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlExit : MonoBehaviour
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
        if (Time.time - startTIme > 95f)
        {
            isItOkayToSwitch = true;
            button.SetActive(true);
        }
    }

    public void ExitQuit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}