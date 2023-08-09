<?php
$distancia = trim(fgets(STDIN));
$combustivelGasto = trim(fgets(STDIN));
$media = number_format(($distancia/$combustivelGasto),3,'.','');
echo $media." km/l".PHP_EOL;
?>
