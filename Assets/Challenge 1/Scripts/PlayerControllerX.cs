
//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 28/09/2022

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Clase PlayerControllerX
*
*author: José Guillermo Balderas Zamora
*
* Clase PlayerControllerX da soporte al jugador para poder mover al objeto de
* tipo avion con el cual sera el encargado del juego.
**/

public class PlayerControllerX : MonoBehaviour
{

    // Variable tipo float que guarda la velocidad
    public float speed;

    // Variable tipo float que guarda la velocidad
    public float rotationSpeed;

    // Variable tipo float 
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void FixedUpdate()
    {

        // Codigo que obtiene el movimiento vertical del jugador
        verticalInput = Input.GetAxis("Vertical");

        // Realiza que el avion tenga una velocidad que sea constante al moverse
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        // Realiza el movimiento del avion segun el jugador lo requiera (arriba o abajo)
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
