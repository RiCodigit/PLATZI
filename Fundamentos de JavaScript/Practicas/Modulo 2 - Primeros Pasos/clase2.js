// Covertir con funciones text en mayusculas
var nombre = 'Sasha', apellido = 'Gomez'

var nombreMayusculas = nombre.toUpperCase()
var apellidoMinusculas = apellido.toLowerCase()

var primeraLetraDelNombre = nombre.charAt(0) // le decimos que queremos la primera posicion
/* 
Tener en cuenta, que nos devuelve el caracter como este guardado, 
es decir en este caso 'nombre' tiene la primera letra en mayuscula por tanto el caracter que nos devuelve es la 'S'
*/
var cantidadDeLetrasDelNombre = nombre.length // esto es un atributo y no una función , por ello no ponemos los paréntesis

// 2º Ejercicio

//Concatenar String

//Antigua forma
//var nombreCompleto = nombre + ' ' + apellido

//Nueva Forma - Interpolarizacion 
var nombreCompleto = ` ${nombre} ${apellido.toUpperCase()} ` 
/* 
Nota; Se puede dentro de los corchetes escribir codigo JS, 
como en el ejemplo, le ponemos a la var apellido la funcion .ToUpperCase() para tener el apellido en Mayusculas. 
*/

//3º Ejercicio - Queremos obtener los caracter del nombre de cierta posicion ( la 1 y la 2)
var str = nombre.charAt(1) + nombre.charAt(2)

// Usando el metodo Substr

var str1 = nombre.substr(1,2) // empezamos por la posicion 1 y cogemos 2 caracter posteriores a esta posicion-


// ---- -- RETO de la Clase-- --- 

// Como Mostar la ultima letra del nombre del usuario.
var NumTotalNombre = nombre.length
var ultimaLetraDelNombre = nombre.charAt(NumTotalNombre - 1)

// Mejorando un poco el codigo
var ultimaLetraDelNombre = nombre.charAt(nombre.length - 1)

// Este linea sería la mejor opcion a mi modo de ver, para mostrar por consola la ultima letra de la var nombre al user.
console.log(nombre.charAt(nombre.length -1)) 