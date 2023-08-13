<?php
$contador = 0;
$entrada = trim(fgets(STDIN));
$escolhas = explode(" ", fgets(STDIN));
foreach($escolhas as $leitor) {
    if ($leitor == $entrada)
        $contador++;
}
echo $contador.PHP_EOL;
?>
