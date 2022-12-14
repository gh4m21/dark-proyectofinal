using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    private string currentState = "IdleState";
    private Transform target;
public Slider Slider_Coins;
    public float chaseRange = 5;
    public float attackRange = 2;
    public float speed = 3;
    public float health = 1;
    public int maxHealth;

    public Animator animator;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Jugador").transform;
     health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {


        float distance = Vector3.Distance(transform.position, target.position);

        if(currentState == "IdleState")
        {
            if (distance < chaseRange)
                currentState = "ChaseState";
        }
        else if(currentState == "ChaseState")
        {
            //play the run animation
            animator.SetTrigger("Perseguir");
           animator.SetBool("isAttacking", false);
            //move towards the player
            
            if(distance < attackRange)
                currentState = "AttackState";

            if(target.position.x > transform.position.x)
            {
                //move right
                transform.Translate(transform.right * speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
           else
            {
                //move left
                transform.Translate(-transform.right * speed * Time.deltaTime);
                transform.rotation = Quaternion.identity;

                
            }
        }
        else if(currentState == "AttackState")
        {
            animator.SetBool("isAttacking", true);

            if (distance > attackRange)
                currentState = "ChaseState";
        }
    }
    
    
     public void TakeDamage(int damage)
    {
        health -= damage;
        currentState = "ChaseState";

        if(health < 0)
        {
            Die();
             PlayerManager.numberOfCoins++;
        }
    }

    private void Die()
    {
        //play a die animation
        animator.SetTrigger("isDead");

        //disable the script and the collider
        GetComponent<CapsuleCollider>().enabled = false;
        Destroy(gameObject, 3);
        this.enabled = false;
    }
}