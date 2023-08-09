<?php
    $entrada = explode(" ", fgets(STDIN));
    $a = $entrada[0];
    $b = $entrada[1];
    $c = $entrada[2];
    $maior1 = ($a+$b+abs($a-$b))/2;
    $maior2 = ($maior1+$c+abs($maior1-$c))/2;
    $resultado = $maior2;
    echo  $resultado. " eh o maior" . PHP_EOL;
?>
