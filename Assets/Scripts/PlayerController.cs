using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float maxMoveSpeed = 2f;
    private float moveSpeed;

    Animator animator;

	void Start () {

        animator = GetComponent<Animator>();
        moveSpeed = 0;
	}
	
	void Update () {

        // Move (Keyboard)
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeed = maxMoveSpeed;
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveSpeed = maxMoveSpeed;
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        // Stop Moving (Keyboard)
        if (Input.GetKeyUp(KeyCode.D))
        {
            moveSpeed = 0;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            moveSpeed = 0;
        }

        // Animator
        animator.SetFloat("Speed", moveSpeed);
	}
}
