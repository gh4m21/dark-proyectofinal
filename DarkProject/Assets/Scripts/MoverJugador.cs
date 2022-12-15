using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public Rigidbody theRB;
    public float velocidadMovimiento;
    public float jumpForce;

    private Vector2 moveInput;

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
    }
}
