<?php
$negativo = 0;
$positivo = 0;
$par = 0;
$impar = 0;
for($i=0; $i < 5; $i++) {
    $entradas[] = trim(fgets(STDIN));
    if ($entradas[$i] < 0) {
        $negativo++;
    } else if ($entradas[$i] > 0){
        $positivo++;
    }
    if ($entradas[$i]%2==0) {
        $par++;
    } else {
        $impar++;
    }
}
echo "$par valor(es) par(es)".PHP_EOL;
echo "$impar valor(es) impar(es)".PHP_EOL;
echo "$positivo valor(es) positivo(s)".PHP_EOL;
echo "$negativo valor(es) negativo(s)".PHP_EOL;
?>
