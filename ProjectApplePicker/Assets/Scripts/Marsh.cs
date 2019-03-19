using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marsh : MonoBehaviour
{
    public static float bottomY = -383f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            MarshmellowPicker maScript = Camera.main.GetComponent<MarshmellowPicker>();
            maScript.MarshDestroyed();
        }
    }
}
