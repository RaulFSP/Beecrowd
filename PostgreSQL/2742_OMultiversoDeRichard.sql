SELECT life_registry.name,ROUND(omega*1.618,3) "Fator N" FROM life_registry
JOIN dimensions ON dimensions.id = life_registry.dimensions_id
WHERE dimensions.name in ('C774', 'C875') AND life_registry.name LIKE 'Richard%'
ORDER BY life_registry.omega ASC;
