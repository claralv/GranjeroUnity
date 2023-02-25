using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirFueraEscena : MonoBehaviour
{
    private float limitesuperior = 30;
    private float limiteinferior = -10;
    
    void Start()  {
       
        
    }
   
    // Update is called once per frame
    void Update()
    {
        //Destruimos pizza cuando sobrepase el limite superior:
        if(transform.position.z > limitesuperior) {
            Destroy(gameObject);
        }

        //Destruimos los objetos animales cuando se salgan del limite inferior:
        if(transform.position.z < limiteinferior) {
            Destroy(gameObject);
           
            Debug.Log("FIN DE PARTIDA");

        }

    }
}
