<?php
$contador = 0;
$positivos;
for ($i = 0; $i < 6; $i ++) {
    $entrada[] = fgets(STDIN);
    if ($entrada[$i] > 0) {
        $contador ++;
        $positivos[] = $entrada[$i];
    }
}
$media = number_format(array_sum($positivos) / count($positivos),1,'.','');
echo $contador . " valores positivos" . PHP_EOL;
echo $media . PHP_EOL;
?>
