<?php
do {
    $entrada = trim(fgets(STDIN));
    if ($entrada < 0) {
        echo number_format($media,2,'.','').PHP_EOL;
        break;
    }
    $idades[] = $entrada;
    $media = array_sum($idades)/count($idades);    
}while(true);
?>
