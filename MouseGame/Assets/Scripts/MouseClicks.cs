using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicks : MonoBehaviour
{
    public GameObject GameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0)) 
        {
         Debug.Log("Left Click");
        }
     
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Click");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Left Click");
        }

    }
}
