using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    //this code is used for a lantern that can be picked up 
    //when that happens the light scales down
    
    private float timer = 0;
    private Vector3 scale;
    public Transform target;
    public Transform lantern;
    public GameObject player;
    // Update is called once per frame
    
    void Start()
    {
        transform.position = lantern.position;
        scale = new Vector3(transform.localScale.x * 2.2f, transform.localScale.y * 2.2f, transform.localScale.z);
        transform.localScale = scale;
    }

    void Update()
    {
        
        if (player.tag == "PlayerLantern")
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 20 * Time.deltaTime);
            timer += Time.deltaTime;

            for (int i = 80; i > timer; i--)
            {
                transform.localScale = scale;
                scale = scale / 1.000003f;
                Debug.Log(transform.localScale);
            }
        }

    }


    //this code scales the fog of war to act as the lantern losing strength 
    //it is also not optimized at all

    //public Transform target;
    //private Vector3 scale;
    //private float timer;
    //void Start()
    //{
    //    scale = new Vector3(transform.localScale.x * 2.2f, transform.localScale.y * 2.2f, transform.localScale.z);
    //    transform.localScale = scale;
    //}

    // void Update()
    //{
    //    timer += Time.deltaTime;

    //    for (int i = 80; i > timer; i--)
    //    {
    //        transform.localScale = scale / 1.000011f;
    //        scale = scale / 1.000011f;
    //        Debug.Log(transform.localScale);
    //    }
    //    transform.position = Vector3.MoveTowards(transform.position, target.position, 20 * Time.deltaTime);

    //}
}
