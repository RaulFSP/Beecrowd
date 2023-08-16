<?php
$contador = 1;
$valores;
$entrada = trim(fgets(STDIN));
for($i = 0; $i < $entrada; $i++) {    
    $atual = trim(fgets(STDIN));
    $valores[] = $atual;
    if($i > 0) {
        if ($atual != $valores[$i-1]) {
            $contador++;
        }
    }
}
echo $contador.PHP_EOL;
?>
