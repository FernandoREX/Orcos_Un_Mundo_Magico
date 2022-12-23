using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text puntaje; //Variable de texto, la usaremos para mostrar el puntaje

    //Variables para realizar la recoleccion de oro
    public GameObject OroM; //Objeto de las bolsas de oro
    int Oro = 0; //Cantidad de oro recolectado
    public Text CantidadOro; //Variable de texto, la usaremos para mostrar la cantidad de oro

    // Update is called once per frame
    void Update()
    {
        // El puntaje esta dado por la posicion del jugador en el eje X
        puntaje.text = "Puntaje: " + Mathf.Floor(transform.position.x);  
        //Mostramos la cantidad de oro recolectado
        CantidadOro.text = ": " + Oro;
    }

    //Funcion que permite medir coliciones usando "Triger"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si coliciona con un objeto "oro"
        if (collision.gameObject.tag == "oro")
        {
            Oro++; //Aumenta el oro recolectado
            Destroy(collision.gameObject); //Destruye el objeto con que coliciono (el objeto oro)
        }
    }
}
