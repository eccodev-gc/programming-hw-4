using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    BoxCollider2D collider; // macro for BoxCollider2D
    SpriteRenderer sr; // macro for SpriteRenderer to equal "sr"

    bool isCyan = true;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>(); // getting boxcollider2d
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
        Debug.Log(mouse);
    }
}
