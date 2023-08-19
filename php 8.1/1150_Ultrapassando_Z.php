<?php
$x = trim(fgets(STDIN));
do {
    $z = trim(fgets(STDIN));
} while ($z <= $x);
$contador = 0;
$soma = 0;
while ($soma < $z) {
    $contador ++;
    $soma += $x;
    $x ++;
}
echo $contador . PHP_EOL;

?>
