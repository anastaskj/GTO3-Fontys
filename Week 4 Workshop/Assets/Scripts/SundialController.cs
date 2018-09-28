using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SundialController : MonoBehaviour {

    public Transform player;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerLantern"))
        {
            Debug.Log("works");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(player.position - transform.position);

        float x = player.position.x - transform.position.x;
        if (x>-1.7f && x<-1.4f)
        {
            anim.SetFloat("Proximity", 0.9f);
        }
        else if (x > -1.3f && x < -1.1f)
        {
            anim.SetFloat("Proximity", 1.9f);
        }
        else if (x > -1.0f && x < -0.8f)
        {
            anim.SetFloat("Proximity", 2.9f);
        }
        else if (x > -0.7f && x < -0.4f)
        {
            anim.SetFloat("Proximity", 3.9f);
        }
        else if (x>-0.3f && x<-0.1f)
        {
            anim.SetFloat("Proximity", 4.9f);
        }
        else if (x > 0.0f && x < 0.2f)
        {
            anim.SetFloat("Proximity", 5.9f);
        }
        else if (x > 0.3f && x < 0.6f)
        {
            anim.SetFloat("Proximity", 6.9f);
        }
        else if (x > 0.7f && x < 1.0f)
        {
            anim.SetFloat("Proximity", 7.9f);
        }
        else if (x > 1.1f && x < 1.3f)
        {
            anim.SetFloat("Proximity", 8.9f);
        }
    }
}
