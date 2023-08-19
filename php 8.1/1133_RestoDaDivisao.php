<?php
$num1 = trim(fgets(STDIN));
$num2 = trim(fgets(STDIN));
$maior = max($num1,$num2);
$menor = min($num1,$num2);
for($i = $menor+1; $i < $maior; $i++) {
    if ($i%5 == 2 || $i%5 == 3) {
        echo $i.PHP_EOL;
    }
}
?>
