
# Fundamentos de **C#** con NET Core

#### Introducción al curso

#### Clases y Objetos

#### Aprendamos con un proyecto

#### Etapa 1 – Creando la escuela

#### Etapa 2 – Creando Cursos para la escuela

#### Etapa 3 – Implementado colecciones para el manejo de cursos:


-  ### Clase 22: *Implementando colecciones.*

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

#### Etapa 4 – Refactorizando y cargando datos de prueba
  
#### Etapa Final - El gran RETO

