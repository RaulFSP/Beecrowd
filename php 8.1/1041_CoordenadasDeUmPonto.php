<?php
$entrada = explode(" ",trim(fgets(STDIN)));
$x = $entrada[0];
$y = $entrada[1];
if ($x > 0 && $y > 0) echo "Q1".PHP_EOL;
else if ($x < 0 && $y > 0) echo "Q2".PHP_EOL;
else if ($x < 0 && $y < 0) echo "Q3".PHP_EOL;
else if ($x > 0 && $y < 0) echo "Q4".PHP_EOL;
else if ($x == 0 && $y != 0) echo "Eixo Y".PHP_EOL;
else if ($x != 0 && $y == 0) echo "Eixo X".PHP_EOL;
else if ($x == 0 && $y == 0) echo "Origem".PHP_EOL;
?>
