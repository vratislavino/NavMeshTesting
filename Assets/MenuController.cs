using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static bool load = false;

    public void OnStartClicked()
    {
        SceneManager.LoadScene("DefaultGameScene");
    }

    public void OnLoadGameClicked()
    {
        load = true;
        SceneManager.LoadScene("DefaultGameScene");
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }

}
