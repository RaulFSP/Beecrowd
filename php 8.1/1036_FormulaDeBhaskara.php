<?php
$entrada = explode(" ",fgets(STDIN));
$a = $entrada[0];
$b = $entrada[1];
$c = $entrada[2];
$delta = pow($b,2) - 4 *$a*$c;
if ($a == 0 || $delta < 0) {
    echo "Impossivel calcular".PHP_EOL;
} else {
    $r1 = (-$b+sqrt($delta))/(2.0*$a);
    $r2 = (-$b-sqrt($delta))/(2.0*$a);
    echo "R1 = ".number_format($r1,5,'.','').PHP_EOL;
    echo "R2 = ".number_format($r2,5,'.','').PHP_EOL;
}
?>
