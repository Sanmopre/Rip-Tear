﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{

    public int score = 0;
    public int score_time;
    private int counter = 0;

    public int d = 100;
    public int c = 200;
    public int b = 350;
    public int a = 500;
    public int s = 800;
    public int ss = 1200;
    public int sss = 1750;


    public bool in_d = false;
    public bool in_c = false;
    public bool in_b = false;
    public bool in_a = false;
    public bool in_s = false;
    public bool in_ss = false;
    public bool in_sss = false;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0) { score = 0; }


        Debug.Log(score);
    }
}
