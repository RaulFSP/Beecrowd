<?php
$entrada = trim(fgets(STDIN));
for($i = 0; $i < $entrada; $i++) {
    $valores = explode(" ",fgets(STDIN));
    $resultado = ($valores[0]*2+$valores[1]*3+$valores[2]*5)/10.0;
    echo number_format($resultado,1,'.','').PHP_EOL;
}
?>
