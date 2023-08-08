<?php
    $i = 1;
    $h = 6;
    while($i < 10) {
        $h += 2;
        $soma = $h;
        for($j = 1; $j <= 3; $j++) {
            echo trim("I=".$i." "."J=".($soma-=1)).PHP_EOL;
        }
        $i+=2;
    }
?>
