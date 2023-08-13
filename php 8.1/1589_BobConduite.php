<?php
$entrada = trim(fgets(STDIN));
for($i = 0; $i < $entrada; $i++){
    $raios = explode(" ",fgets(STDIN));
    $soma = $raios[0]+$raios[1];
    echo $soma.PHP_EOL;
}
?>
