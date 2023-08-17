<?php
$entrada = trim(fgets(STDIN));
for($i = 1; $i <= $entrada; $i++) {
    if ($i%2!=0) {
        echo $i.PHP_EOL;
    }
}
?>
