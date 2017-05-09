using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovels : MonoBehaviour
{
    public float shovelspeed = 40;

    public Rigidbody2D shovelsob;

    // Use this for initialization
    void Fire()
    {
        Rigidbody2D shovelsobClone = (Rigidbody2D)Instantiate(shovelsob, transform.position, transform.rotation);
        if (GetComponent<Player>().facingleft)
        {
            shovelsobClone.velocity = -transform.right * shovelspeed;
        }
        else if (GetComponent<Player>().facingright)
        {
            shovelsobClone.velocity = transform.right * shovelspeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
        {
            Fire();

        }

    }
}