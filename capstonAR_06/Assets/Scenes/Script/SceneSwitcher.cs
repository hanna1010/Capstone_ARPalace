using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void GotoStart()
    {
        Debug.Log("work");
        SceneManager.LoadScene("Start");
    }

    public void GotoGBG()
    {
        SceneManager.LoadScene("GBG");
    }

    public void GotoGHG()
    {
        SceneManager.LoadScene("VERIFICATION");
    }

    public void GotoCDG()
    {
        SceneManager.LoadScene("CDG");
    }

    public void GotoCGG()
    {
        SceneManager.LoadScene("CGG");
    }

    public void GotoDSG()
    {
        SceneManager.LoadScene("DSG");
    }
    public void GotoNEXT1()
    {
        SceneManager.LoadScene("NEXT1");
    }
    public void GotoSECOND()
    {
        SceneManager.LoadScene("SECOND");

    }
    public void GotoJUNG()
    {
        SceneManager.LoadScene("JUNG");
    }
    public void GotoABIG()
    {
        SceneManager.LoadScene("ABIG");
    }
    public void GotoFIRST()
    {
        SceneManager.LoadScene("FIRST");
    }
    public void GotoMISSION3()
    {
        SceneManager.LoadScene("MISSION3");
    }
}