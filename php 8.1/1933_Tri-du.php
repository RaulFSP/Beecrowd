<?php
$entrada = explode(" ", trim(fgets(STDIN)));
$primeiro = $entrada[0];
$segundo = $entrada[1];
if ($primeiro == $segundo)
    echo $primeiro . PHP_EOL;
else
    echo max($primeiro, $segundo) . PHP_EOL;
?>
