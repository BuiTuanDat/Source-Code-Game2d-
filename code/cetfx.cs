using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cetfx : MonoBehaviour
{
    private Rigidbody2D rbCret;
    public float speed;
    private bool checkStone;
  
    // Start is called before the first frame update
    void Start()
    {
        rbCret = GetComponent<Rigidbody2D>();
        checkStone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkStone == true)
        {
            speed = 5f;
        }
        else
        {
            speed = -5f;
        }
        rbCret.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            checkStone = true;
        }
        if (collision.gameObject.tag == "Stone2")
        {
            checkStone = false;
        }
    }
}
