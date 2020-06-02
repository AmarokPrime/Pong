using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigidBody;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Ball").GetComponent<Transform>();
        rigidBody.constraints = RigidbodyConstraints2D.FreezePositionX;
        rigidBody.freezeRotation = true;
    }

    void FixedUpdate()
    {
        var targetPosition = new Vector2(0, target.position.y);
        var paddleMovement = new Vector2(20.04f, transform.position.y);

        rigidBody.drag = 35;
        rigidBody.angularDrag = 35;

        transform.position = Vector2.MoveTowards(paddleMovement, targetPosition, 75.0f * Time.deltaTime);
    }
}
