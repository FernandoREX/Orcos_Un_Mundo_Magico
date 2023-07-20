using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugador : MonoBehaviour
{
    [SerializeField] float velocidad = 10f; // Declaramos la velocidad de movimiento
    [SerializeField] float FuerzaSalto = 5f; // Declaramos la fuerza con la que nuestro personaje podrá saltar
    bool EnElPiso = true; // Dectecta si el personaje está en el suelo, evita saltar infinitamente
    float IncrementoVelocidad = 0.0001f; // Es el incremento de velocidad 

    [SerializeField] Camera camara; // Creamos un objeto cámara para poder modificar sus propiedades

    [SerializeField] Animator animator; // El componente animator que está dentro del objeto jugador

    [SerializeField] GameObject Jugador; // El objeto jugador

    [SerializeField] GameObject casa; // El prefabricado llamado casa
    float tiempo; // Variable que nos ayudará a destruir el objeto casa

    void Start()
    {
        animator = GetComponent<Animator>(); // Referenciamos el componente Animator del objeto Jugador
    }

    void Update()
    {
        MoverJugador();
        MoverCamara();
        Saltar();
        DestruirCasa();
    }

    // Movemos al jugador en el eje X infinitamente y aumentamos poco a poco su velocidad
    void MoverJugador()
    {
        velocidad += IncrementoVelocidad;
        transform.position += transform.right * Time.deltaTime * velocidad;
        animator.SetTrigger("Caminando"); // Activamos la animación de caminar
    }

    // Anclamos la cámara al eje Y para evitar movimientos bruscos al momento de saltar
    void MoverCamara()
    {
        camara.transform.position = new Vector3(transform.position.x, 1, -11);
    }

    // Ejecuta el salto si se ha presionado el botón de salto
    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Space) && EnElPiso == true)
        {
            Salto();
            animator.SetTrigger("Salto"); // Activamos la animación de salto
        }
    }

    // Salta aplicando una fuerza hacia arriba al personaje
    void Salto()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
        EnElPiso = false;
    }

    // Destruimos el objeto casa después de un tiempo (5 segundos)
    void DestruirCasa()
    {
        tiempo += Time.deltaTime;
        if (tiempo > 5)
        {
            Destroy(casa);
        }
    }

    // Función de Unity que nos permite detectar colisiones
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el personaje colisiona con el suelo, cambiamos EnElPiso a true
        if (collision.gameObject.tag == "Suelo")
        {
            EnElPiso = true;
        }

        // Si el personaje colisiona con un enemigo se destruye el objeto Jugador y cambiamos de escena
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(Jugador);
            SceneManager.LoadScene("Muerte");
        }
    }
}
