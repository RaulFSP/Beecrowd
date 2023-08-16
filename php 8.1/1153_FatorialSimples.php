<?php
$entrada = fgets(STDIN);
$soma = 1;
for ($i = $entrada; $i > 0; $i --) {
    $soma *= $i;
}
echo $soma . PHP_EOL;
?>
