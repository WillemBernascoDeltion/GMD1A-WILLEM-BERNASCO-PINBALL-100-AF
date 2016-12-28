using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Ball : MonoBehaviour {

    void Start() { }
 

    void OnCollisionEnter(Collision collision)  
        {
            if (GameObject.FindWithTag("Pick Up"))
            {
            //            other.gameobject.SetActive(false);
            Points.count += 69;
            }
        }

    void Update()
    {

    }
}


