using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAnimales : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 3;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    }
}
