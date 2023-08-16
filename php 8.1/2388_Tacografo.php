<?php
$entrada = fgets(STDIN);
$soma = 0;
for ($i = 0; $i < $entrada; $i ++) {
    $valores = explode(" ", fgets(STDIN));
    $soma += $valores[0] * $valores[1];
}
echo $soma . PHP_EOL;
?>
