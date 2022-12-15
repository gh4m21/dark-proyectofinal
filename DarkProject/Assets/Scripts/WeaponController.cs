using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
      public SwordAttack swordAttack;
 Vector2 movementInput;
    SpriteRenderer spriteRenderer;
    Rigidbody rb;
    Animator animator;
      bool canMove = true;

     void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
  private void FixedUpdate() {
        if(canMove) {  
                animator.SetBool("isMoving", true);
            } else {
                animator.SetBool("isMoving", false);
            }

            
        }

    void OnFire() {
        animator.SetTrigger("swordAttack");
    }

    public void SwordAttack() {
        LockMovement();

        if(spriteRenderer.flipX == true){
            swordAttack.AttackLeft();
        } else {
            swordAttack.AttackRight();
        }
    }

    public void EndSwordAttack() {
        UnlockMovement();
        swordAttack.StopAttack();
    }

    public void LockMovement() {
        canMove = false;
    }

    public void UnlockMovement() {
        canMove = true;
    }
}