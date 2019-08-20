using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crefty : MonoBehaviour
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
        if (checkStone == false)
        {
            speed = -5f;
        }
        else
        {
            speed = 5f;
        }
        rbCret.velocity = new Vector2(0, transform.localScale.y) * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "duongdi")
        {
            checkStone = true;
        }
        if (collision.gameObject.tag == "crefY")
        {
            checkStone = false;
        }
    }

}
