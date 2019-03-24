using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class highscore : MonoBehaviour
{
    //all private variables
    //defualt highscore - readonly int -set to 0
    private readonly int defHS = 0;
    //score int and temp int
    private int score;
    private int temp;

    public void Start()
    {
        //if statement that asks if PlayerPrefs alreadly has a "high score 1"
        if (!PlayerPrefs.HasKey("High Score 1"))
        {
            PlayerPrefs.SetInt("High Score 1", defHS);
            PlayerPrefs.SetInt("High Score 2", defHS);
            PlayerPrefs.SetInt("High Score 3", defHS);
            PlayerPrefs.SetInt("High Score 4", defHS);
            PlayerPrefs.SetInt("High Score 5", defHS);
            PlayerPrefs.SetInt("High Score 6", defHS);
            PlayerPrefs.SetInt("High Score 7", defHS);
            PlayerPrefs.SetInt("High Score 8", defHS);
            PlayerPrefs.SetInt("High Score 9", defHS);
            PlayerPrefs.SetInt("High Score 10", defHS);
            PlayerPrefs.SetInt("Current Score", defHS);
        }
        //if not (!playerPrefs.hasKey(highscore 1)) then add 10 highscores with
        //PlayerPrefs.SetInt("High Score 1", default highscore)
        //also set a current score using same line -> PlayerPrefs.SetInt("Current Score", default highscore)
    }
    public void EndGame()
    {
        //set score to  PlayerPrefs.GetInt("Current Score", default highscore)
        score = PlayerPrefs.GetInt("Current Score");
        //if statement -> score > PlayerPrefs.GetInt("High Score 1")
        if (score > PlayerPrefs.GetInt("High Score 1"))
        {
            temp = PlayerPrefs.GetInt("High Score 1");
            PlayerPrefs.SetInt("High Score 1", score);
            score = temp;
        }
        //if so - > temp set to PlayerPrefs.GetInt("High Score 1")
        //->PlayerPrefs.SetInt("High Score 1", score);
        //score = temp;
        //repeat for each of 10 high scores
        //2
        if (score > PlayerPrefs.GetInt("High Score 2"))
        {
            temp = PlayerPrefs.GetInt("High Score 2");
            PlayerPrefs.SetInt("High Score 2", score);
            score = temp;
        }
        //3
        if (score > PlayerPrefs.GetInt("High Score 3"))
        {
            temp = PlayerPrefs.GetInt("High Score 3");
            PlayerPrefs.SetInt("High Score 3", score);
            score = temp;
        }
        //4
        if (score > PlayerPrefs.GetInt("High Score 4"))
        {
            temp = PlayerPrefs.GetInt("High Score 4");
            PlayerPrefs.SetInt("High Score 4", score);
            score = temp;
        }
        //5
        if (score > PlayerPrefs.GetInt("High Score 5"))
        {
            temp = PlayerPrefs.GetInt("High Score 5");
            PlayerPrefs.SetInt("High Score 5", score);
            score = temp;
        }
        //6
        if (score > PlayerPrefs.GetInt("High Score 6"))
        {
            temp = PlayerPrefs.GetInt("High Score 6");
            PlayerPrefs.SetInt("High Score 6", score);
            score = temp;
        }
        //7
        if (score > PlayerPrefs.GetInt("High Score 7"))
        {
            temp = PlayerPrefs.GetInt("High Score 7");
            PlayerPrefs.SetInt("High Score 7", score);
            score = temp;
        }
        //8
        if (score > PlayerPrefs.GetInt("High Score 8"))
        {
            temp = PlayerPrefs.GetInt("High Score 8");
            PlayerPrefs.SetInt("High Score 8", score);
            score = temp;
        }
        //9
        if (score > PlayerPrefs.GetInt("High Score 9"))
        {
            temp = PlayerPrefs.GetInt("High Score 9");
            PlayerPrefs.SetInt("High Score 9", score);
            score = temp;
        }
        //10
        if (score > PlayerPrefs.GetInt("High Score 10"))
        {
            temp = PlayerPrefs.GetInt("High Score 10");
            PlayerPrefs.SetInt("High Score 10", score);
            score = temp;
        }
        PlayerPrefs.SetInt("Current Score", defHS);
    }
}
