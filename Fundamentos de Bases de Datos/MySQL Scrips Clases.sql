
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
	Clase 24: ¿SQL ESTANDARD?
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