/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al poder ver al avion moviendose, ya que
* script ayuda a que la camara siga al avion.
*/


//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Clase FollowPlayerX
*
*author: José Guillermo Balderas Zamora
*
* Clase FollowPlayerX que ayuda poder visualizar el avion moverse. Ademas la clase ayuda a que la camara siga al avion.
**/
public class FollowPlayerX : MonoBehaviour
{
    // Variable tipo GameObject
    public GameObject plane;

    // se crea una nueva instancia de Vector3
    private Vector3 offset = new Vector3(30,0,10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Codigo que realiza el movimiento de la camara para dar seguimiento al avion
        transform.position = plane.transform.position + offset;
    }
}
