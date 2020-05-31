using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        MoveBallOnSpawn();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        speed += 0.5f;
    }

    private void MoveBallOnSpawn()
    {
        var directionChoice = Random.Range(0, 20);
        var directionX = Random.Range(2, 10);
        var directionY = Random.Range(2, 10);

        rigidBody = GetComponent<Rigidbody2D>();

        if (directionChoice <= 5)
        {
            rigidBody.velocity = new Vector2(directionX, directionY) * speed;
        }
        else if (directionChoice > 5 && directionChoice <= 10)
        {
            rigidBody.velocity = new Vector2(directionX, directionY) * speed;
        }
        else if (directionChoice > 10 && directionChoice <= 15)
        {
            rigidBody.velocity = new Vector2(directionX, directionY) * speed;
        }
        else
        {
            rigidBody.velocity = new Vector2(directionX, directionY) * speed;
        }
    }
}