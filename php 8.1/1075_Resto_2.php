<?php
$entrada = trim(fgets(STDIN));
for($i = 1; $i <= 10000; $i++) {
    echo ($i%$entrada==2) ? $i.PHP_EOL :"";
}
?>
