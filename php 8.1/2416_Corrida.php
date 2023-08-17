<?php
$entrada = explode(" ",fgets(STDIN));
$metros = $entrada[0];
$comprimento = $entrada[1];
$ponto = $metros%$comprimento;
echo $ponto.PHP_EOL;
?>
