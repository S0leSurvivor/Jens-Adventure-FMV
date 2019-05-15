using UnityEngine;
using UnityEngine.SceneManagement;



public class ControlLeaveAfterFoothillsIgnore : MonoBehaviour
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
        if (Time.time - startTIme > 37f)
        {
            isItOkayToSwitch = true;
            button.SetActive(true);
        }
    }

    public void NextScene()
    {
        if (isItOkayToSwitch)
        {
            SceneManager.LoadScene("2_FoothillsNoPhone");
        }
    }

}