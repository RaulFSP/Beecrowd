<?php
    $horas = fgets(STDIN);
    $velocidade = fgets(STDIN);
    $mediaVeiculo = 12;
    $litros = (($horas * $velocidade) / $mediaVeiculo);
    echo number_format($litros,3, '.', '') . PHP_EOL;
?>
