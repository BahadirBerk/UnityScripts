using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour 
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float turnSpeed = 90f;
    
/*     [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
  */
/*     private Vector3 moveDirection;
    private CharacterController controller;
    private Animator animator;
    private void Start() */
    private Animator animator;
    void Start()
    {
        /* controller = GetComponent<CharacterController>(); */
        animator = GetComponentInChildren<Animator>(); 
    }
    void Update()
    {
        
        var velocity = Vector3.forward * Input.GetAxis("Vertical") * speed;
        transform.Translate(velocity * Time.deltaTime);
        transform.Rotate(Vector3.right, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed);
        animator.SetFloat("Speed", velocity.z);
        if (Input.GetKeyUp(KeyCode.LeftArrow)) 
        {
            transform.Rotate(0.0f, -90.0f, 0.0f);
        }
        /* Move(); */
    }
/*     private void Move()
    {
        float moveZ = Input.GetAxis("Vertical");
        moveDirection = new Vector3(0, 0, moveZ);
        moveDirection *= walkSpeed;

        controller.Move(moveDirection * Time.deltaTime); */
/*     }
    private void Idle()
    {
        anim.SetFloat("Speed", 0);
    }
    private void Walk()
    {
        moveSpeed = walkSpeed;
        anim.SetFloat("Speed", 0.5f);
    }

     */
}