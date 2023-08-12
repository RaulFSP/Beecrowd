<?php
for ($i = 0; $i <= 2; $i = $i + 0.2) {
    $h = 1;    
    for ($j = 1; $j <= 3; $j++) {
        echo "I=$i J=".($h+$i).PHP_EOL;
        $h++;
    }
}
?>
