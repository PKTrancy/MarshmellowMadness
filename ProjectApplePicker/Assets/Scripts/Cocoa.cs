using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cocoa : MonoBehaviour
{
    public Text scoreGT;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreText");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //get current screen position of the mouse from input
        Vector3 mousePos2D = Input.mousePosition;
        //
        mousePos2D.z = -Camera.main.transform.position.z;
        //
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        //move x pos of cocoa
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //find what was hit
        if (col.gameObject.tag == "Marshmellows")
        {
            Destroy(col.gameObject);
            Audio.instance.PlaySingle();
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();
            PlayerPrefs.SetInt("Current Score", score);
        }
    }
}
