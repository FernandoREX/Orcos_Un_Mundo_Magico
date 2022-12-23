using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugador : MonoBehaviour
{
    public float velocidad = 10f; //Declaramos la velocidad de moviminto
    public float FuerzaSalto = 5f; //Declaramos la fuerza con la que nuestro personaje podra saltar
    bool EnElPiso = true; // Dectecta si el personaje esta en el suelo, evita saltar infinitamente
    float IncrementoVelocidad = 0.0001f; //Es el incremento de velocidad 

    public Camera camara; //Creamos un objeto camara para poder modificar sus propiedades

    public Animator animator; //El componente animator que esta dentro del objeto jugador

    public GameObject Jugador; //El objeto jugador

    public GameObject casa; //El prefabricado llamado casa
    float tiempo; //Variable que nos ayudara a destruir el objetoi casa
   
    void Start()
    {
        animator = GetComponent<Animator>(); //Referenciamos el componenete Animator del objeto Jugador
    }

    void Update()
    {
        /*
         * Esta linea de codigo nos permite hacer que el jugador u objeto avance en el eje X 
         * infinitamente, ademas de aumentar poco a poco su velocidad
         */
        velocidad += IncrementoVelocidad;
        transform.position += transform.right * Time.deltaTime * velocidad; 

        /*
         * Usando el objeto camara creamos un vector en 3 dimenciones con el objetivo de 
         * anclar la camara al eje Y para evitar movimientos bruscos al momento de saltar
         */
        camara.transform.position = new Vector3(transform.position.x, 1, -11);

        // Si se ha presionado el botón de salto, ejecuta la función de salto
        animator.SetTrigger("Caminando"); //Activamos la animacion de caminar
        if (Input.GetKeyDown(KeyCode.Space) && EnElPiso == true)
        {
            Salto();
            animator.SetTrigger("Salto"); //Activamos la animacion de salto
        }

        //Destruimos el objeto casa, solo es mera estetica esta parte del codigo
        tiempo += Time.deltaTime;
        if (tiempo > 5)
        {
            Destroy(casa);
        }
    }

    /*
     * En C# tambien se pueden crear funciones, en este caso creamos una funcion para hacer que nuestro
     * personaje salte
     */
    void Salto()
    {
        // Aplica una fuerza hacia arriba al personaje
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
        EnElPiso = false;

    }

    /*
     * Funcion de unity que nos permite detectar coliciones 
     */
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
