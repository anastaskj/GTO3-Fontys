using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetails : MonoBehaviour {


   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    //main problem for now - every touch is a tap, dont know of a way to differentiate 

    public bool Tap()
    {
        //if the touch count is 0, return false - no touches
        //if its more than 0, there has been a touch
        //you need to Get the details of that touch and use them to find out if the tap is actually a tap(it can be a double tap, a hold, a drag, etc)
        //if the is touch that is ending, return true, there has been a tap (at least one)

        if (Input.touchCount == 0)
        {
            return false;
        }
        Touch tap = Input.GetTouch(0); //remember that the 0 is an index
        if (tap.phase == TouchPhase.Ended)
        {
                return true;
        }
        return false;
    }

    public bool Swipe()
    {
        //you need to make sure that there has been a touch, maybe use Tap() to confirm it hasnt been just a tap
        //or just make sure it hasn't TouchPhase.Ended

        if (Input.touchCount == 0) //no touches, cant have a swipe
        {
            return false;
        }
        Touch swipe = Input.GetTouch(0);
        if (swipe.phase == TouchPhase.Moved && swipe.phase != TouchPhase.Ended) //test, kinda works
        {
            return true;
        }
        return false;
    }

    public bool Hold()
    {
        //for holding i think TouchPhase.Stationary should do the job
        if (Input.touchCount == 0) 
        {
            return false;
        }
        Touch hold = Input.GetTouch(0);
        if (hold.phase == TouchPhase.Stationary)
        {
                return true;
        }
        return false;
    }

    public Vector2 GetMovementDirection()
    {
        if (Input.touchCount == 0) return Vector2.zero;
        Touch touch = Input.GetTouch(0);

        Vector2 screenPosition = touch.position;
        Vector2 middleofscreen = new Vector2(Screen.width / 2f, Screen.height / 2f);

        Vector2 positionDelta = screenPosition - middleofscreen;
        return positionDelta;
    }


}
