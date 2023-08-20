<?php
$s = 1;
$base = 2;
for ($i = 3; $i <= 39; $i += 2) {
    $s += $i / $base;
    $base*=2;
}
echo number_format($s, 2, '.', '') . PHP_EOL;
?>
