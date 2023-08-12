<?php
$entrada = trim(fgets(STDIN));
$contador = 0;
while ($contador != 6) {    
    if ($entrada%2!=0){
        echo $entrada.PHP_EOL;
        $contador++;
    }
    $entrada++;
}
?>
