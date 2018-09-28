using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 movement = Vector2.zero;
    public Vector2 check = Vector2.zero;
    public PlayerInput input;
    private Rigidbody2D character;
    private Animator anim;
    public OnTouch lant;
   
  
    public float movementSpeed = 100;

    void Start()
    {
        input = GetComponent<PlayerInput>();
        character = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        lant = GetComponent<OnTouch>(); 
    }

    void FixedUpdate()
    {
        int tapDirection = this.input.Tap();
        movement = new Vector2(tapDirection , 0) * Time.deltaTime * this.movementSpeed;

        if (lant.Lantern())
        {
            anim.SetBool("PickedUp", true);
        }
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
    
    void Update()
    {

    }
}
