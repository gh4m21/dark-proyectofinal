using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider swordCollider;
    public float damage = 3;
     public int maxHealth = 30;
    public Healthbar healthbar;
    Vector2 rightAttackOffset;

    private void Start() {
        rightAttackOffset = transform.position;
    }

    public void AttackRight() {
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft() {
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack() {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            // Deal damage to the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null) {
                enemy.Health -= damage;
                 healthbar.UpdateHealth((float)enemy.Health / (float)maxHealth);
            }
        }
    }
}
