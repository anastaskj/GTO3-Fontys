using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehavior : MonoBehaviour {


    public bool startedDoubleTap;
    public float timeSinceFirstTap;


    public float TapInterval = 0.5f;
    // Use this for initialization
    void Start () {
      
	}

    public bool Drag()
    {
        if (Input.touchCount == 0) return false;
        return true;
    }

    public Vector2 GetMovementDirection()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    Vector2 screenPosition = Input.mousePosition;
        //}

        if (Input.touchCount == 0) return Vector2.zero;
        Touch touch = Input.GetTouch(0);

        Vector2 screenPosition = touch.position;
        Vector2 middleofscreen = new Vector2(Screen.width / 2f, Screen.height / 2f);

        Vector2 positionDelta = screenPosition - middleofscreen;
        return positionDelta;
    }

    public bool Tap()
    {
        if (Input.touchCount == 0) return false;
        
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                //startedDoubleTap = true;
                return true;
            }
         return false;
    }

    public bool DoubleTap()
    {
     
        if (Input.touchCount == 0) return false;
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Ended)
        {
            if (startedDoubleTap)
            {
                if (timeSinceFirstTap < TapInterval)
                {
                    startedDoubleTap = false;
                    timeSinceFirstTap = 0;
                    return false;
                }
            }
            else
            {
                startedDoubleTap = true;
                return false;
            }
        }
        return false;
    }

   
    // Update is called once per frame
    void Update () {
       
        if (startedDoubleTap)
        {
            timeSinceFirstTap += Time.deltaTime;
            if (timeSinceFirstTap > TapInterval)
            {
                timeSinceFirstTap = 0;
                startedDoubleTap = false;
            }
        }
        
        if (Input.touchCount == 0) return;
        //Touch touch = Input.GetTouch(0);


    }



   










}
