using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 direction = Vector2.right;
    float speed = 6.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Uncomment to change direction of the ball using trigonometry
        float angle = 30.0f * Mathf.Deg2Rad;
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Checking x coordinate
        if (transform.position.x > 10.0f)
        {
            direction.x = -direction.x;
        }
        if (transform.position.x < -10.0f)
        {
            direction.x = -direction.x;
        }
        // Checking y coordinate
        if (transform.position.y > 10.0f)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y < -10.0f)
        {
            direction.y = -direction.y;
        }
        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        Debug.Log(change);
        transform.position += change;
    }
}
