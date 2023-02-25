using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour

{
    public GameObject[] animalesPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarAnimalAleatorio", 2.0f, 1.5f );
    }
    
    void GenerarAnimalAleatorio() {
        //Devuelve un entero con una posición del array aleatoria:
        int indexAnimal = Random.Range(0,animalesPrefabs.Length);
        //Creamos una nueva posición aleatoria en el rango del plano (-20,20) del eje x
        //y en la posición 20 del eje z:
        Vector3 posGenerador = new Vector3(Random.Range(-20,20),0,20);
        //Genera un animal:
        Instantiate(animalesPrefabs[indexAnimal],posGenerador,animalesPrefabs[indexAnimal].transform.rotation);
    }
}
