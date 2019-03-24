﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleHighScore : MonoBehaviour
{
    static public int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (PlayerPrefs.HasKey("MarshmellowHighScore"))
        {
            score = PlayerPrefs.GetInt("MarshmellowHighScore");
        }
        PlayerPrefs.SetInt("MarshmellowHighScore", score);
    }
    // Update is called once per frame
    void Update()
    {
        TextMesh scoreGT = this.GetComponent<TextMesh>();
        scoreGT.text = "High Score: " + score;
        if (score > PlayerPrefs.GetInt("MarshmellowHighScore"))
        {
            PlayerPrefs.SetInt("MarshmellowHighScore", score);
        }
    }
}
