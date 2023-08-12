<?php
$entrada = explode(" ",trim(fgets(STDIN)));
$entradaSort = $entrada;
asort($entrada);
foreach ($entrada as $listagem) 
    echo $listagem.PHP_EOL;
echo PHP_EOL;
foreach ($entradaSort as $listagem)
    echo $listagem.PHP_EOL;
?>
