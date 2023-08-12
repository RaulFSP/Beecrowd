SELECT cand.name, 
ROUND((sc.math*2+sc.specific*3+sc.project_plan*5)/10,2) AS AVG 
FROM candidate AS cand JOIN score AS sc
ON cand.id = sc.candidate_id ORDER BY AVG DESC;
