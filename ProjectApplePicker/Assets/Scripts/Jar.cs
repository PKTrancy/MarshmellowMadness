using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jar : MonoBehaviour
{
    //Declare class fields
    //Marshmellow prefab
    public GameObject marshmellowPrefab;
    //Speed
    public float speed = 150f;
    //distance
    public float leftAndRightEdge = 615f;
    //chance
    public float chanceToChange = 0.1f;
    //rate of drop
    public float secondsBetweenDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //begin dropping marshmellows
        InvokeRepeating("DropMarshmellow", 2f, secondsBetweenDrops);
    }

    void DropMarshmellow()
    {
        GameObject marsh = Instantiate(marshmellowPrefab) as GameObject;
        marsh.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing directions
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //move left
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChange)
        {
            speed *= -1; //change directions
        }
    }

}
