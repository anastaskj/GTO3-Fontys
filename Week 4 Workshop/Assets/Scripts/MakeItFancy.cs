using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeItFancy : MonoBehaviour {

    void Update()
    {
        transform.Rotate(new Vector2(15, 30) * Time.deltaTime);
    }
}
