using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovemed : MonoBehaviour
{ 
    public float speedMovement;
    public float speedRotation;
    private Vector2 moveInput;
    public float jumpForce;
    public float gravityScale;

    private Rigidbody rb;
    private bool canJump;
    private Animator animator;
    private PlayerInput controls;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        controls = GetComponent<PlayerInput>(); 
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        // El movimiento y la rotación ahora se manejan en los eventos del Input System

        if (LivePlayer.playerSalud <= 0)
        {
            speedMovement = 0f;
            speedRotation = 0f;
        }
        moveInput = controls.actions["Move"].ReadValue<Vector2>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        

    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
          JumpMed();
        }
    }

    private void FixedUpdate()
    {
        // Aplica la gravedad en FixedUpdate
        rb.velocity += Physics.gravity * gravityScale * Time.fixedDeltaTime;

        // Mueve y rota el personaje aquí utilizando moveInput

            float horizontal = moveInput.x;
        float vertical = moveInput.y;

        animator.SetFloat("Movx", horizontal);
        animator.SetFloat("Movy", vertical);

        
        transform.Translate(0f, 0f, vertical * Time.deltaTime * speedMovement);
        transform.Rotate(0f, horizontal * Time.deltaTime * speedRotation, 0f);
       

       


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            animator.SetBool("Jump", false);
        }
    }

    private void JumpMed()
    {
              if (canJump == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
            animator.SetBool("Jump",true);
        }
    }
}
