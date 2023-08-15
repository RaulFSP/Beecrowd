(SELECT CONCAT('Podium: ',team) AS name FROM league LIMIT 3)
UNION ALL
(SELECT CONCAT('Demoted: ',team)  FROM league LIMIT 2 OFFSET 13)
