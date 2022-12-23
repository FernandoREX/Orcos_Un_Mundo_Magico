using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    // La prefab del objeto que quieres generar aleatoriamente
    public GameObject[] Matriz;

    public float PosY = -2.25f;
    public float PosZ = 0f;

    // El intervalo de tiempo entre generaciones de objetos (en segundos)
    public float interval = 6;

    // La variable para almacenar el tiempo transcurrido desde la �ltima generaci�n de objetos
    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        // Aumenta el tiempo transcurrido en cada frame
        elapsedTime += Time.deltaTime;

        int longitudM = Matriz.Length;

        // Genera un n�mero aleatorio entre 0 y 1
        int x = Random.Range(0, longitudM);

        // Si ha pasado el tiempo suficiente desde la �ltima generaci�n de objetos
        if (elapsedTime >= interval)
        {
            // Asigna la posici�n en el eje Y al objeto vac�o
            transform.position = new Vector3(transform.position.x, PosY, PosZ);

            // Crea una instancia del objeto a partir de la prefab en la posici�n del objeto vac�o
            Instantiate(Matriz[x], transform.position, Quaternion.identity);

            // Resetea el tiempo transcurrido a cero
            elapsedTime = 0;
        }
    }
}

