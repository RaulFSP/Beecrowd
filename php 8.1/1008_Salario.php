<?php
    $numero = fgets(STDIN);
    $qtdHorasTrabalho = fgets(STDIN);
    $valorHora = fgets(STDIN);   
    $salario = number_format($qtdHorasTrabalho*$valorHora,2,'.','');
    echo "NUMBER = ".$numero;
    echo "SALARY = U$ ".$salario.PHP_EOL;   
?>
