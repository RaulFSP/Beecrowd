<?php
    $entrada = explode(" ",trim(fgets(STDIN)));
    $a = $entrada[0];
    $n = end($entrada);
    $soma = 0;
    for ($i = 1; $i <= $n; $i++) {
        $soma += $a;
        $a++;
    }
    echo $soma.PHP_EOL;
?>
