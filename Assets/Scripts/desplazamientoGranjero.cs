using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desplazamientoGranjero : MonoBehaviour
{
    public float velocidad;
    public GameObject proyectilPrefab;
    public GameObject proyectil2Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //Disparo de pizzas al pulsar sobre la tecla del espacio:
            if(Input.GetKeyDown(KeyCode.Space)) {
                //Generamos copias del prefab pizza
                //hacemos copias de proyectilPrefab, desde la posición del granjero, y sin rotación
                //el proyectilPrefab no tiene rotación, si no que mantiene la que ya tiene
                Instantiate(proyectilPrefab, transform.position, proyectilPrefab.transform.rotation);
            }

            //Lanzamiento de galletas:
            if(Input.GetKeyDown(KeyCode.Q)) {
                Instantiate(proyectil2Prefab, transform.position, proyectil2Prefab.transform.rotation);

            }
        
            if(Input.GetKey(KeyCode.RightArrow)) {
                
                    transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            }
            if(Input.GetKey(KeyCode.LeftArrow)) {
                
                transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            }
            //Si nos salimos por la izquierda (x<-20)
            if(transform.position.x < -20) {
                //mantenemos al granjero en el límite:
                transform.position = new Vector3(-20,transform.position.y, transform.position.z);
            }
            //Si nos salimos por la derecha (x>20)
            if(transform.position.x > 20) {
                //mantenemos al granjero en el límite:
                transform.position = new Vector3(20,transform.position.y, transform.position.z);
            }
        
    }
}
