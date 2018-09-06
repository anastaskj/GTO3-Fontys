using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float MovementSpeed = 1;
    public InputDetails _input;
    SpriteRenderer sprite;
    // Use this for initialization
    void Start () {
        _input = GetComponent<InputDetails>();
        sprite = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        if (_input.Tap()) //there has been a tap
        {
            //move the ghost to the position of the tap
            Vector2 movementdirection = _input.GetMovementDirection() * Time.deltaTime * MovementSpeed;
            transform.Translate(movementdirection);
        }
        if (_input.Swipe()) //I love how buggy this is
        {
            if (sprite.flipX)
            {
                sprite.flipX = false; 
            }
            else
            {
                sprite.flipX = true;
            }
        }
        if (_input.Hold()) 
        {
            sprite.color = Color.magenta;
           
        }
        else
        {
            sprite.color = Color.white;
        }
    }
}
