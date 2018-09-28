using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 _offset;

    public GameObject player;
    public GameObject sundial;


    // Use this for initialization
    void Start()
    {
        this._offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + this._offset;
        if (sundial.CompareTag("SunInRange"))
        {
            this.transform.position = sundial.transform.position + new Vector3(0, 0.5f, -6f);
        }
    }
}
