using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeleportationPad : MonoBehaviour {

    public GameObject player;
    public Transform spawnPoint;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            player = col.transform.gameObject;
            player.transform.position = spawnPoint.transform.position;   
            Application.LoadLevel("Game over");
            }
        }
    }

