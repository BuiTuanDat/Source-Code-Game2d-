using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    private Transform player;
    public float minx, maxx;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player_0").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 temp = transform.position;
            temp.x = player.position.x;

            if (temp.x < minx)
            {
                temp.x = minx;
            }

            if (temp.x > maxx)
            {
                temp.x = maxx;
            }
            transform.position = temp;
        }
        
    }
}
