# Documentación del Código "jugador.cs"

Este script es utilizado en el motor de juegos Unity para controlar el comportamiento del jugador principal. El script permite que el jugador se mueva horizontalmente, salte y colisione con otros objetos en el escenario. También incluye algunas animaciones y la destrucción de un objeto después de un tiempo determinado.

## Variables Públicas

### 1. `velocidad` (`[SerializeField] float velocidad = 10f`)

Una variable flotante que representa la velocidad de movimiento del jugador en el eje X. Por defecto, se establece en 10 unidades por segundo. Esta variable se puede ajustar desde el Inspector de Unity para cambiar la velocidad del jugador.

### 2. `FuerzaSalto` (`[SerializeField] float FuerzaSalto = 5f`)

Una variable flotante que indica la fuerza con la que el jugador podrá saltar. Un valor más alto hará que el salto sea más fuerte. Esta variable también es ajustable desde el Inspector de Unity.

### 3. `EnElPiso` (`bool EnElPiso = true`)

Una variable booleana que se utiliza para detectar si el jugador está en el suelo. Si es cierto, el jugador puede saltar; de lo contrario, no podrá saltar infinitamente en el aire.

### 4. `IncrementoVelocidad` (`float IncrementoVelocidad = 0.0001f`)

Una pequeña cantidad que se suma a la velocidad del jugador en cada cuadro de actualización, lo que permite que la velocidad aumente gradualmente con el tiempo. Esto le da al juego una sensación de aceleración progresiva. Se puede modificar desde el Inspector de Unity.

### 5. `camara` (`[SerializeField] Camera camara`)

Una referencia al componente Camera en la escena que se utilizará para modificar sus propiedades. En este caso, se utiliza para anclar la cámara al eje Y del jugador para evitar movimientos bruscos al saltar.

### 6. `animator` (`[SerializeField] Animator animator`)

Una referencia al componente Animator que está dentro del objeto del jugador. Se utiliza para controlar las animaciones del jugador, específicamente las animaciones de caminar y saltar.

### 7. `Jugador` (`[SerializeField] GameObject Jugador`)

Una referencia al objeto del jugador en la escena. Se utiliza para destruir el objeto del jugador si colisiona con un enemigo.

### 8. `casa` (`[SerializeField] GameObject casa`)

Una referencia a un objeto de tipo prefab llamado "casa". En el código, se destruye el objeto "casa" después de un tiempo específico.

## Métodos

### 1. `Start()`

Este es un método especial de Unity que se ejecuta una vez al inicio del juego, antes del primer cuadro de actualización. En este caso, se utiliza para obtener el componente Animator del objeto jugador.

### 2. `Update()`

Este es otro método especial de Unity que se ejecuta en cada cuadro de actualización del juego. En Update(), se llaman a varias funciones para realizar las acciones del jugador.

### 3. `MoverJugador()`

Esta función se encarga de mover al jugador horizontalmente en el eje X infinitamente y aumentar gradualmente su velocidad. También activa la animación de caminar.

### 4. `MoverCamara()`

En esta función, la cámara se ancla al eje Y del jugador para evitar movimientos bruscos al saltar.

### 5. `Saltar()`

Esta función se llama cuando el jugador presiona la tecla de espacio. Si el jugador está en el suelo, se ejecuta la función Salto() y se activa la animación de salto.

### 6. `Salto()`

Esta función aplica una fuerza hacia arriba al jugador usando el componente Rigidbody2D, permitiéndole saltar. Además, establece EnElPiso en false para evitar saltos adicionales en el aire.

### 7. `DestruirCasa()`

En esta función, se destruye el objeto "casa" después de un tiempo determinado (5 segundos). Esta acción es puramente estética y se utiliza como un ejemplo de cómo se pueden eliminar objetos en el juego.

### 8. `OnCollisionEnter2D(Collision2D collision)`

Esta función especial de Unity se llama cuando se detecta una colisión en 2D. Se utiliza para detectar si el jugador colisiona con el suelo o un enemigo. Si colisiona con el suelo, se establece EnElPiso en true, lo que permite al jugador saltar nuevamente. Si colisiona con un enemigo, se destruye el objeto del jugador y se carga la escena llamada "Muerte".

## Uso y Consideraciones

1. Asigna las variables públicas desde el Inspector de Unity para configurar el comportamiento del jugador y la generación de objetos (si se utiliza este script junto con el otro "Generador.cs").

2. Asegúrate de tener un objeto que represente al jugador y asigna este script como componente.

3. Si el jugador colisiona con un objeto enemigo (que tenga la etiqueta "Enemigo"), el objeto del jugador se destruirá y la escena "Muerte" se cargará. Asegúrate de que la escena "Muerte" exista en el proyecto.

4. Si deseas cambiar las animaciones del jugador, asegúrate de tener configurado el componente Animator con las transiciones y estados adecuados.

5. Si utilizas el objeto prefab "casa" para algún propósito específico en el juego, ajusta el tiempo de destrucción en la función `DestruirCasa()` para que se adapte a tus necesidades.

Es importante mencionar que este script es parte de la lógica del jugador en el juego y debe estar asociado a un personaje controlable para que funcione correctamente. También se puede combinar con otros scripts y sistemas para crear un juego más completo y diverso. ¡Diviértete experimentando con Unity y desarrollando tu juego!
