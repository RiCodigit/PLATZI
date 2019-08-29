
/*
	CLASE 22 : DML
*/

-- INSERT 
INSERT people (last_name, first_name, adress, city)
VALUES ('Hernan', 'Laura', 'Calle 21', 'Monterrey');


-- UPDATE
UPDATE people
SET last_name = 'Sanchez', city = 'Merida'
WHERE person_id = 1;


-- DELETE
DELETE FROM people
WHERE  person_id = 1;


-- SELECT

SELECT first_name, last_name
FROM people;

/*
	Clase 23: ¿SQL ESTANDARD?
*/
CREATE TABLE people1(
person_id int,
last_name varchar(255),
first_name varchar(255),
address varchar(255),
city varchar(255)
);

INSERT INTO people1 (last_name,first_name,address,city)
VALUES ('Hernan','Laura','Calle 13','Monterrey');

SELECT first_name, last_name
FROM people1;

DROP TABLE people1;

/*
	Clase 24: Creando Platziblog: tablas independientes
*/
CREATE SCHEMA platziblog;

CREATE TABLE `platziblog`.`categorias` (
`id` INT NOT NULL AUTO_INCREMENT,
`nombre_categoria` VARCHAR(30) NOT NULL,
PRIMARY KEY (`id`));

CREATE TABLE `platziblog`.`etiquetas` (
`id` INT NOT NULL AUTO_INCREMENT,
`nombre_etiquetas` VARCHAR(30) NOT NULL,
PRIMARY KEY (`id`));

CREATE TABLE `platziblog`.`usuarios` (
`id` INT NOT NULL AUTO_INCREMENT,
`login` VARCHAR(30) NOT NULL,
`password` VARCHAR(32) NOT NULL,
`nickname` VARCHAR(40) NOT NULL,
`email` VARCHAR(40) NOT NULL,
PRIMARY KEY (`id`),
UNIQUE INDEX `email_UNIQUE` (`email` ASC));


/*
	Clase 25:  Creando Platziblog: tablas dependientes
*/

-- tambien podemos crear la tabla sin poner las comillas simples.

CREATE TABLE posts (
id INT NOT NULL AUTO_INCREMENT,
titulo VARCHAR(130) NOT NULL,
fecha_publicacion TIMESTAMP NULL,
contenido TEXT NOT NULL,
estatus CHAR(8) NULL DEFAULT 'activo',
usuario_id INT NOT NULL,
categoria_id INT NOT NULL,
PRIMARY KEY (id));


-- Para crear una llave Foranea

-- La primera 

ALTER TABLE `platziblog`.`posts` 
ADD INDEX `post_usuarios _idx` (`usuarios_id` ASC) VISIBLE;
;
ALTER TABLE `platziblog`.`posts` 
ADD CONSTRAINT `post_usuarios`
  FOREIGN KEY (`usuarios_id`)
  REFERENCES `platziblog`.`usuarios` (`id`)
  ON DELETE NO ACTION
  ON UPDATE CASCADE;
  
  
-- La segunda 
ALTER TABLE `platziblog`.`posts` 
ADD INDEX `post_categorias_idx` (`categoria_id` ASC) VISIBLE;
;
ALTER TABLE `platziblog`.`posts` 
ADD CONSTRAINT `post_categorias`
  FOREIGN KEY (`categoria_id`)
  REFERENCES `platziblog`.`categorias` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
  
/*
	Clase 26:  Creando Platziblog: tablas Transitivas
*/
-- Codigo propio para crear la tabla,
-- pero es ineficiente ya que luego hay que añadir las 
-- Foreign keys para cada tabla.
CREATE TABLE comentarios (
id INT NOT NULL AUTO_INCREMENT,
cuerpo_comentario TEXT NOT NULL,
usuario_id INT NOT NULL,
post_id INT NOT NULL,
PRIMARY KEY (id));



-- Este es el codigo que resulta 
-- después de hacer la tabla y sus Foreign Keys juntas con el editor Visual.

CREATE TABLE `platziblog`.`comentarios` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `cuerpo_comentario` TEXT NOT NULL,
  `usuario_id` INT NOT NULL,
  `post_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `comentarios_usuarios_idx` (`usuario_id` ASC),
  INDEX `comentarios_posts_idx` (`post_id` ASC),
  CONSTRAINT `comentarios_usuarios`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `platziblog`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `comentarios_posts`
    FOREIGN KEY (`post_id`)
    REFERENCES `platziblog`.`posts` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- Tabla Transitiva , Codigo resultante del Editor Visual
CREATE TABLE `platziblog`.`posts_etiquetas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `posts_id` INT NOT NULL,
  `etiqueta_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `post_ etiquetas_post_idx` (`posts_id` ASC),
  INDEX `postEtiquetas_etiquetas_idx` (`etiqueta_id` ASC),
  CONSTRAINT `postEtiquetas_post`
    FOREIGN KEY (`posts_id`)
    REFERENCES `platziblog`.`posts` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `postEtiquetas_etiquetas`
    FOREIGN KEY (`etiqueta_id`)
    REFERENCES `platziblog`.`etiquetas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
COMMENT = 'TABLA TRANSITIVA';