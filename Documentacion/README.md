# Documentación del Proyecto

En esta sección, encontrarás la documentación detallada de los scripts y componentes utilizados en el desarrollo del juego.

## Documentación de Scripts

En este proyecto, hemos creado varios scripts en C# para controlar diferentes aspectos del juego. A continuación, se presenta una breve descripción de cada uno de ellos:

1. [jugador.cs](./Assets/Scripts/jugador.cs): Este script controla el comportamiento del jugador principal. Permite el movimiento horizontal, salto, animaciones y colisiones con objetos enemigos. Además, se encarga de destruir un objeto "casa" después de un tiempo específico.

2. [CambioESCENA.cs](./Assets/Scripts/CambioESCENA.cs): Este script permite cambiar entre diferentes escenas del juego. Al adjuntar este script a un objeto en la escena, se puede utilizar como botón o gatillo para realizar la transición.

3. [Puntaje.cs](./Assets/Scripts/Puntaje.cs): Controla el puntaje del jugador y la recolección de objetos "oro". El puntaje del jugador se basa en su posición en el eje X, y se cuenta la cantidad de objetos "oro" recolectados. Cuando el jugador colisiona con un objeto "oro", se incrementa la cantidad de oro recolectado y el objeto se destruye.

4. [Generador.cs](./Assets/Scripts/Generador.cs): Este script genera objetos de manera aleatoria en el juego, como piso, recolectables y escenarios. Se encarga de instanciar objetos prefabricados en posiciones específicas y con un intervalo de tiempo entre generaciones.

Cada archivo de script está acompañado por una detallada documentación en formato Markdown, donde se explican sus funciones, variables y su uso en el juego. Te invitamos a explorar cada uno de ellos para obtener una comprensión completa de su funcionalidad.



