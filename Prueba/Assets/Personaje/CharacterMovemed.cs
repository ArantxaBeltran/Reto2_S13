using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovemed : MonoBehaviour
{ 
    public float speedMovement ;
    public float speedRotation ;
    public float jumpForce ;
    public float gravityScale ; // Variable para ajustar la gravedad desde el Inspector

    private Rigidbody rb;
    public bool canJump ;


    private Animator animator;

    private void Start()
    {
        animator= GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

     void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        animator.SetFloat("Movx",horizontal);
        animator.SetFloat("Movy",vertical);

        transform.Translate(0f,0f,vertical * Time.deltaTime*speedMovement);
        transform.Rotate(0f,horizontal * Time.deltaTime*speedRotation,0f);

        if (Input.GetButtonDown("Jump") && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity += Physics.gravity * gravityScale * Time.fixedDeltaTime; // Aplica la gravedad en FixedUpdate
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}