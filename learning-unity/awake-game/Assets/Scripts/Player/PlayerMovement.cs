using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float dodgeSpeed;
    public float dodgeTime;
    public float dodgeInterval;
    public static bool isDodging;
    public static bool isWalking;

    bool canDodge;

    Rigidbody2D rb;
    float movementX;
    float movementY;
    Vector2 direction;

    void Awake()
    {
        isDodging = false;
        isWalking = false;
        canDodge = true;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown("space") && canDodge)
        {
            StartCoroutine(Dodge());
        }

        if (movementX != 0 && movementY != 0)
        {
            movementX = movementX / 2 * Mathf.Sqrt(2);
            movementY = movementY / 2 * Mathf.Sqrt(2);
        }
        if (movementX != 0 || movementY != 0)
            isWalking = true;
        else
            isWalking = false;

        if (!isDodging)
            direction = new Vector2(movementX, movementY);
    }

    // physics
    void FixedUpdate()
    {
        if (isDodging)
        {
            rb.AddForce(direction * dodgeSpeed);
        }
        else
        {
            rb.velocity = new Vector2(movementX, movementY) * moveSpeed;
        }
    }

    IEnumerator Dodge()
    {
        isDodging = true;
        canDodge = false;
        yield return new WaitForSeconds(dodgeTime);
        isDodging = false;
        yield return new WaitForSeconds(dodgeTime + dodgeInterval);
        canDodge = true;
    }
}
