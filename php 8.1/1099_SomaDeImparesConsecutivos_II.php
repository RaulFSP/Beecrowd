<?php
$entrada = trim(fgets(STDIN));
for ($i = 0; $i < $entrada; $i ++) {
    $soma = 0;
    $valores = explode(" ", fgets(STDIN));
    $maior = max($valores);
    $menor = min($valores);
    for ($j = $menor + 1; $j < $maior; $j ++) {
        if ($j % 2 != 0) {
            $soma += $j;
        }
    }
    echo $soma . PHP_EOL;
}
?>
