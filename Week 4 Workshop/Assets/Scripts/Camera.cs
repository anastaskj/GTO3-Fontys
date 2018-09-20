using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    
    public GameObject player;

    private Vector3 _offset;

    // Use this for initialization
    void Start()
    {
        this._offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + this._offset;
    }
}
