using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D rb;
    public bool isWalking;

    

    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;

    private int walkDirection;

    public Animator anim;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        waitCounter = waitTime;
        walkCounter = walkTime;

        ChooseDirection();

    }


    void Update()
    {
       

        if (isWalking == true)
        {
            walkCounter -= Time.deltaTime;


            switch (walkDirection)
            {


                case 0:
                    rb.velocity = new Vector2(0, moveSpeed);
                    
                    break;

                case 1:
                    rb.velocity = new Vector2(moveSpeed, 0);
                    sprite.flipX = true;
                    break;

                case 2:
                    rb.velocity = new Vector2(0, -moveSpeed);
                    
                    break;

                case 3:
                    rb.velocity = new Vector2(-moveSpeed, 0);
                    sprite.flipX = false;
                    break;

            }

            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
        }

        else
        {
            rb.velocity = Vector2.zero;

            waitCounter -= Time.deltaTime;

            if (waitCounter < 0)
            {
                ChooseDirection();

            }
        }

        
        anim.SetBool("walking", isWalking);
    }

    public void ChooseDirection()
    {
        walkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }
}