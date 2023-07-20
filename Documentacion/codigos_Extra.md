# Documentación del Código "CambioESCENA.cs"

Este script es utilizado en el motor de juegos Unity para cambiar de una escena a otra en el juego. La función proporcionada en el script permite realizar la transición entre diferentes escenas de manera sencilla.

## Componentes

### 1. CambioESCENA

Este es el componente principal que contiene el script "CambioESCENA.cs". Se puede adjuntar a cualquier objeto en la escena que actúe como botón o gatillo para el cambio de escena.

## Métodos

### 1. `CambioEscena(string Nombre)`

Esta es una función pública que permite cambiar de una escena a otra en el juego. El parámetro `Nombre` es un string que indica el nombre de la escena a la que se desea cambiar.

## Uso y Consideraciones

1. Asigna el script "CambioESCENA.cs" como componente a un objeto en la escena que actúe como botón o gatillo para el cambio de escena.

2. Asegúrate de que el parámetro `Nombre` en la función `CambioEscena()` coincida con el nombre de la escena que deseas cargar. Este nombre debe estar escrito exactamente como aparece en la lista de escenas del proyecto.

3. Si deseas cambiar de escena desde un evento específico, como al hacer clic en un botón, simplemente vincula la función `CambioEscena()` a dicho evento utilizando el Editor de Unity.

4. Es importante tener al menos dos escenas en el proyecto para que el cambio de escena sea efectivo. Si solo tienes una escena, el cambio no tendrá ningún efecto.

5. Asegúrate de que las escenas estén correctamente configuradas en el proyecto para que el cambio de una escena a otra funcione correctamente.

¡Con este script, puedes implementar fácilmente transiciones entre diferentes partes del juego y crear una experiencia más dinámica para los jugadores!


# Documentación del Código "Puntaje.cs"

Este script es utilizado en el motor de juegos Unity para controlar el puntaje y la recolección de oro en el juego. El script muestra el puntaje del jugador en función de su posición en el eje X y también cuenta la cantidad de objetos "oro" recolectados.

## Variables Públicas

### 1. `puntaje` (`[SerializeField] Text puntaje`)

Una variable de tipo Text que se utilizará para mostrar el puntaje del jugador en la interfaz del juego.

### 2. `OroM` (`[SerializeField] GameObject OroM`)

Una referencia al objeto de las bolsas de oro en la escena. Se utiliza para detectar colisiones con las bolsas de oro y recolectarlas.

### 3. `Oro` (`int Oro = 0`)

Una variable entera que almacena la cantidad de oro recolectado por el jugador.

### 4. `CantidadOro` (`[SerializeField] Text CantidadOro`)

Una variable de tipo Text que se utilizará para mostrar la cantidad de oro recolectado en la interfaz del juego.

## Métodos

### 1. `Update()`

Este método se llama una vez por cuadro de actualización del juego. En Update(), se actualiza el puntaje mostrado en la interfaz de acuerdo con la posición del jugador en el eje X y se muestra la cantidad de oro recolectado.

### 2. `OnTriggerEnter2D(Collider2D collision)`

Este es un método que permite medir colisiones usando "Trigger" en Unity. Se ejecuta cuando el objeto colisiona con un Collider2D que tiene el atributo "Is Trigger" habilitado.

En este caso, se utiliza para detectar cuando el jugador colisiona con un objeto "oro". Si colisiona con un objeto "oro", se incrementa la cantidad de oro recolectado y se destruye el objeto que representa el oro en la escena.

## Uso y Consideraciones

1. Asigna el script "Puntaje.cs" como componente a un objeto en la escena que actúe como controlador del puntaje y la recolección de oro.

2. Asegúrate de que la variable `puntaje` esté vinculada a un elemento de interfaz de texto (UI Text) en el juego para que el puntaje se muestre correctamente.

3. Asegúrate de que la variable `OroM` esté vinculada al objeto que representa las bolsas de oro en la escena para que se pueda recolectar el oro.

4. Si deseas personalizar la forma en que se muestra el puntaje y la cantidad de oro recolectado, puedes modificar las líneas de código que actualizan los Texto del puntaje y la cantidad de oro en el método `Update()`.

5. Puedes ajustar la cantidad de oro recolectado según tus necesidades, por ejemplo, si deseas que el jugador recolecte más oro para ganar puntos adicionales.

Con este script, podrás implementar un sistema de puntaje y recolección de objetos en tu juego y crear una experiencia más interactiva para los jugadores. ¡Diviértete experimentando con Unity y desarrollando tu juego!
