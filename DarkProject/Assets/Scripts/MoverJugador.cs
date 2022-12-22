using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public Rigidbody theRB;
    public float velocidadMovimiento;


    private Vector2 moveInput;

    public Animator anim;

    public SpriteRenderer theSR;

    private bool movingBackwards;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        moveInput.Normalize();



        anim.SetFloat("moveSpeed", theRB.velocity.magnitude);
        anim.SetFloat("Horizontal", moveInput.x);
        anim.SetFloat("Vertical", moveInput.y);
    }

    private void FixedUpdate()
    {
        theRB.velocity = new Vector3(moveInput.x * velocidadMovimiento, theRB.velocity.y, moveInput.y * velocidadMovimiento);

    }




}
