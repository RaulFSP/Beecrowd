<?php
    $i = 1;
    while($i < 10) {
        $h = 8;
        for($j = 1; $j <= 3; $j++) {
            echo "I=".$i." "."J=".($h-=1).PHP_EOL;
        }
        $i+=2;
    }
?>
