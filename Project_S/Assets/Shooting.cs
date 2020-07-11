﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint_2;
    public Transform firePoint_3;

    public GameObject bulletPrefab;

    private enum Weapon_Type 
    { 
        W_1,
        W_2,
        W_3,
        NONE
    }

    private Weapon_Type w_type = Weapon_Type.W_1;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (w_type == Weapon_Type.W_2) { w_type = Weapon_Type.W_1; }
            if (w_type == Weapon_Type.W_1) { w_type = Weapon_Type.W_2; }
        }

        if (Input.GetButtonDown("Fire1")) {
            Shoot(w_type);
        }
    }

    void Shoot(Weapon_Type weapon_t) {

        switch (weapon_t)
        {

        case Weapon_Type.W_1:

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        break;


            case Weapon_Type.W_2:

         GameObject bullet_1 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
         GameObject bullet_2 = Instantiate(bulletPrefab, firePoint_2.position, firePoint_2.rotation);
                GameObject bullet_3 = Instantiate(bulletPrefab, firePoint_3.position, firePoint_3.rotation);

                Rigidbody2D rb_1 = bullet_1.GetComponent<Rigidbody2D>();
                rb_1.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                Rigidbody2D rb_2 = bullet_2.GetComponent<Rigidbody2D>();
                rb_2.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                Rigidbody2D rb_3 = bullet_3.GetComponent<Rigidbody2D>();
                rb_3.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

                break;
        }
    }


}