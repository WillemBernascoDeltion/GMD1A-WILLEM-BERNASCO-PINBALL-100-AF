using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour
{
    public int score;

    public bool ended;

    public GameObject pow;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { }


    public void AddPoints(int points)
    {
        score += points;


    }
}