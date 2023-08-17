<?php
for($i = 0; $i < 5; $i++) {
    $entrada[] = trim(fgets(STDIN));
}
$total = $entrada[0]*300+$entrada[1]*1500+$entrada[2]*600+$entrada[3]*1000+$entrada[4]*150+225;
echo $total.PHP_EOL;
?>
