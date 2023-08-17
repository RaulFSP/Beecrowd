<?php
for($i = 0; $i < 100; $i++) {
    $entrada[] = fgets(STDIN);
    $maior = max($entrada);    
}
$lugar = array_search($maior, $entrada, true)+1;
echo $maior.$lugar.PHP_EOL;
?>
