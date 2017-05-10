﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int score;
    private Text t;

	// Use this for initialization
	void Start () {
        score = 0;
        t = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        t.text = "Score: " + score.ToString("D6");
	}

    void excellent()
    {
		Debug.Log("e");
        score += 1000;
    }

    void good()
    {
		Debug.Log("g");
        score += 500;
    }

    void okay()
    {
		Debug.Log("o");
        score += 250;
    }

    void miss()
    {
		Debug.Log("miss");
        score -= 101;
        if (score < 0)
        {
            score = 0;
        }
    }
}
