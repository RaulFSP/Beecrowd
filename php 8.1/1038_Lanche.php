<?php
$entrada = explode(" ",fgets(STDIN));
$codigo = $entrada[0];
$quantidade = $entrada[1];
$valor = 0;
switch ($codigo) {
    case 1: $valor = 4.00; break;
    case 2: $valor = 4.50; break;
    case 3: $valor = 5.00; break;
    case 4: $valor = 2.00; break;
    case 5: $valor = 1.50; break;
    default: $valor = 0; break;
}
$total = $valor * $quantidade;
echo "Total: R$ ".number_format($total,2,'.','').PHP_EOL;
?>
