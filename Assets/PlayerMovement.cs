using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private Animator animator;

    private float xInput;
    private float yInput;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("123");
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        if (xInput != 0)
        {
            body.velocity = new Vector2(xInput * 4, body.velocity.y);
            animator.Play("PlayerMove");
        }
        else
        {
            animator.Play("PlayerIdle");
        }
        if (yInput > 0)
        {
            body.velocity = new Vector2(body.velocity.x, yInput * 10);
        }

    }
}
