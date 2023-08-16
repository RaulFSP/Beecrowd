<?php
$entrada = trim(fgets(STDIN));
for($i = 1; $i <= 10; $i++) {
    echo $i." x ".$entrada." = ".($i*$entrada).PHP_EOL;
}
?>
