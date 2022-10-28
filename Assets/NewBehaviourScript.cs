using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right");
        }
        if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("enter");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("esc");
        }
    }
}
