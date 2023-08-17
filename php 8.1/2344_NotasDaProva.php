<?php
    $entrada = trim(fgets(STDIN));
    if ($entrada == 0) 
        echo "E".PHP_EOL;
     else if ($entrada > 0 && $entrada <= 35) 
        echo "D".PHP_EOL;
     else if ($entrada > 35 && $entrada <= 60) 
        echo "C".PHP_EOL;
     else if ($entrada > 60 && $entrada <= 85) 
        echo "B".PHP_EOL;
     else 
        echo "A".PHP_EOL;
?>
