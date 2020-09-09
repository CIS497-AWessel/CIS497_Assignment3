﻿/* 
 * Anthony Wessel
 * Assignment 3 Prototype 2
 * Displays the score on the screen
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text textbox;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
