using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    
    void Start()
    {

    }
    
    public Vector2 GetMovementDirection()
    {
        if (Input.touchCount == 0)
            return Vector2.zero;

        Touch touch = Input.GetTouch(0);

        Vector2 screenPosition = touch.position;
        Vector2 middleOfScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);

        Vector2 positionDelta = screenPosition - middleOfScreen;

        return positionDelta.normalized;
    }

    public int Tap()
    {
        if (Input.touchCount == 0)
            return 0;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Ended)
        {
            if (touch.position.x < Screen.width / 8)
            {
                return -1;
            }
            else if (touch.position.x > Screen.width - Screen.width / 8)
            {
                return 1;
            }
        }
        return 0;
    }
    
    void Update()
    {

    }
}
