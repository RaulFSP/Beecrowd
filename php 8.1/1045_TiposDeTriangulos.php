<?php
    $entrada = explode(" ",trim(fgets(STDIN)));
    rsort($entrada);
    $a = $entrada[0];
    $b = $entrada[1];
    $c = $entrada[2];
    if ($a >= $b+$c) {
        echo "NAO FORMA TRIANGULO".PHP_EOL;
    } else {
        if (pow($a,2) == pow($b,2) + pow($c,2)) {
            echo "TRIANGULO RETANGULO".PHP_EOL;
        } else if (pow($a,2) > pow($b,2) + pow($c,2)) {
            echo "TRIANGULO OBTUSANGULO".PHP_EOL;
        } else {
            echo "TRIANGULO ACUTANGULO".PHP_EOL;
        }
        $contaLados = array_count_values($entrada);
        $contaLados = max($contaLados);
        switch($contaLados) {
            case 2: echo "TRIANGULO ISOSCELES".PHP_EOL;break;
            case 3: echo "TRIANGULO EQUILATERO".PHP_EOL;break;
            default: "";break;
        }
    }
?>
