<?php
$continuar = true;
while ($continuar) {
    $contador = 0;
    while ($contador != 2) {
        $valores = trim(fgets(STDIN));
        if ($valores < 0 || $valores > 10) {
            echo "nota invalida" . PHP_EOL;
        } else {
            $media[] = $valores;
            $contador ++;
        }
    }
    $resultado = (array_sum($media) / count($media));
    echo "media = " . number_format($resultado, 2, '.', '') . PHP_EOL;
    while (true) {
        echo "novo calculo (1-sim 2-nao)" . PHP_EOL;
        $novo = trim(fgets(STDIN));
        if ($novo == 1) {
            $continuar = true;
            break;
        } else if ($novo == 2) {
            $continuar = false;
            break;
        }
    }
    unset($media);
}
?>
