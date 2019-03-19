using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class waitStart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("Scene0");

        if (Input.GetMouseButtonDown(1))
            SceneManager.LoadScene("Scene0");
    }
}
