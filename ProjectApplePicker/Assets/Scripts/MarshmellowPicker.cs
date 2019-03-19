using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarshmellowPicker : MonoBehaviour
{
    public GameObject CocoaPrefab;
    public int numCocoa = 3;
    public float CocoaBottomY = -300f;
    public float CocoaSpacingY = 2f;
    public Text playerLives;

    public List<GameObject> cocoaList;
    // Start is called before the first frame update
    void Start()
    {
        cocoaList = new List<GameObject>();
        for (int i = 0; i < numCocoa; i++)
        {
            GameObject tCocoaGO = Instantiate(CocoaPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = CocoaBottomY + (CocoaSpacingY * i);
            tCocoaGO.transform.position = pos;
            cocoaList.Add(tCocoaGO);
        }
        GameObject lives = GameObject.Find("Lives");
        playerLives = lives.GetComponent<Text>();
        playerLives.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MarshDestroyed()
    {
        GameObject[] tMarshArray = GameObject.FindGameObjectsWithTag("Marshmellows");
        foreach (GameObject tGO in tMarshArray)
        {
            Destroy(tGO);
        }
        int cocoaIndex = cocoaList.Count-1;
        GameObject tCocoaGO = cocoaList[cocoaIndex];
        cocoaList.RemoveAt(cocoaIndex);
        Destroy(tCocoaGO);
        int live = int.Parse(playerLives.text);
        live -= 1;
        playerLives.text = live.ToString();
        //rstart
        if (cocoaList.Count == 0)
        {
            SceneManager.LoadScene("End");

        }
    }

}
