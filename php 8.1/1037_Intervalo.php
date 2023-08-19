<?php
$entrada = trim(fgets(STDIN));
if ($entrada >= 0 && $entrada <=25) echo "Intervalo [0,25]".PHP_EOL;
else if ($entrada > 25 && $entrada <=50) echo "Intervalo (25,50]".PHP_EOL;
else if ($entrada > 50 && $entrada <=75) echo "Intervalo (50,75]".PHP_EOL;
else if ($entrada > 75 && $entrada <=100) echo "Intervalo (75,100]".PHP_EOL;
else echo "Fora de intervalo".PHP_EOL;
?>
