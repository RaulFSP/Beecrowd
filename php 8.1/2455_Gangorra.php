<?php
    $entrada = explode(" ",fgets(STDIN));
    $esquerda = $entrada[0]*$entrada[1];
    $direita = $entrada[2]*$entrada[3];
    if ($esquerda == $direita) {
        echo (0).PHP_EOL;
    } else if ($esquerda > $direita) {
        echo (-1).PHP_EOL;
    } else {
        echo (1).PHP_EOL;
    }
?>
