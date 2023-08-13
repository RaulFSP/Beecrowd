<?php
$bolinhas = trim(fgets(STDIN));
$galhos = trim(fgets(STDIN));
$razao = (int)(($galhos/2)-$bolinhas);
if ($razao <= 0) {
    echo "Amelia tem todas bolinhas!".PHP_EOL;
} else {
    echo "Faltam ".number_format($razao,0,'.','')." bolinha(s)".PHP_EOL;
}
?>
