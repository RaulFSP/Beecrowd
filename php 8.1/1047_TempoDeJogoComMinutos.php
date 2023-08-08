<?php
$entrada = explode(" ", fgets(STDIN));
$tempo1 = ($entrada[0] * 60 + $entrada[1]);
$tempo2 = ($entrada[2] * 60 + $entrada[3]);
$resultado = 0;
if ($tempo2 > $tempo1) {
    $resultado = $tempo2 - $tempo1;
} else if ($tempo2 < $tempo1) {
    $resultado = $tempo2 + (1440-$tempo1);
} else {
    $resultado = 1440;
}
$horas = (int) ($resultado / 60);
$minutos = $resultado % 60;
echo "O JOGO DUROU $horas HORA(S) E $minutos MINUTO(S)" . PHP_EOL;
?>
