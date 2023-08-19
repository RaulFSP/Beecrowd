<?php
$entrada = explode(" ",trim(fgets(STDIN)));
$coluna = $entrada[0];
$linha = $entrada[1];
$contador = 1;
for($i = 0; $i < $linha/$coluna; $i++) {
    for ($j = 0; $j < $coluna; $j++) {
        echo $contador++;
        if ($j < $coluna-1) {
            echo " ";
        }
    }
    echo PHP_EOL;
}
?>
