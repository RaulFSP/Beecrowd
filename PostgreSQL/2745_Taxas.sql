SELECT pl.name, ROUND((pl.salary * 0.1),2) AS tax FROM people AS pl WHERE salary > 3000;
