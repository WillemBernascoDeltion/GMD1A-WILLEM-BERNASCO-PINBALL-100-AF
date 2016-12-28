using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour {

    public Text countText;

    public static int count = 0;



    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        countText.text = "Points: " + count.ToString();
    }
}
