<?php
$entrada = trim(fgets(STDIN));
for($i = 1; $i <= $entrada; $i++) {
    if ($entrada%$i==0) {
        echo $i.PHP_EOL;
    }
}
?>
