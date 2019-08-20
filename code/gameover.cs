using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    int time = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (time > 0)
        {
            time--;
            Invoke("Start", 1.0f);
        }
        else
        {
            SceneManager.LoadScene("start");
        } 
    }

}
