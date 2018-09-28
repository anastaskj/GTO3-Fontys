using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLook : MonoBehaviour {
    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerLantern"))
        {
            if (anim.GetBool("MovedToRight"))
            {
                anim.SetBool("MovedToRight", false);
            }
            else
            {
                anim.SetBool("MovedToRight", true);
            }
        }
    }
}
