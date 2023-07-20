# Documentación del Código "Generador.cs"

Este script es utilizado en el motor de juegos Unity para generar objetos de forma aleatoria en un intervalo de tiempo específico. El script se encarga de crear instancias de objetos a partir de una matriz de prefabs y los posiciona en el escenario.

## Componentes

### 1. Generador

Este es el componente principal que contiene el script "Generador.cs". Se adjunta a un objeto vacío en la escena, el cual se utilizará como punto de referencia para la generación de los objetos.

## Variables Públicas

### 1. `matriz` (`public GameObject[] matriz`)

Una matriz de tipo GameObject que contiene las prefabs de los objetos que se generarán de forma aleatoria. Cada prefab representa un tipo de objeto que puede ser instanciado en el juego.

### 2. `posY` (`public float posY = -2.25f`)

Un valor flotante que indica la posición en el eje Y donde se colocarán los objetos generados. Es posible ajustar esta variable en el Inspector de Unity para cambiar la altura de generación de los objetos.

### 3. `posZ` (`public float posZ = 0f`)

Un valor flotante que indica la posición en el eje Z donde se colocarán los objetos generados. Esta variable también se puede ajustar en el Inspector de Unity.

### 4. `interval` (`public float interval = 6`)

Un valor flotante que representa el intervalo de tiempo en segundos entre cada generación de objetos. Es decir, el tiempo que debe pasar entre la aparición de un objeto y el siguiente. Esta variable es ajustable desde el Inspector de Unity.

## Variables Privadas

### 1. `elapsedTime` (`private float elapsedTime`)

Un valor flotante que almacena el tiempo transcurrido desde la última generación de objetos. Esta variable se utiliza para controlar el intervalo de tiempo entre generaciones.

## Métodos

### 1. `Update()`

Este es un método especial de Unity que se llama en cada cuadro de actualización del juego. En este caso, se utiliza para llamar a la función `GenerarObjetoAleatorio()` en cada cuadro de actualización.

### 2. `GenerarObjetoAleatorio()`

Esta función es responsable de generar un objeto aleatorio a partir de la matriz de prefabs y posicionarlo en la escena. Aquí está el flujo de la función:

1. Aumenta el tiempo transcurrido (`elapsedTime`) en cada cuadro de actualización utilizando `Time.deltaTime`.

2. Comprueba si ha pasado el tiempo suficiente desde la última generación de objetos. Esto se hace comparando `elapsedTime` con el valor de `interval`.

3. Si ha pasado el tiempo suficiente, se selecciona un índice aleatorio (`indiceAleatorio`) entre 0 y la longitud de la matriz de prefabs `matriz`.

4. Se posiciona el objeto vacío (el que tiene el script) en la posición determinada por `posY` y `posZ`.

5. Se crea una instancia del objeto seleccionado de la matriz de prefabs en la posición del objeto vacío. Esto se logra utilizando la función `Instantiate()` de Unity.

6. Finalmente, se reinicia el tiempo transcurrido (`elapsedTime`) a cero, preparándose para la próxima generación de objetos.

## Uso y Consideraciones

1. Asigna la matriz de prefabs `matriz` en el Inspector de Unity. Asegúrate de que esta matriz contenga las prefabs de los objetos que deseas generar aleatoriamente.

2. Configura los valores de `posY` y `posZ` para definir la posición donde los objetos generados aparecerán en el escenario.

3. Ajusta el valor de `interval` para establecer el tiempo entre cada generación de objetos. Cuanto mayor sea el valor, más tiempo transcurrirá antes de la aparición del próximo objeto.

4. Asegúrate de tener un objeto vacío en la escena y asigna este script al objeto vacío como componente.

5. Una vez que hayas configurado todo, el script generará automáticamente objetos aleatorios según la matriz de prefabs en el intervalo de tiempo especificado.

Es importante destacar que este script puede ser utilizado para generar diferentes tipos de objetos, como plataformas, recolectables o elementos del escenario, dependiendo de cómo se configure la matriz de prefabs. Además, ten en cuenta que la generación de objetos se realizará en función del tiempo transcurrido, por lo que el script debe estar adjunto a un objeto que esté activo durante la ejecución del juego. Si el objeto es desactivado, la generación se detendrá hasta que el objeto se reactive nuevamente.


<!-- Cuando entregues tu documentación, por favor, borra todo lo que esté debajo. -->
<div align="center">
<br>
<br>
<br>
<br>
<p align="center">
  <img src="../rexLogo.png" alt="Logo de Fernando Rosas" width="100"/>
</p>
<h3 align="center">Documentado por Fernando Rosas</h3>
</div>
