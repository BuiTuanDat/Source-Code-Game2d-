using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();




        float caocr = Camera.main.orthographicSize * 2f;
        float rongcr = caocr * Screen.width / Screen.height;

 

        transform.localScale = new Vector3(rongcr,caocr,0f);
    }

    // Update is called once per frame
   
}
