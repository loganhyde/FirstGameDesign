
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
public float movementSpeed;
public Rigidbody2D rb = new Rigidbody2D();

public float jumpForce = 10f;

float mx;

private void Update() {
    mx = Input.GetAxisRaw("Horizontal");

    if (Input.GetButtonDown("Jump")) {
        Jump();
    }

}
private void FixedUpdate() {
    Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

    rb.velocity = movement;
 }

    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

}













//---------------------------------------------------------------



/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
public float movementSpeed;
public Rigidbody2D rb = new Rigidbody2D();
float mx;

private void Update() {
    mx = Input.GetAxisRaw("Horizontal");
}
private void FixedUpdate() {
    Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

    rb.velocity = movement;
 }
}


*/

