<?php
$ponto1 = explode(" ", fgets(STDIN));
$ponto2 = explode(" ", fgets(STDIN));
$x1 = $ponto1[0];
$y1 = $ponto1[1];
$x2 = $ponto2[0];
$y2 = $ponto2[1];
$distancia = sqrt(pow($x2 - $x1, 2) + pow($y2 - $y1, 2));
echo number_format($distancia, 4, '.', '') . PHP_EOL;
?>
