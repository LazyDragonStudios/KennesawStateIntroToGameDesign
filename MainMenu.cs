using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterOnePlayer()
    {
        SceneManager.LoadScene("OnePLayer");
    }
    public void EnterTwoPlayer()
    {
        SceneManager.LoadScene("TwoPLayer");
    }

    public void EnterAbout()
    {
        SceneManager.LoadScene("About");
    }
    public void EnterHelp()
    {
        SceneManager.LoadScene("Help");
    }
    public void EnterMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
