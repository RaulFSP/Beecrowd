<?php
$entrada = trim(fgets(STDIN));
$resultado = 0;
for ($i = 1; $i <= $entrada; $i ++) {
    $pedido = explode(" ",fgets(STDIN));
    $valor = 0;
    switch($pedido[0]) {
        case 1001: $valor = 1.50; break;
        case 1002: $valor = 2.50; break;
        case 1003: $valor = 3.50; break;
        case 1004: $valor = 4.50; break;
        case 1005: $valor = 5.50; break;
    }
    $resultado += $valor*$pedido[1];    
}
echo number_format($resultado,2,'.','').PHP_EOL;
?>
