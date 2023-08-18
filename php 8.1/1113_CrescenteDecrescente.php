<?php
while (true) {
    $entrada = explode(" ", trim(fgets(STDIN)));
    if ($entrada[0] == $entrada[1]) 
        break;
    else if ($entrada[0] < $entrada[1])
        echo "Crescente".PHP_EOL;
    else 
        echo "Decrescente".PHP_EOL;
}
?>
