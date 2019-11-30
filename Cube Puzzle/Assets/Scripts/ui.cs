using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ui : MonoBehaviour
{
    public Animator anim;
   
    public void options()
    {
        anim.SetBool("options", true);
    }
    public void back()
    {
        anim.SetBool("options", false);
    }
    public void quit()
    {
        anim.SetBool("quit", true);
    }
    public void no()
    {
        anim.SetBool("quit", false);
    }
    public void controls()
    {
        anim.SetBool("controls", true);
    }
    public void controlsBack()
    {
        anim.SetBool("controls", false);
        
    }
    
    public void yes()
    {
        Application.Quit();
    }
    public void Play()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void retry()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
