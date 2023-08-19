<?php
$alcool = 0;
$gasolina = 0;
$diesel = 0;
$ativo = true;
while ($ativo) {
    $entrada = trim(fgets(STDIN));
    switch ($entrada) {
        case 1:
            $alcool ++;
            break;
        case 2:
            $gasolina ++;
            break;
        case 3:
            $diesel ++;
            break;
        case 4:
            $ativo = false;
            break;
    }
}
echo "MUITO OBRIGADO" . PHP_EOL;
echo "Alcool: $alcool" . PHP_EOL;
echo "Gasolina: $gasolina" . PHP_EOL;
echo "Diesel: $diesel" . PHP_EOL;
?>
