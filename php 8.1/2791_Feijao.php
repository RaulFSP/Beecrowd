<?php
$entrada = explode(" ",trim(fgets(STDIN)));
$contador = 1;
foreach($entrada as $lugar) {
    if ($lugar == 1) {
        echo $contador.PHP_EOL;   
    }
    $contador++;
}
?>
