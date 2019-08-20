using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class dichuyen : MonoBehaviour {
  
    private Rigidbody2D myrig;
    private Animator ani;
    public float speed;
    public float jum;
    public static bool isGameOver = false;

    public int bloodmax;
    public int bloodmin;

    private bool left, right;
    void Start()
    {
        myrig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        isGameOver = false;
        bloodmax = bloodmin;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //set trang thai cho Animator
                ani.SetBool("run", true);
                ani.SetBool("stop", false);
                //di chuyen
                gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
                //quay dau
                if (gameObject.transform.localScale.x > 0)
                {
                    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1,
                        gameObject.transform.localScale.y, gameObject.transform.localScale.z);

                }
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                ani.SetBool("run", true);
                ani.SetBool("stop", false);
                //di chuyen
                gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
                //quay dau
                if (gameObject.transform.localScale.x < 0)
                {
                    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1,
                        gameObject.transform.localScale.y, gameObject.transform.localScale.z);

                }

            }
            else if (Input.GetKey(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, jum);
            }
            else
            {
                ani.SetBool("run", false);
                ani.SetBool("stop", true);
            }
        }

        joystick();


    }





    // Update is called once per frame
 

    public void SetLeft(bool left)
    {
        this.left = left;
    }

    public void SetRight(bool right)
    {
        this.right = right;
    }

    public void stop()
    {
        left = right = false;
        ani.SetBool("stop", true);
        ani.SetBool("run", false);
    }

    void _Right()
    {
        Vector2 temp = transform.localScale;
        temp.x = 1.3f;
        transform.localScale = temp;
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        ani.SetBool("run", true);
    }

    void _Left()
    {
        Vector2 temp = transform.localScale;
        temp.x = -1.3f;
        transform.localScale = temp;
        gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        ani.SetBool("run", true);
    }

    void _Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, jum);
    }


    public void _Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void joystick()
    {
        if (left)
        {
            _Left();
        }

        if (right)
        {
            _Right();
        }

        if (bloodmin == 0)
        {
            _Dead();
        }
    }



}

