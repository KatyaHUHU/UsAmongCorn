using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static Action<string> PlayerColleectsCoin = delegate { };
    public health healthbar;
    public float HP;

    private Rigidbody2D rb;
    private float dirX, dirY, moveSpeed;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        healthbar.SetHealth(HP);
        healthbar.maxHealth = HP;
    }

    void Update()
    {
        if (name == "player_1" && Input.anyKey)
        {
            

            if (Input.GetKey(KeyCode.UpArrow))
            {
                dirY = moveSpeed;
                anim.SetBool("isRunning", true);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                dirY = -moveSpeed;
                anim.SetBool("isRunning", true);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dirX = -moveSpeed;
                anim.SetBool("isRunning", true);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                dirX = moveSpeed;
                anim.SetBool("isRunning", true);
            }


        }
        else if (name == "player_1" && !Input.anyKey)
        {
            dirX = 0f;
            dirY = 0f;

            anim.SetBool("isRunning", false);
        }

        if (name == "player_2" && Input.anyKey)
        {

            if (Input.GetKey(KeyCode.W))
            {
                dirY = moveSpeed;
                anim.SetBool("isRunning2", true);
            }

            if (Input.GetKey(KeyCode.S))
            {
                dirY = -moveSpeed;
                anim.SetBool("isRunning2", true);
            }

            if (Input.GetKey(KeyCode.A))
            {
                dirX = -moveSpeed;
                anim.SetBool("isRunning2", true);
            }

            if (Input.GetKey(KeyCode.D))
            {
                dirX = moveSpeed;
                anim.SetBool("isRunning2", true);
            }

        }

        else if (name == "player_2" && !Input.anyKey)
        {

            dirX = 0f;
            dirY = 0f;
            anim.SetBool("isRunning2", false);
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<coin>())
        {
            PlayerColleectsCoin(name);
            Destroy(collision.gameObject);
        }
        
    }
}
