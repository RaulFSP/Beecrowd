<?php
while (true) {
    $entrada = trim(fgets(STDIN));
    if ($entrada == "") {
        break;
    } else {

        for ($i = 0; $i < $entrada; $i ++) {
            for ($j = 0; $j < $entrada; $j ++) {
                if ($j == ($entrada - 1) - $i) {
                    echo 2;
                } else if ($j == $i) {
                    echo 1;
                } else {
                    echo 3;
                }
            }
            echo PHP_EOL;
        }
    }
}
?>
