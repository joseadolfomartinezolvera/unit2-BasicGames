using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// hecho por Jose Adolfo Martinez Olvera.


public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30;    //Variable que inidica el limite superior al que puede llegar la comidad 
    private float lowerBound = -10; //variable que indica el limite interior al que pueden llegar los animales 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //parte encargada de destruir los GameObject cuando estos don > o < dependiendo si es animal o su comida
      if (transform.position.z > topBound)
      {
          Destroy(gameObject);
      } else if (transform.position.z < lowerBound)
      {
           //muestra un pequeño mensaje de "fin del juego"
          Debug.Log("Fin del Juego");
          Destroy(gameObject);
      }
    }
}
