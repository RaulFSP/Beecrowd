<?php
$entrada = trim(fgets(STDIN));
for($i = 0; $i < $entrada; $i++) {
    $valores = explode(" ",trim(fgets(STDIN)));
    if ($valores[1] == 0) {
        echo "divisao impossivel".PHP_EOL;
    } else {
        $resultado = $valores[0]/$valores[1];
        echo number_format($resultado,1,'.','').PHP_EOL;
    }
}
?>
