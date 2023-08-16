<?php
    $pressaoDesejada = trim(fgets(STDIN));
    $pressaoLida = trim(fgets(STDIN));
    $dif = $pressaoDesejada - $pressaoLida;
    echo $dif.PHP_EOL;
?>
