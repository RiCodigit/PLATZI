
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