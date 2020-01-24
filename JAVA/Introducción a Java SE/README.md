# Curso de  Introducción a Java SE


## 1. Conocer a Java como lenguaje de programación

  
### Clase 1 | [¿Qué es Java?](https://platzi.com/clases/1631-java-basico/21170-que-es-java/)|  11:15 min

Java es un lenguaje de programación de alto nivel (aunque no tan alto como Python o JavaScript) que nos ayuda a construir aplicaciones para diferentes dispositivos y sistemas operativos.

Fue creado en 1991 por James Gosling mientras trabajaba en Sun Microsystems, una empresa que luego fue adquirida por Oracle. Esto significa que Java tiene muy buen mantenimiento, pero también algunos cambios con los que no todos estaremos de acuerdo.

Java tiene dos categorías:  _Standard Edition_  para construir aplicaciones de escritorio o consola y  _Enterprise Edition_  para que las empresas trabajen aplicaciones web de última generación.

En este curso aprenderemos los fundamentos de Java Standard Edition: la sintaxis del lenguaje, declarar variables, trabajar con funciones, ciclos y condicionales, lógica de programación, algoritmos y muchas otras cosas.

Pero no te preocupes. Java sigue filosofía de  _Write Once, Run Anywhere_  (WORA), por lo que todo lo que aprendas en este curso lo podrás aplicar también con Java EE.

Puedes continuar tu ruta de aprendizaje de Java SE con estos otros cursos:

-   [Curso de Java SE: Orientado a Objetos](https://platzi.com/clases/java-oop/)
-   Curso de Java SE: Programación Funcional

### Clase 2 |  [Versiones de Java y JDK](https://platzi.com/clases/1631-java-basico/21171-versiones-de-java-y-jdk/) |  11:15 min

El JDK o Java Development Kit se compone de los siguientes elementos:

-   **Java Runtime Environment (JRE)**: La máquina virtual de Java, lo que nos permite que al escribir el mismo código funcione igual en todos los dispositivos y sistemas operativos.
-   **Compilador de Java**: El encargado de traducir nuestro código en Java a un lenguaje que puede entender e interpretar nuestra máquina virtual.
-   **APIs de desarrollo**: Una base de código lista para ayudarnos a desarrollar.

[Versiones de Java](https://imgur.com/a/BKdpC2M)

Las APIs de desarrollo con Java han evolucionado con el tiempo, por lo que existen diferentes versiones de java que puedes utilizar. La versión que más elevo la popularidad y las ofertas de trabajo con Java fue  _Java SE 6_.

En  _Java SE 9_  anunciaron que las actualizaciones ocurrirían cada 6 meses, pero las versiones LTS (_Long Time Support_) tendrán mantenimiento por 3 años, así que las actualizaciones son necesarias, pero no urgentes.

En este curso vamos a trabajar con la versión  _Java SE 11 LTS_, la primera versión de Java con licencia. Solo podremos usarlo gratis cuando trabajemos en ambientes de desarrollo y testing. De otra forma, debemos pagar 2.5 USD al mes por usuario de escritorio y 25 USD por procesador para aplicaciones de servidor.

Afortunadamente,  [OpenJDK](https://openjdk.java.net/)  es una versión gratis y  _open source_  de usar Java SE Platform Edition.


### Clase 3 | Las herramientas más usadas de Java | 09:04 min

Java 8 (LTS) es la versión más usada de Java hasta inicios del 2019, pero solo tendrá soporte hasta diciembre del 2020, luego de esta fecha tendremos que pagar una licencia para continuar con su soporte.

Java 10 introdujo algunos cambios en la forma de declarar variables, así que en este curso vamos a trabajar con las versiones 8 y 11 de Java.

La herramienta más usada para construir proyectos web con Java es Maven, pero también existen otras alternativas como Gradle. También existen frameworks como Spring para trabajar con Java EE y ORMs como Hibernate para trabajar con bases de datos.

Los IDEs son entornos de desarrollo integrados, herramientas (aplicaciones, seguramente de escritorio) que nos ayudan a escribir nuestro código con editores, compiladores, depuradores y constructores de interfaces gráficas, todo en un mismo lugar.

El IDE recomendado por Oracle es NetBeans, pero también están Eclipse e IntelliJ IDEA, este último es el que más fuerza ha tomado gracias a Kotlin. Las tres herramientas son gratuitas, pero IntelliJ IDEA también tiene una versión de pago.
 
### Clase 4 | Creando un entorno de desarrollo en Java en Windows | 07:04 min

 Instalamos y configuramos Intellij IDEA y los JDKs.
 
 ---
#### Clase 5 | Creando un entorno de desarrollo en Java en Mac | 

#### Clase 6 | Creando un entorno de desarrollo en Java en Linux | 
---


### Clase 7 |Escribe tu primer Hola Mundo en Java |  09:04 min

Los archivos de Java usan la extensión  **`.java`**. Por lo tanto, para crear nuestro primer “Hola, mundo” podemos hacerlo desde un archivo  `HolaMundo.java`.

El método  **main**  es el punto de entrada de una aplicación en diferentes lenguajes como Java,  [Kotlin](https://platzi.com/clases/kotlin/)  y  [C++](https://platzi.com/clases/c-plus-plus/). Sin este método nuestra aplicación no se ejecutará y mostrará un error.

En Java definimos este método de la siguiente manera:

```java
public static void main (String[] args) {
  // acciones
}

```

Por lo tanto, este será el código de nuestro  `HolaMundo.java`  y podremos ejecutarlo con  `Click derecho > Run 'HolaMundo.main()'`:

```java
public class HolaMundo {
  public static void main (String[] args) {
    System.out.println("Hola, mundo!");
  }
}

```

Recuerda que nuestro IDE nos proporciona algunos atajos. Por ejemplo, con solo escribir la palabra  `sout`  podremos autocompletar la sentencia  `System.out.println();`.



### Clase 8 |Etapas de la programación en Java |   07:59 min

1.  Escribir nuestros archivos  `.java`.
2.  Compilar, cargar y verificar nuestros archivos con  `javac`  (los IDEs nos permiten compilar con solo presionar un botón).
3.  Al compilar obtenemos archivos  `.class`  con código que nuestras computadoras pueden entender (_Byte Code_).
4.  La JVM (_Java Virtual Machine_) se encarga de ejecutar el código de forma que funcione en cualquier dispositivo o sistema operativo.

Java es un lenguaje compilado e interpretado al mismo tiempo.

[Etapas de programación en Java](https://imgur.com/a/eCJxc3R)

### Clase 9 | La JShell de Java |   

Sabías que Java tiene una herramienta interactiva en dónde puedes ir probando segmentos de código en vez de realizar todo el proceso de creación de un programa en Java. Escribir, compilar y correr.

Su nombre es  `jshell`  y está disponible desde la versión 9 de Java.

Abre tu consola de comandos o terminal, corre el siguiente comando:

```
$ java -version

```

**Ejercicio 1.**

Investiga cómo cambiar la versión de Java desde tu consola de comandos o terminal y compártenos en la sección de discusiones los comandos que ejecutaste.

**Ejercicio 2.**

Asegurate de tener definida una versión superior a la 8.  
Ahora desde tu terminal escribe el siguiente comando para abrir nuestra  `jshell`

```
$ jshell

```

![Screen Shot 2019-07-24 at 5.04.52 PM.png](https://static.platzi.com/media/user_upload/Screen%20Shot%202019-07-24%20at%205.04.52%20PM-7d3ad1c3-da34-4126-a838-d04ab2c01038.jpg)

2.  Ahora escribe la línea de código para imprimir un texto (no olvides poner ; y dar enter).  
    Compártenos tus resultados en la sección de discusiones.


## 2. Trabajar con Variables en Java

  
### Clase 10 | Variables en JAVA |

Una variable es un espacio de memoria (RAM) que contiene un dato de tipo numérico, booleano, de texto u otros tipos de datos un poco más complejos.

Las variables en Java se componen de un nombre único y un valor que puede cambiar a lo largo de la ejecución del programa. Al declarar las variables debemos definir el tipo de dato que vamos a usar y un punto y coma al final:

```java
// Variables.java

public class Variables {
  public static void main(String[] args) {
    // Declarar la variable speed de tipo int (números enteros)
    int spped;

    // Actualizar el contenido de la variable speed:
    spped = 10; // si ya habías declarado la variable

    // Declarar una variable y asignarle un valor al mismo tiempo:
    int salary = 1000;

    // Crear una variable de tipo String:
    String eployeeName = "Anahí Salgado";
  }
}

```


### Clase 12 | Actualizando Variables |  

Java nos permite actualizar nuestras variables reutilizando los valores que tenían anteriormente, de esta forma evitamos errores o inconsistencias en nuestro código:

```java
public class UpdatingVariable {
  public static void main(String[] args) {
    // Actualizar datos numéricos:
    int salary = 1000;
    salary = salary + 200;
    System.out.println(salary); // 1200

    salary += 300;
    System.out.println(salary); // 1500

    // Actualizar variables de tipo String:
    String employeeName = "Anahí";
    employeeName = employeeName + "Salgado";
    System.out.println(salary); // Anahí Salgado

    employeeName += "Díaz de la Vega";
    System.out.println(employeeName); // Anahí Salgado Díaz de la Vega

    employeeName = "Irene" + employeeName;
    System.out.println(employeeName); // Irene Anahí Salgado Díaz de la Vega
  }
}
```

### Clase 13 | Convención de Nombres en Java | 


 
### Clase 14 | Técnica de Naming; Carmei Case | 

 
 
### Clase 15 | Tipos de Datos Numéricos | 



### Clase 16 | Operadores de Asignación, Incremento y Decremento | 


### Clase 17 | Operaciones Matemáticas | 


### Clase 18 | Cast en Variables: Estimación y Exactitud | 


### Clase 19 | Casteo entre tipos de datos | 


### Clase 20 | Archivos .JAR | 


### Clase 21 | A Practicar | 
