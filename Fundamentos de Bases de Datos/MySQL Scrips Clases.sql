
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