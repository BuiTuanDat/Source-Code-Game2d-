using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class joystick : MonoBehaviour, IPointerUpHandler,IPointerDownHandler
{
    private dichuyen playerjoy;

    void Start()
    {
        playerjoy = GameObject.Find("Player_0").GetComponent<dichuyen>();
    }
    public void OnPointerDown(PointerEventData data)
    {
        if (gameObject.name == "Left")
        {
            playerjoy.SetLeft(true);
        }
        else
        {
            playerjoy.SetRight(true);
        }
    }

    public void OnPointerUp(PointerEventData data)
    {
        if (gameObject.name == "Left")
        {
            playerjoy.stop();
        }
        else
        {
            playerjoy.stop();
            
        }
       
    }

    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
