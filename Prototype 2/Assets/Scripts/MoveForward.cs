using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hecho por Jose Adolfo Martinez Olvera.


public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
