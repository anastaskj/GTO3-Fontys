using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {

    private Animator anim;
    public Movement player;
    private Rigidbody2D enemy;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("HasSpawned", true);
            other.gameObject.SetActive(false);
        }
    }


    public void Chase()
    {
        float checker = Vector2.Distance(player.movement, player.check);
        Debug.Log("checking");
        if (checker == 2)
        {
            Debug.Log("going");
            enemy.velocity = -player.movement;
        }
       
    }
}
