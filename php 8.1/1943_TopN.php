<?php
$entrada = trim(fgets(STDIN));
if ($entrada == 1)
    echo "Top 1".PHP_EOL;
else if ($entrada <= 3)
    echo "Top 3".PHP_EOL;
else if ($entrada <= 5)
    echo "Top 5".PHP_EOL;
else if ($entrada <= 10)
    echo "Top 10".PHP_EOL;
else if ($entrada <= 25)
    echo "Top 25".PHP_EOL;
else if ($entrada <= 50)
    echo "Top 50".PHP_EOL;
else 
    echo "Top 100".PHP_EOL;
?>
