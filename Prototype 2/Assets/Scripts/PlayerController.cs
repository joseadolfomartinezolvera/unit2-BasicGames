using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hecho por Jose Adolfo Martinez Olvera.


public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float seed = 15.0f;      //Variable de velocidad 
    public float xRange = 25;       //variable del rango del que se puede mover el jugador dentro del valor X 


    public GameObject projectilPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        //Mantiene al jugador dentro de los limites de la pantalla
        if (transform.position.x < -xRange)
        { 
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        { 
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //permite mover al jugador de izquierda a derecha 
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * seed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }
    }
}
