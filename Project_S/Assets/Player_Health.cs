﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int Max_hp;
    public int hp;
    private bool poisoned = false;
    private int poison_damage = 0;
    private int poison_time = 0;
    public HealthBar hp_bar;

    private GameObject x;
    private Score_Manager score;



    private void Start()
    {
        hp_bar.Set_Max_health(Max_hp);

        x = GameObject.Find("Score_system");
        score = x.GetComponent<Score_Manager>();
    }


    void Update()
    {
       
        //POISON MANAGER
        if(poisoned == true)
        {
            if( poison_time % 3 == 0) {
                Take_Damage(poison_damage);
            }
            poison_time--;
        }

        if (poison_time <= 0) {
            poison_time = 0;
            poisoned = false;
        }


        hp_bar.Set_health(hp);


        if (hp <= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }



        if (score.score > score.s) {
            hp++;
        }

        if (Max_hp < hp) {
            hp = Max_hp;
        }

    }


    public void Take_Damage(int damage) {
        hp = hp - damage;

        score.score = score.score - 50 - score.score/3;
    }

    public void Poison(int time, int damage) {
        poisoned = true;
        poison_damage = damage;

    }
}

