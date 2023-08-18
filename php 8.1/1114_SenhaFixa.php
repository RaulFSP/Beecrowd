<?php
while (true) {
    $entrada = trim(fgets(STDIN));
    if ($entrada == 2002) {
        echo "Acesso Permitido" . PHP_EOL;
        break;
    } else {
        echo "Senha Invalida" . PHP_EOL;
    }
}
?>
