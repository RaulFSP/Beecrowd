<?php
$primeiro = trim(fgets(STDIN));
$segundo = trim(fgets(STDIN));
$maior = max($primeiro, $segundo);
$menor = min($primeiro,$segundo);
$soma = 0;
for($i = $menor; $i <= $maior; $i++) {
    if ($i%13!=0) {
        $soma += $i;
    }
}
echo $soma.PHP_EOL;
?>
