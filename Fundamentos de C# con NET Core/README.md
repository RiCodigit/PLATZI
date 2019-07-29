
# Fundamentos de **C#** con NET Core

#### Introducción al curso

#### Clases y Objetos

#### Aprendamos con un proyecto

#### Etapa 1 – Creando la escuela

#### Etapa 2 – Creando Cursos para la escuela

#### Etapa 3 – Implementado colecciones para el manejo de cursos:


-  ### Clase 22: *Implementando colecciones.- 12:00 min*

	Vamos a cambiar nuestra implementación del array de cursos por un List de tipo Curso. 
	
	Para añadir un nuevo objeto a la colección usaremos el método `NombreDeLista.Add` si queremos añadir un conjunto de objetos en forma de colección podemos hacerlo mediante el método `.AddRange` y para remover todos los miembros de la colección usamos el método `.Clear`.
----
***Nota Personal***

***En esta Clase es donde me descargo el contenido del profesor para versionarlo con Git*** *Antes de esta clase no 		había realizado el curso de Git y GitHub por ello , decidí versionar el contenido del profesor, y a partir de aquí ir modificando los archivos yo mismo (No lo hice con mis propios archivos ya que tenía problemas con VS Code al cambiar el proyecto de carpeta, y no reconocía algunos componentes de using system; Ya encontraré el por que mas adelante.).*

---
---
- ### Clase 23: *Removiendo y buscando objetos en colecciones - 12:00 min*

Para eliminar un objeto especifico de una colección podemos hacerlo mediante referencia que es pasándole al método `.Remove` la variable del objeto a eliminar, o también indicando el índice del objeto que queremos eliminar con el método `.RemoveAt` .   

El método `.RemoveAll` pide como parámetro un *Predicate* el cual es una función que solamente va a regresar valores *Bool* y se va a ejecutar en cada elemento de la colección, de igual forma la función va a recibir como parámetro un elemento de la colección y en caso de que la condición regrese un valor de true entonces el objeto se va a borrar.

---
Para Comprender mejor el método .RemoveAll y el parámetro "Predicate" y El "Delegado") 

ver comentario de [Platzi](https://platzi.com/comentario/436623/) o buscar en Google sobre ello.

---
- ### Clase 24: *Expresiones lambda y delegados - 10:00 min*

	Una expresión lambda es una función anónima que puedes usar para crear delegados, son bastante útiles pues tu código queda de forma más compacta, pero solamente si esta función se utilizara en un solo lugar.

En C# puedes comentar de distintas formas:

-   Con  `//`  para comentar una sola línea.
-   Con  `/*`  y  `*/`  para comentar varias líneas.
-   Con  `///`  para comentar lo que hace un método especifico.

--	En la clase he aprendido adicionalmente a que existe un modo de **documentar** el **codigo** *con el uso de* **`///`** junto con **xml** , es *super interesante* , intuyo que en otros cursos mas enfocados en estos temas lo veré con mas profundidad. Por el momento dejo un [link](https://docs.microsoft.com/es-es/dotnet/csharp/codedoc) de donde pude ver mas acerca de lo mecionado antes.

---
## *Resumen de la Etapa 3*

- Limitaciones de los Arrays & Beneficios de las Colecciones.
- Creacion de Colecciones y su Uso.
	- Añadir elementos
	- Borrar Elementos.
- El Concepto de DELEGADO. (y Predicado )
- Formas de Representar un Delegado ( Algoritmos, Expresiones Lambda..)
- Tipos de Datos Bool 
- Retornar Valores de una función `return`
- Entre otros.

---
#### Etapa 4 – Refactorizando y cargando datos de prueba
  ---
- ### Clase 25: *Refactorizar a escuela engine - "08:00 min" -> 15 min*

	Es importante refactorizar nuestro código para mantenerlo ordenado.

	El constructor de una clase tiene que ser tan rápido como sea posible, tiene que estar desconectado de cualquier cosa que implique entrada y salida.
	
	Dejamos el código mejor en esta clase.


---
- ### Clase 26: *Clases estáticas - "15:00 min" -> 45 min*

	Una clase estática no permite crear nuevas instancias, la clase por si misma funciona como un objeto.
	
Singleton:  solo puedas crear una instancia de una clase, se verifica si no existe una instancia y se crea, pero si ya existe entonces usas la instancia existente.

Para **comentar varias lineas seleccionandolas** `Alt + Shit + A` En VS Code 

- Truco: Para repetir un caracter dandole una variable como dato de repetición, usar 
`int  tam  =  10`
**`var linea = "".PadLeft(tam,'=');`** 
`WriteLine(linea)`

---

---
- ### Clase 27: *Creación de entidades - "09:00 min" -> 15 min*

	Creamos Varias Entidades para el Proyecto CoreEscuela.

---

***Nota Personal***

Haciendo el commit de esta Clase, me di cuenta de que en el anterior commit había puesto la Clase 25 en vez de la clase 26, y pense que al hacer un `git commit --amend` podría cambiar el nombre del commit y problema resuelto, PERO como hice un `git push` con dicho commit, al hacer un `git push` nuevamente me daba error en el merge, ya que el historial de ambos commit eran diferentes... al final tuve que repasar algunas clases del curso de Git, e hice un `git reset`, hice un commit sencillo ( debería de haber un mejor modo , perooo son las 3 am y mañana trabajo... asi que **Nota( repasar mas Git).**) , y en el siguiente puse el correspondiente commit de la clase 27.

---
---
- ### Clase 28: *Generación de datos aleatorios - "14:00 min" -> 30 min*

	Si un método tiene más de 50 líneas significa que está mal diseñado, cada método debe tener una sola responsabilidad. Es por eso por lo que vamos a separar en distintos métodos la carga de datos de nuestro 	proyecto.
	Hemos Añadido varios métodos los cuales pueden generar datos .

---


#### Etapa Final - El gran RETO

