using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hecho por Jose Adolfo Martinez Olvera.

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //se encarga de que cuando un objeto choca con otro estos se destruyen 
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
