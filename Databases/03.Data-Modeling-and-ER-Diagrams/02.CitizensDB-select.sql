--Joins the 5 tables
USE CitizensDB
SELECT
	first_name AS [First Name],
	last_name AS [Last Name],
	a.address_text AS Address,
	t.name AS Town,
	ctry.name AS Country,
	cont.name AS Continent 
FROM PERSON p
JOIN ADDRESS a ON p.address_id = a.id
JOIN TOWN t ON a.town_id = t.id
JOIN COUNTRY ctry ON t.country_id = ctry.id
JOIN CONTINENT cont ON ctry.continent_id = cont.id