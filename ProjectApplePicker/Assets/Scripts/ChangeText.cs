using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public TextMeshProUGUI score3;
    public TextMeshProUGUI score4;
    public TextMeshProUGUI score5;
    public TextMeshProUGUI score6;
    public TextMeshProUGUI score7;
    public TextMeshProUGUI score8;
    public TextMeshProUGUI score9;
    public TextMeshProUGUI score10;

    private void Start()
    {
        score1.text = PlayerPrefs.GetInt("High Score 1").ToString();
        score2.text = PlayerPrefs.GetInt("High Score 2").ToString();
        score3.text = PlayerPrefs.GetInt("High Score 3").ToString();
        score4.text = PlayerPrefs.GetInt("High Score 4").ToString();
        score5.text = PlayerPrefs.GetInt("High Score 5").ToString();
        score6.text = PlayerPrefs.GetInt("High Score 6").ToString();
        score7.text = PlayerPrefs.GetInt("High Score 7").ToString();
        score8.text = PlayerPrefs.GetInt("High Score 8").ToString();
        score9.text = PlayerPrefs.GetInt("High Score 9").ToString();
        score10.text = PlayerPrefs.GetInt("High Score 10").ToString();
    }
}
