<?php
$entrada = 0;
while ($entrada != "") {
    $entrada = trim(fgets(STDIN));
    if ($entrada == "") {
        echo ("");
    } else {
        echo ($entrada - 1) . PHP_EOL;
    }
}
?>
