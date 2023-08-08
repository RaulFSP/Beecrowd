<?php
    $entrada = fgets(STDIN);
    switch ($entrada) {
        case 61: echo "Brasilia".PHP_EOL; break;
        case 71: echo "Salvador".PHP_EOL;break;
        case 11: echo "Sao Paulo".PHP_EOL;break;
        case 21: echo "Rio de Janeiro".PHP_EOL;break;
        case 32: echo "Juiz de Fora".PHP_EOL;break;
        case 19: echo "Campinas".PHP_EOL;break;
        case 27: echo "Vitoria".PHP_EOL;break;
        case 31: echo "Belo Horizonte".PHP_EOL;break;
        default: echo "DDD nao cadastrado".PHP_EOL; break;
    }
?>
