using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This function is used switch scenes. It is attached to each button in my program,
/// and takes in the name of the new scene I want to load. It's incredibly simple and useful.
/// This function also plays a sound, selected in the editor, when pressed.
/// </summary>

public class ButtonScript : MonoBehaviour
{
    //[Header("Button Buddy")]

    public void switcher(string scene)
    {
        //loads scene using string given in editor
        SceneManager.LoadScene(scene);
    }

    public void doExitGame()
    {
        Application.Quit();
    }

}
