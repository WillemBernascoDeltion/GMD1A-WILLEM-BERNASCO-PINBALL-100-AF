using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Bumper : MonoBehaviour {

    public int coinValue = 1;

    public Text countText;

    private int count;

    // Update is called once per frame
    void Update()
    {
    }

//C# CoinPickup Script

    public class CoinPickup : MonoBehaviour
    {
        // Update is called once per frame
        void OnTriggerEnter(Collider info)
        {
            if (info.tag == "Pick Up")
            {
 //               count = count + 69;
  //              countText.text = "Points: " + count.ToString();
            }
        }
    }
}


                