using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    //this code is for a static lantern that flickers

    //[Range(0.05f, 0.2f)]
    //public float flickTime;

    //[Range(0.02f, 0.5f)]
    //public float addSize;

    //float timer = 0;
    //private bool bigger = true;

    //public Transform target;

    //// Update is called once per frame
    //void Update()
    //{
    //    timer += Time.deltaTime;
    //    if (timer < flickTime)
    //    {

    //        if (bigger)
    //        {
    //            transform.localScale = new Vector3(transform.localScale.x + addSize, transform.localScale.y + addSize, transform.localScale.z);

    //        }
    //        else
    //        {
    //            transform.localScale = new Vector3(transform.localScale.x - addSize, transform.localScale.y - addSize, transform.localScale.z);

    //        }

    //        timer = 0;
    //        bigger = !bigger;
    //    }

    //    transform.position = Vector3.MoveTowards(transform.position, target.position, 20 * Time.deltaTime);
    //}


    //this code scales the fog of war to act as the lantern losing strength 
    //it is also not optimized at all

    public Transform target;
    private Vector3 scale;
    private float timer;
    void Start()
    {
        scale = new Vector3(transform.localScale.x * 2.2f, transform.localScale.y * 2.2f, transform.localScale.z);
        transform.localScale = scale;
    }

     void Update()
    {
        timer += Time.deltaTime;

        for (int i = 80; i > timer; i--)
        {
            transform.localScale = scale / 1.000011f;
            scale = scale / 1.000011f;
            Debug.Log(transform.localScale);
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, 20 * Time.deltaTime);

    }
}
