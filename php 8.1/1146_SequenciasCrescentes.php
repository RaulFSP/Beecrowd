<?php
do {
    $entrada = trim(fgets(STDIN));
    if ($entrada == 0) break;
    $vetor = range(1,$entrada,1);
    echo implode(" ", $vetor).PHP_EOL;    
} while ($entrada != 0);
?>
