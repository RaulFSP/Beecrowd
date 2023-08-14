(SELECT name, customers_number FROM lawyers ORDER BY customers_number DESC LIMIT 1)
UNION ALL
(SELECT name, customers_number FROM lawyers ORDER BY customers_number ASC LIMIT 1)
UNION ALL
(SELECT 'Average', AVG(customers_number)::NUMERIC(2,0) FROM lawyers)
