using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    BoxCollider2D bcollider;
    SpriteRenderer sr;

    bool isCyan = true;

    // Start is called before the first frame update
    void Start()
    {
        bcollider = GetComponent<BoxCollider2D>(); // getting boxcollider2d
        sr = GetComponent<SpriteRenderer>(); // getting SpriteRenderer
        sr.color = Color.cyan;
        
        //if box is cyan, its cyan. if its not, its green.
        if (isCyan)
        {
            sr.color = Color.cyan;
        }
        else
        {
            sr.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse is still in screenspace
        Vector2 mouse = Input.mousePosition;

        //Converting to game world
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        //center of the rect
        float x = transform.position.x;
        float y = transform.position.y;
        float hw = bcollider.size.x * transform.localScale.x * 0.5f;
        float hh = bcollider.size.y * transform.localScale.y * 0.5f;

        //point rect test against mouse
        float xMin = x - hw;
        float yMin = y - hh;
        float xMax = x + hw;
        float yMax = y + hh;

        Debug.DrawLine(new Vector3(xMin, yMin), new Vector3(xMin, yMax), Color.red); //left
        Debug.DrawLine(new Vector3(xMax, yMin), new Vector3(xMax, yMax), Color.yellow); //right
        Debug.DrawLine(new Vector3(xMin, yMin), new Vector3(xMax, yMin), Color.blue); //top
        Debug.DrawLine(new Vector3(xMin, yMax), new Vector3(xMax, yMax), Color.green); //bottom

        Debug.Log(mouse);

    }
}
