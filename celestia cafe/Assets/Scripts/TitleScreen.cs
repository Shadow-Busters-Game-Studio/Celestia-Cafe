using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
     // sets variable as next scene number in build (for main menu, 1 is next)
    public int Start = 1;
    public int Gallery = 2;
    public int Settings = 3;

    // when PlayGame() is called, it brings us to the Next Scene ni the build (after this menu.)
    public void PlayGame(){
        Debug.Log(Application.persistentDataPath);
        SceneManager.LoadScene(Start);
    }

    public void SeeGallery(){
        Debug.Log(Application.persistentDataPath);
        SceneManager.LoadScene(Gallery);
    }

    public void CheckSettings(){
        Debug.Log(Application.persistentDataPath);
        SceneManager.LoadScene(Settings);
    }

    // when QuitGame() is called, the application shuts down/the game is exited.
    public void QuitGame(){
        Application.Quit();
    }
}
