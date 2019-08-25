
# Fundamentos de Bases de Datos


## 1. Bienvenida conceptos básicos y contexto histórico de las Bases de Datos



### Clase  1 | [Bienvenida conceptos básicos y contexto histórico de las Bases de Datos](https://platzi.com/clases/1566-bd/19781-bienvenida-conceptos-basicos-y-contexto-historico-/ "")  |  9:00 min






## 2. Introducción a la bases de datos relacionales




### Clase  2 | [Historia de las RDB](https://platzi.com/clases/1566-bd/20196-historia-de-las-rdb4706/ "")  |  3:00 min



###  Clase  3 |  [Entidades y atributos](https://platzi.com/clases/1566-bd/20197-entidades-y-atributos3104/ "") |  10:00 min



### Clase 4  |  [Entidades de Platzi Blog](https://platzi.com/clases/1566-bd/20198-entidades-de-platzi-blog9263/ "") |  8:00 min



### Clase 5 |  [Relaciones](https://platzi.com/clases/1566-bd/20199-relaciones2272/ "") | 10:00 min



### Clase 6 |  [Múltiples muchos](https://platzi.com/clases/1566-bd/20200-multiples-muchos5129/ "") |  2:00 min



### Clase  7 |  [Diagrama ER](https://platzi.com/clases/1566-bd/20201-diagrama-er4406/ "") |  5:00 min



### Clase  8 |  [Diagrama Físico:  tipos de datos y constraints](https://platzi.com/clases/1566-bd/20202-diagrama-fisico-y-tipos-datos-y-constraints0863/ "") |  13:00 min




### Clase  9 | [Diagrama Físico: normalización](https://platzi.com/clases/1566-bd/20203-diagrama-fisico-normalizacion8011/ "")  | 10:00 min


### Clase 10 | [Diagrama Físico: normalizando Platziblog](https://platzi.com/clases/1566-bd/20204-diagrama-fisico-normalizando-platziblog2443/ "") | 14:00 min



### Clase  11 |  [Formas normales en DB relacionales](https://platzi.com/clases/1566-bd/19791-formas-normales-en-db-relacionales/ "") | 3:00 min








## 3. RDBMS (MySQL) o cómo hacer lo anterior de manera práctica



### Clase  12 | [RDB ¿Qué?](https://platzi.com/clases/1566-bd/20205-rdb-que4374/ "")  |  2:00 min

**RDBMS**  significa  **R**elational  **D**atabase  **M**anagement  **S**ystem o sistema manejador de bases de datos relacionales. Es un programa que se encarga de seguir las reglas de  **Codd**  y se puede utilizar de manera programática.


### Clase  13 |  [Instalación local de un RDBMS (Windows)](https://platzi.com/clases/1566-bd/20206-instalacion-local-de-un-rdbms-windows7161/ "") |  13:00 min

Hay dos maneras de acceder a manejadores de bases de datos:

-   Instalar en máquina local un administrador de bases relacional.
-   Tener ambientes de desarrollo especiales o servicios cloud.

En este curso usaremos  **MySQL**  porque tiene un impacto histórico siendo muy utilizado y además es software libre y gratuito. La versión 5.6.43 es compatible con la mayoría de aplicaciones y frameworks.

-   Root es el usuario principal que tendrá todos los permisos y por lo tanto en ambientes de producción hay que tener  **mucho cuidado**  al configurarlo.




### Clase  14 |  [Instalación local de un RDBMS (Mac)](https://platzi.com/clases/1566-bd/20207-instalacion-local-de-un-rdbms-mac5139/ "") |  8:00 min



### Clase  15 |  [Instalación local de un RDBMS (Ubuntu)](https://platzi.com/clases/1566-bd/19795-instalacion-local-de-un-rdbms-ubun-9/ "") |  1:00 min



### Clase  16 |  [Clientes gráficos](https://platzi.com/clases/1566-bd/20208-clientes-graficos2987/ "") |  5:00 min



Conociendo el entorno  gráfico MySLQ Workbench.

En MySLQ :

Pregunta: Cual es la diferencia entre un Schema y una BD, existe algún concepto que las diferencie? vengo de SQL Server y entiendo que son dos ideas distintas.

``depende de la base de datos, por ejemplo en PostgreSQL un schema puede tener db, y estas tener tablas, pero en MySQL un schema es una db y este schema tiene las tablas.``

``La base de datos es una colección de schemas y los schemas son una colección de tablas.``



### Clase  17 |  [Servicios administrados](https://platzi.com/clases/1566-bd/20209-servicios-administrados9920/ "") |  12:00 min


Hoy en día muchas empresas ya no tienen instalados en sus servidores los **RDBMS** sino que los contratan a otras personas. Estos **servicios administrados**  o también llamados  **cloud** te permiten concentrarte en la base de datos y no en su administración y actualización.

Empresas con Servicios Cloud:
[AWS Amazon](https://aws.amazon.com/es/)
 [Google Cloud](https://cloud.google.com/)
[Azure Microsoft](https://azure.microsoft.com/)

Probamos a usar GCP (Google Cloud Platform)

## 4. SQL hasta en la sopa


### Clase  18 | [Historia de SQL](https://platzi.com/clases/1566-bd/20210-historia-de-sql9440/ "Historia de SQL")  |  3:00 min



**SQL**  significa  **S**tructured  **Q**uery  **L**anguage y tiene una estructura clara y fija. Su objetivo es hacer un solo lenguaje para consultar cualquier manejador de bases de datos volviéndose en un gran estándar.

Ahora existe el  **NOSQL**  o  **N**ot  **O**nly  **S**tructured  **Q**uery  **L**anguage que significa que no sólo se utiliza SQL. Las bases de datos no relacionales.



SQL es un lenguaje de acceso a bases de datos que explota la flexibilidad y potencia de los sistemas relacionales y permite así gran variedad de operaciones.

-   SQL es un estándar aceptado por ANSI (Instituto Nacional Estadounidense de Estándares)
-   PL/SQL es un lenguaje de programación de la base de datos de Oracle, el nombre viene de Procedural Language/Structured Query Language
-   T-SQL es un lenguaje de programación de la base de datos de Microsoft SQL Server y el nombre viene de TRANSACT-SQL



### Clase  19 |  [DDL create](https://platzi.com/clases/1566-bd/20211-ddl-create8613/ "") |  13:00 min


**SQL**  tiene dos grandes sublenguajes:  
**DDL**  o Data Definition Language que nos ayuda a crear la estructura de una base de datos. Existen 3 grandes comandos:

-   Create: Nos ayuda a crear bases de datos, tablas, vistas, índices, etc.
-   Alter: Ayuda a alterar o modificar entidades.
-   Drop: Nos ayuda a borrar. Hay que tener cuidado al utilizarlo.

**3 objetos que manipularemos con el lenguaje DDL:**

-   Database o bases de datos
-   Table o tablas. Son la traducción a SQL de las entidades
-   View o vistas: Se ofrece la proyección de los datos de la base de datos de forma entendible.



### Clase  20 | [DDL alter](https://platzi.com/clases/1566-bd/20212-ddl-alter0483/ "")  |  10:00 min

[](https://platzi.com/clases/1566-bd/20213-ddl-drop7001/ "DDL drop")

### Clase  21 |   |  5:00 min

[](https://platzi.com/clases/1566-bd/20214-dml3415/ "DML")

### Clase  22 |   |  17:00 min

[](https://platzi.com/clases/1566-bd/19808-que-tan-estandard-es-sql/ "¿Qué tan estandard es SQL?")

### Clase  23 |   |  10:00 min

[](https://platzi.com/clases/1566-bd/19809-creando-platziblog-tablas-independientes/ "Creando Platziblog: tablas independientes")

### Clase 24 |   |  11:00 min

[](https://platzi.com/clases/1566-bd/19810-creando-platziblog-tablas-dependientes/ "Creando Platziblog: tablas dependientes")

### Clase  25 |   |  11:00 min

[](https://platzi.com/clases/1566-bd/19811-creando-platziblog-tablas-transistivas/ "Creando Platziblog: tablas transitivas")

### Clase  26 |   |  9:00 min







## 5.Consultas a una base de datos



[](https://platzi.com/clases/1566-bd/19812-por-que-las-consultas-son-tan-importantes/ "¿Por qué las consultas son tan importantes?")

### Clase  27 |   |  2:00 min

[](https://platzi.com/clases/1566-bd/19817-estructura-basica-de-un-query/ "Estructura básica de un Query")

### Clase  28 |   |  6:00 min

[](https://platzi.com/clases/1566-bd/19818-select/ "SELECT")

### Clase  29 |   |  11:00 min

[](https://platzi.com/clases/1566-bd/19819-from/ "FROM")

### Clase  30 |   |  7:00 min

[](https://platzi.com/clases/1566-bd/19820-utilizando-la-sentencia-from/ "Utilizando la sentencia FROM")

### Clase  31 |   |  14:00 min

[](https://platzi.com/clases/1566-bd/19821-where/ "WHERE")
### Clase  32 |   |  14:00 min

[](https://platzi.com/clases/1566-bd/19822-utilizando-la-sentencia-where-nulo-y-no-nulo/ "Utilizando la sentencia WHERE nulo y no nulo")

### Clase  33 |   |  10:00 min

[](https://platzi.com/clases/1566-bd/19823-group-by/ "GROUP BY")

### Clase  34 |   |  11:00 min

[](https://platzi.com/clases/1566-bd/19824-order-by-y-having/ "ORDER BY y HAVING")

### Clase  35 |   |  13:00 min

[](https://platzi.com/clases/1566-bd/19825-el-interminable-agujero-de-conejo-nested-queries/ "El interminable agujero de conejo (Nested queries)")

### Clase   36 |   |  12:00 min

[](https://platzi.com/clases/1566-bd/19826-como-convertir-una-pregunta-en-un-query-sql/ "¿Cómo convertir una pregunta en un query SQL?")

### Clase  37 |   |  6:00 min

[](https://platzi.com/clases/1566-bd/19827-preguntandole-a-la-base-de-datos/ "Preguntándole a la base de datos")

### Clase   38  |   |  10:00 min

[](https://platzi.com/clases/1566-bd/19872-consultando-platziblog/ "Consultando PlatziBlog")

### Clase  39 |   |  12:00 min




## 6. Introducción a la bases de datos NO relacionales



[](https://platzi.com/clases/1566-bd/19813-que-son-y-cuales-son-los-tipos-de-base-datos-no-re/ "¿Qué son y cuáles son los tipos de bases de datos no relacionales? ")

### Clase  40 |   |  10:00 min

[](https://platzi.com/clases/1566-bd/19814-servicios-administrados-y-jerarquia-de-datos/ "Servicios administrados y jerarquía de datos")

### Clase  41  |   |  5:00 min






## 7.Manejo de modelos de datos en bases de datos no relacionales


[](https://platzi.com/clases/1566-bd/19815-top-level-collection-con-firebase/ "Top level collection con firebase")

### Clase  42 |   |  10:00 min

[](https://platzi.com/clases/1566-bd/19816-creardo-y-borrando-documentos-en-firestore/ "Creando y borrando documentos en firestore")

### Clase  43 |   |  15:00 min

[](https://platzi.com/clases/1566-bd/19828-colecciones-vs-subcolecciones/ "Colecciones vs subcolecciones")

### Clase  44 |   |  9:00 min

[](https://platzi.com/clases/1566-bd/20157-recreando-platziblog6890/ "Recreando Platziblog")

### Clase  45 |   |  8:00 min

[](https://platzi.com/clases/1566-bd/20158-construyendo-platziblog-en-firestorm4685/ "Construyendo Platziblog en firestore")

### Clase  46 |   |  12:00 min

[](https://platzi.com/clases/1566-bd/19805-proyecto-final-transformando-tu-proyecto-en-una-db/ "Proyecto final transformando tu proyecto en una db no relacional")

### Clase  47 |   |  2:00 min






## 8. Bases de datos en la vida real



[](https://platzi.com/clases/1566-bd/19829-bases-de-datos-en-la-vida-real/ "Bases de datos en la vida real")

### Clase  48 |   |  7:00 min

[](https://platzi.com/clases/1566-bd/19830-big-data/ "Big Data")

### Clase  49 |   |  5:00 min

[](https://platzi.com/clases/1566-bd/19831-data-warehouse/ "Data warehouse")

### Clase  50 |   |  5:00 min

[](https://platzi.com/clases/1566-bd/19832-data-mining/ "Data mining")

### Clase 51  |   |  6:00 min

[](https://platzi.com/clases/1566-bd/19833-etl3813/ "ETL")

### Clase 52 |   |  6:00 min

[](https://platzi.com/clases/1566-bd/19834-business-intelligence/ "Business intelligence")

### Clase 53 |   |  6:00 min

[](https://platzi.com/clases/1566-bd/19835-machine-learning3347/ "Machine Learning")

### Clase 54  |   |  13:00 min

[](https://platzi.com/clases/1566-bd/19836-data-science1250/ "Data Science")

### Clase 55 |   |  4:00 min

[](https://platzi.com/clases/1566-bd/20159-por-que-aprender-bases-de-datos-hoy5773/ "¿Por qué aprender bases de datos hoy?")

### Clase 56  |   |  3:00 min





## 9.Bonus

[](https://platzi.com/clases/1566-bd/20160-bases-de-datos-relacionales-vs-no-relacionales5296/ "Bases de datos relacionales vs no relacionales")

### Clase 57 |   |  4:00 min
