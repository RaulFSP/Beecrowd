<?php
$primeiro = trim(fgets(STDIN));
$segundo = trim(fgets(STDIN));
$soma = 0;
$maior = max($primeiro,$segundo);
$menor = min($primeiro,$segundo);
for($i = $menor+1; $i < $maior; $i++) {
    if ($i%2!= 0) {
        $soma += $i;
    }
}
echo $soma.PHP_EOL;
?>
