using UnityEngine;
using UnityEngine.SceneManagement;



public class ControlIGNORE : MonoBehaviour
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
        if (Time.time - startTIme > 38f)
        {
            isItOkayToSwitch = true;
            button.SetActive(true);
        }
    }

    public void NextScene()
    {
        if (isItOkayToSwitch)
        {
            SceneManager.LoadScene("Ignore No Phone");
        }
    }

}