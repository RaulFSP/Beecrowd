<?php
$entrada = explode(" ", fgets(STDIN));
$saldo = $entrada[1];
$vetor;
for ($i = 0; $i < $entrada[0]; $i ++) {
    $movimento = trim(fgets(STDIN));
    $vetor[] = $saldo += $movimento;
}
echo min($vetor) . PHP_EOL;
?>
