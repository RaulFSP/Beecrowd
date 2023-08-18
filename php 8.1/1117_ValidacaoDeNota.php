<?php
$media;
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
?>
