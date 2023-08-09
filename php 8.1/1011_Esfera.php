<?php
$raio = fgets(STDIN);
$volumeEsfera = pow($raio,3)*3.14159*(4.0/3);
$resultado = number_format($volumeEsfera,3,'.','');
echo "VOLUME = ".$resultado.PHP_EOL;
?>
