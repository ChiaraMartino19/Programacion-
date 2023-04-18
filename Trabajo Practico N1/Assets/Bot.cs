using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private GameObject  playerscript;
    string nombreJugador;
    string nombreActual;
    public string nuevoNombre = "Bot";


    void Start()
    {
        playerscript = GameObject.FindGameObjectWithTag("Player");
      
    }

    public void Saludar()
    {
        //Hacemos un Set para modificar el nombre actual del jugador
        nombreJugador = playerscript.GetComponent<MovementPlayer>().Nombre = nuevoNombre;
        Debug.Log("Hola" + nombreActual + "Ahora te llamas :" + nuevoNombre);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Hacemos un Get para obtener el nombre actual del jugador
            nombreActual = playerscript.GetComponent<MovementPlayer>().Nombre;
            Saludar();
        }
    }
}
