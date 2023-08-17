<?php
$entrada = trim(fgets(STDIN));
for ($i = 2; $i <= $entrada; $i+=2) {
    echo $i."^2 = ".pow($i,2).PHP_EOL;;
}
?>
