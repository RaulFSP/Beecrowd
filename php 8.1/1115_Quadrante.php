<?php
while (true) {    
    $entrada = explode(" ", fgets(STDIN));
    $primeiro = $entrada[0];
    $segundo = $entrada[1];
    if ($primeiro > 0 && $segundo > 0) echo "primeiro".PHP_EOL;
    else if ($primeiro < 0 && $segundo > 0) echo "segundo".PHP_EOL;
    else if ($primeiro < 0 && $segundo < 0) echo "terceiro".PHP_EOL;
    else if ($primeiro > 0 && $segundo < 0) echo "quarto".PHP_EOL;
    else break;
}
?>
