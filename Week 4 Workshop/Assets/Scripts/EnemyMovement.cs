using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Animator anim;
    private Rigidbody2D enemy;
    public float speed;
    public Transform player;
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
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("HasSpawned", true);
            Chase();
        }
    }

    public void Chase()
    {
        float checker = Vector2.Distance(transform.position, player.position);
        
        
        if (checker > 2)
        {
            enemy.velocity = new Vector2(-speed, 0);
            
            Debug.Log(enemy.velocity);
        }

    }
}
