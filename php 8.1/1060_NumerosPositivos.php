<?php
$contador = 0;
for ($i = 1; $i <= 6; $i ++) {
    $entrada = fgets(STDIN);
    if ($entrada > 0) {
        $contador ++;
    }
}
echo $contador . " valores positivos" . PHP_EOL;
?>
