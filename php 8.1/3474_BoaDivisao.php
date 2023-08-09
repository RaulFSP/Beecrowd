<?php
    $contador = explode(" ",fgets(STDIN));
    $resultado = number_format($contador[0]/$contador[1],2,'.','');
    echo $resultado.PHP_EOL;
?>
