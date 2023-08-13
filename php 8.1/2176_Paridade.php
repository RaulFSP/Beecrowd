<?php
$soma = 0;
$entrada = trim(fgets(STDIN));
$teste = str_split($entrada,1);
foreach($teste as $leitor) {
    $soma+=$leitor;
}
if ($soma%2==0) {
    $teste[] = 0;
    foreach($teste as $leitor) {
        echo $leitor;
    }
    echo PHP_EOL;
} else {
    $teste[] = 1;
    foreach($teste as $leitor) {
        echo $leitor;
    }
    echo PHP_EOL;
}
?>
