using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public Rigidbody theRB;
    public float velocidadMovimiento;
    public float jumpForce;

    private Vector2 moveInput;

    public Animator anim;

    public SpriteRenderer theSR;

    private bool movingBackwards;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        moveInput.Normalize();

        theRB.velocity = new Vector3(moveInput.x * velocidadMovimiento, theRB.velocity.y, moveInput.y*velocidadMovimiento);

        anim.SetFloat("moveSpeed", theRB.velocity.magnitude);

        if (!theSR.flipX && moveInput.x < 0)
        {
            theSR.flipX = true;

        }else if (theSR.flipX && moveInput.x > 0) 
        { 
            theSR.flipX=false;
        }

        if (!movingBackwards && moveInput.y > 0)
        {
            movingBackwards = true;
        }else if (movingBackwards&&moveInput.y<0)
        {
            movingBackwards=false;
        }
    }
}
