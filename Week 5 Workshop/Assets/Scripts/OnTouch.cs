using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnTouch : MonoBehaviour {

    private bool pickedUp = false;
    public Button SunRiddle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(UnityEngine.Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), Vector2.zero);
                // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
                if (hitInfo)
                {
                    Debug.Log(hitInfo.transform.gameObject.name);
                    if (hitInfo.transform.gameObject.name == "Lantern")
                    {
                        hitInfo.transform.gameObject.SetActive(false);
                        pickedUp = true;
                        this.tag = "PlayerLantern";
                    }
                    if (this.tag == "PlayerLantern") //can only move on if player has the lantern
                    {
                        if (hitInfo.transform.gameObject.name == "Door Bedroom")
                        {
                            this.transform.position = new Vector3(12.635f, 1.76f, -6.08f);
                        }
                        if (hitInfo.transform.gameObject.name == "Sundial")
                        {
                            
                            SunRiddle.image.enabled= true;
                        }
                        
                       
                        
                    }
                }
            }
        }
    }

    public bool Lantern()
    {
        return pickedUp;
    }
}
