<?php
$entrada = trim(fgets(STDIN));
$contador = 1;
for($i = 0; $i < $entrada; $i++) {
    for($j = 1; $j <= 4; $j++) {
        if ($j == 4) {
            echo "PUM";
            $contador++;
        } else {
            echo $contador." ";
            $contador++;
        }
    }
    echo PHP_EOL;
}
?>
