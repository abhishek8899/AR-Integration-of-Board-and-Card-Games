using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject Main;
    public GameObject Instructions;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }

    public void Help()
    {
        Main.transform.gameObject.SetActive(false);
        Instructions.transform.gameObject.SetActive(true);
    }
    public void back()
    {
        Main.transform.gameObject.SetActive(true);
        Instructions.transform.gameObject.SetActive(false);
    }
}
