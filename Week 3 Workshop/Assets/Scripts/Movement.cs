using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector2 movement = Vector2.zero;
    public Vector2 check = Vector2.zero;
    public PlayerInput input;
    private Rigidbody2D character;
    private Animator anim;
    public Triggers enemy;
    public float movementSpeed = 50;

    void Start()
    {
        input = GetComponent<PlayerInput>();
        character = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        enemy = GetComponent<Triggers>();
    }

    void FixedUpdate()
    {
        int tapDirection = this.input.Tap();
        movement = new Vector2(tapDirection * 5, 0) * Time.deltaTime * this.movementSpeed;
        check = new Vector2(-tapDirection, 0);
        anim.SetFloat("Speed", tapDirection);
        character.velocity = movement;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pillars"))
        {
            enemy.Chase();
            Debug.Log("enabled");
        }
    }

    void Update()
    {

    }
}
