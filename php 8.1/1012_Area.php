<?php
$entrada = explode(" ", fgets(STDIN));
$a = $entrada[0];
$b = $entrada[1];
$c = $entrada[2];
$triangulo = ($a * $c) / 2.0;
$circulo = pow($c, 2) * 3.14159;
$trapezio = (($a + $b) * $c) / 2.0;
$quadrado = pow($b, 2);
$retangulo = $a * $b;
echo "TRIANGULO: " . number_format($triangulo, 3, '.', '') . PHP_EOL;
echo "CIRCULO: " . number_format($circulo, 3, '.', '') . PHP_EOL;
echo "TRAPEZIO: " . number_format($trapezio, 3, '.', '') . PHP_EOL;
echo "QUADRADO: " . number_format($quadrado, 3, '.', '') . PHP_EOL;
echo "RETANGULO: " . number_format($retangulo, 3, '.', '') . PHP_EOL;
?>
