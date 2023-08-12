<?php
$entrada = fgets(STDIN);
for ($i = 0; $i < $entrada; $i++) {
    $teste = fgets(STDIN);
    if ($teste > 8000) {
        echo "Mais de 8000!".PHP_EOL;
    } else {
        echo "Inseto!".PHP_EOL;
    }
}
?>
