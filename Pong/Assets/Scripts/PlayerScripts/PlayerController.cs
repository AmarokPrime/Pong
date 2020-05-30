using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate.
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(0, verticalInput);

        if (verticalInput != 0)
        {
            rigidBody.velocity = movement * speed;
            rigidBody.drag = 0;
            rigidBody.angularDrag = 0;
        }
        else
        {
            rigidBody.velocity = new Vector2(0, 0);
            rigidBody.drag = 1000;
            rigidBody.angularDrag = 1000;
        }
    }
}