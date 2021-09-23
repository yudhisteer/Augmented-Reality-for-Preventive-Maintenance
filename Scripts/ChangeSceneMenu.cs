using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour
{
    public void pumpmenu()
    {
        SceneManager.LoadScene("SpecificationScene");
    }

    public void exitgame()
    {
        Application.Quit();
        Debug.Log("Exit Button pressed");
    }
}
