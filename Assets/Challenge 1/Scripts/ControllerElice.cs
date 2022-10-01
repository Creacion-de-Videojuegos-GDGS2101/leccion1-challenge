//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022


// IMportaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Clase PlayerController
*
*author: José Guillermo Balderas Zamora
*
* Clase PlayerController que ayuda a que la elice del avion haga su movimiento
**/
public class ControllerElice : MonoBehaviour
{   
    // Variable tipo float que guarda la velocidad del giro
    public float velocidadGiro = 1200.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Realiza el movimiento de la elice del avion.
        transform.Rotate(Vector3.forward * velocidadGiro);
    }
}
