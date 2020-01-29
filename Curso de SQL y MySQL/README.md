#  Curso de SQL y MySQL


## 1. Introducción al Curso de SQL y MySQL


### Clase  1 | [Bienvenidos al curso](https://platzi.com/clases/1272-sql-mysql/11085-bienvenidos-al-curso9999/) | 7:14 min

**Bases de datos basadas en SQL**

Las bases de datos más comunes basadas en SQL son:  
**MySQL**: MySQL es una base de datos SQL de código abierto, desarrollada por una empresa sueca MySQL AB

**Oracle**: Oracle es un sistema de gestión de bases de datos relacional desarrollado por Oracle Corporation.

**Access**: Microsoft Access es un software de gestión de base de datos de nivel de entrada.


### Clase  2 |  [Instalación de MySQL](https://platzi.com/clases/1272-sql-mysql/11086-instalacion-de-mysql/)  | 

Si estas trabajando con Windows puedes hacer la descarga ingresando en el siguiente enlace: [https://dev.mysql.com/downloads/installer/](https://dev.mysql.com/downloads/installer/). Este es el sitio oficial de MySQL por lo que puedes confiar en la descarga.

El instalador para Windows es muy similar a los que ya conocemos, nos pide algunas verificaciones y nos permite navegar a través de diferentes ventanas.

Inicialmente el instalador nos va a solicitar que aceptemos la los términos y acuerdos de la licencia. Revisalos y si estas de acuerdo continua.

En seguida te va a solicitar información relacionada con el tipo de instalación que vas a realizar, puedes elegir entre Developer Default, Client Only y Full. Cualquiera que sea la opción que elijas esto no implica que luego puedas actualizarla.

Si instalas la versión Full vas a tener acceso a todas las características y productos que MySQL ofrece.

Verifica que tengas disponibles todos los requerimientos que el instalador te presenta. En caso de no contar con ellos debes descargar e instalar el software solicitado.

Continua con la instalación de acuerdo a lo que te indica el ayudante.

### Clase 3  |   [La consola de MySQL](https://platzi.com/clases/1272-sql-mysql/11087-la-consola-de-mysql/) |  

---

**COMANDOS USADOS EN LA CLASE**

Comando de conexión

	mysql -u root -h -127.0.0.1 -p 
	
Comando para ver las BD a las que tiene acceso con el usuario que nos conectamos
	
	show databases;  
	
Comando para usar usar una BD en particular

	use nombre_basededatos;  
Comando para saber que tablas hay en la BD que se esta usando

	show tables;  
Comando para saber que BD estoy trabajando

	select database();
	
---
En Windows, para acceder la consola de MySQL sin tener que estar ubicado en el directorio bin de MySQL Server hay que meter este directorio en la variable del sistema  **Path**.  **MUY IMPORTANTE**: NO BORRAR NADA, tan solo editar y añadir una nueva entrada. Para eso, en Windows 10, hay que hacer lo siguiente:

1.  Abrir el **Panel de Control **→  **Sistema y Seguridad**  →  **Sistema**. En el menú lateral izquierdo de esta ventana clicar en  **Configuración avanzada del sistema**.
    
2.  Se va a abrir una ventana llamada  **Propiedades del Sistema**  y hay que clicar en un botón abajo de todo que pone  **Variables de entorno**.
    
3.  Al abrirse esta ventana verás dos secciones: la parte de arriba son las  **Variables de Usuario**  y la parte de abajo las  **Variables del Sistema**. En la parte de abajo, dentro de esas variables de sistema hay que buscar una que se llama **Path **y con ella seleccionada le damos al botón  **Editar**.
    
4.  Ahora en esta nueva ventana le damos a **Nuevo **y a continuación le das a **Examinar **para escoger el directorio que quieres meter, en este caso C:\Program Files\MySQL\MySQL Server 8.0\bin y así ya podrás acceder desde cualquier lugar a la consola de MySQL.
---
Recuperar la contraseña de root en mysql:

El computador debe estar con usuario administrador.

1.  Detener el servicio de mysql
2.  Crear un archivo de bloc de notas (ejecutado como administrador) y colocar:

set password for ‘root’@‘localhost’ = PASSWORD(‘nueva contraseña’);

Guarar el archivo en la ruta: c:, con el nombre de mysql-init.txt

1.  Ejecutar en cmd (ejecutado como administrador) y ejecutar:

c:>cd "C:\Program Files\MySQL\MySQL Server 8.0\bin"  
c:>mysqld --default-file=“C:\ProgramData\MySQL\MySQL Server 8.0\my.ini” --init-file=“C:\mysql-init.txt”

Si se queda esperando en el warning entonces:

-Cerrar la ventana  
-Abrir nuevamente la consola darle netstat y buscar el proceso que está ejecutando el puerto 3306:

netstat -aon | find “:3306”

busacamos el proceso y lo matamos:

taskkill /F /IM mysqld.exe /T

1.  Iniciar nuevamente el servicio de MySql
    
2.  Probar nuevamente la conexión en mysql con el usuario y nueva contraseña.
    

Nota: es recomendable eliminar el archivo de mysql-init.txt en disco C por seguridad.

---
---
Hola Compañero te dejo este dato para que puedas ejecutar cualquier comando desde tu terminal, en este caso es “mysql” , espero te sirva:  
Paso 1: Abre tu terminal de comandos.

Paso 2:

Si el archivo no existe solo debes crearlo ejecutando el siguiente comando en tu terminal:  
touch ~/.bash_profile  
Abre el archivo en tu editor preferido o a través del siguiente comando en tu terminal:  
open ~/.bash_profile  
Paso 3: Agrega tus rutas al final del archivo.

export PATH=${PATH}:/tu_ruta  
Los “:” sirven para concatenar rutas, de manera que cada vez que necesites agregar una nueva ruta solo debes colocar “:” y tu nueva ruta al final de la asignación del PATH.

Te dejo un ejemplo real de como está configurado en mi equipo para que puedas darte una mejor idea:

export ANDROID_HOME=/Users/MeridaDesignStudio/Development/adt-bundle/sdk  
export COMPOSER=/Users/MeridaDesignStudio/.composer/vendor/bin  
export PATH=$ {PATH}:$ ANDROID_HOME/tools:$ ANDROID_HOME/platform-tools:$COMPOSER  
Como puedes ver en el ejemplo, se pueden crear variables de tus rutas y luego usarlas en la asignación del PATH.

Paso 4: Guarda el archivo y cierra el editor.

Paso 5: Forza la ejecución del archivo .bash_profile para ver los cambios inmediatamente sin tener que reiniciar. En tu terminal ejecuta el siguiente comando:

source ~/.bash_profile  

Eso es todo, ahora puedes ejecutar tus comandos desde cualquier ubicación en tu terminal.

Mi ejemplo para Git bash

	nano ~/.bash_profile

Dentro del archivo pegamos un codigo parecido a este

	export mysql=/C:\Program Files\MySQL\MySQL Server 8.0\bin

Ahora podremos hacer desde Git bash en teoria.

	mysql -u root -p

Para entrar a MySql .

---


[comentario: Para los de windows que no saben como llegar a la terminal de sql en windows ](https://platzi.com/comentario/648356/)




### Clase 4  | [¿Qué es una base de datos?](https://platzi.com/clases/1272-sql-mysql/11088-que-es-una-base-de-datos8306/) | 

Mis apuntes:  
Las bases de datos:  
Son un lugar donde almacenamos datos puntuales de cualquier cantidad de cosas,para después operar sobre ellos y realizaros en información. Esa información la convierte en operaciones de negocio y las operaciones de negocio convertirlas en dinero o lo que sea de crecimiento.

Una base de datos nos permite almacenar datos y relaciones entre datos, para que nosotros podamos convertirlos en información.





## 2. CREATE



### Clase 5  | [Comando CREATE](https://platzi.com/clases/1272-sql-mysql/11089-comando-create/)  | 

[InnoDB y MyISAM: El ying yang de MySQL](https://platzi.com/tutoriales/1272-sql-mysql/4484-innodb-y-myisam-el-ying-yang-de-mysql/)

**Tipos de tablas de Bases de datos** por defecto en MySQL:  

•**MyISAM:**  directa, sencilla, más rápida y las transacciones son completamente uno a uno:  
•**InnoDB:**  nueva, recuperable en caso de falla de disco duro pero es un poco más lenta.


En la vida real **usamos las tablas con dos propósitos**:  

•**Catalogo:**  crecerá en un orden lento, según las necesidades de la propia BD. (Listado de Usuarios, InnoDB)  
•**Operación:**  se enfocan a lectura, mayor acceso a disco duro. (Prestamos de libros, MyISAM).

[https://www.webreunidos.es/blog/myisam-vs-innodb/](https://www.webreunidos.es/blog/myisam-vs-innodb/)
