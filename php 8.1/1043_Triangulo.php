<?php
$entrada = explode(" ",trim(fgets(STDIN)));
$a = $entrada[0];
$b = $entrada[1];
$c = $entrada[2];
$area = (($a+$b)/2.0)*$c;
$perimetro = $a+$b+$c;
if ($a >= ($b+$c) || $b >= ($a+$c) || $c >= ($b+$a)) {
    echo "Area = ".number_format($area,1,'.','').PHP_EOL;
} else {
    echo "Perimetro = ".number_format($perimetro,1,'.','').PHP_EOL;
}
?>
