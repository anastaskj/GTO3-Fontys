using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float MovementSpeed = 1;
    public InputBehavior _input;
	// Use this for initialization
	void Start () {
        _input = GetComponent<InputBehavior>();
	}
	
	// Update is called once per frame
	void Update () {

        if (_input.Drag())
        {
            Vector2 movementdirection = _input.GetMovementDirection();
            Vector3 movement = new Vector3(movementdirection.x, 0, movementdirection.y) * Time.deltaTime * MovementSpeed;
            transform.Translate(movement);
        }
        if (_input.Tap())
        {
            Debug.Log("Move");
        }
        if (_input.DoubleTap())
        {
            Debug.Log("Dash");
        }
       
	}
}
