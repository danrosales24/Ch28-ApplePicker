﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Remember, we need this line for uGUI to work.
public class HighScore : MonoBehaviour
{
    static public int score = 1000;
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
    }
}