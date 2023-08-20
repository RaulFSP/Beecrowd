<?php
$tamanho = trim(fgets(STDIN));
$n1 = 1;
$n2 = 0;
if ($tamanho == 1) {
    echo $n2;
} else if ($tamanho == 2) {
    echo $n2." ".$n1;
} else {
    echo $n2." ".$n1." ";
    for ($i = 1; $i < $tamanho-1; $i ++) {
        $fibo = $n1 + $n2;
        echo $fibo;
        if ($i < $tamanho-2) {
            echo " ";
        }
        $n2 = $n1;
        $n1 = $fibo;
    }
}
echo PHP_EOL;

?>
