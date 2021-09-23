using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeARScript : MonoBehaviour
{
    public void specification()
    {
        SceneManager.LoadScene("SpecificationScene");
    }

    public void xsection()
    {
        SceneManager.LoadScene("XsectionScene");
    }

    public void working()
    {
        SceneManager.LoadScene("WorkingScene");
    }

    public void simulation()
    {
        SceneManager.LoadScene("SimulationScene");
    }

    public void explode()
    {
        SceneManager.LoadScene("ExplodedScene");
    }

    public void maintenance()
    {
        SceneManager.LoadScene("MaintenanceScene");
    }

    public void manual()
    {
        SceneManager.LoadScene("ManualScene");
    }

    public void xysection()
    {
        SceneManager.LoadScene("XYSectionScene");
    }

    public void ysection()
    {
        SceneManager.LoadScene("YSectionScene");
    }


    public void exitgame()
    {
        Application.Quit();
        Debug.Log("Exit Button pressed");
    }
}
