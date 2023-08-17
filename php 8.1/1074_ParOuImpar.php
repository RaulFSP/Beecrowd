<?php
$entrada = trim(fgets(STDIN));
for($i = 0; $i < $entrada; $i++) {
    $numero = trim(fgets(STDIN));
    if ($numero == 0) {
        echo "NULL".PHP_EOL;
    } else {
    if ($numero%2==0)
        echo "EVEN ";
    else 
        echo "ODD ";
    if ($numero < 0)
        echo "NEGATIVE".PHP_EOL;
    else
        echo "POSITIVE".PHP_EOL;
    }
}
?>
