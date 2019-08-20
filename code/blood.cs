using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class blood : MonoBehaviour
{
    private List<GameObject> list;
    private GameObject[] array;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        list = new List<GameObject>();
        array = GameObject.FindGameObjectsWithTag("blood");
        foreach(GameObject goj in array)
        {
            list.Add(goj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "creft")
        {
            if (i <4)
            {
                Destroy(list[i]);            
                i++;
            }
        }

        if (i ==3)
        {
            SceneManager.LoadScene("gameover");
        }

   
    }
}
