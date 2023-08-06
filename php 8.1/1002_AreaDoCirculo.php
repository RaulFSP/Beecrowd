<?php
    $raio = trim(fgets(STDIN)).PHP_EOL;
    $area = 3.14159 * pow($raio,2.0);
    echo "A=".number_format($area,4,'.','').PHP_EOL;
?>
