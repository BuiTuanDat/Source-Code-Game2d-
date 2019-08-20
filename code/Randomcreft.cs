using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomcreft : MonoBehaviour
{
    [SerializeField]
    private GameObject creft;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Creft ());
    }

    // Update is called once per frame

    IEnumerator Creft()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(creft, transform.position, Quaternion.identity);
        StartCoroutine(Creft());
    }
  
   
}
