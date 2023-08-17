<?php
$entrada = explode(" ", fgets(STDIN));
$maior = max($entrada[0], $entrada[1]);
$menor = min($entrada[0], $entrada[1]);
echo ($maior % $menor == 0) ? "Sao Multiplos" . PHP_EOL : "Nao sao Multiplos" . PHP_EOL;
?>
