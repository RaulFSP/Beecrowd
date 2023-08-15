<?php
$vInter = 0;
$vGremio = 0;
$empate = 0;
$partidas = 0;
while (true) {
    $partidas ++;
    $entrada = explode(" ", fgets(STDIN));
    $inter = $entrada[0];
    $gremio = $entrada[1];
    if ($inter > $gremio)
        $vInter ++;
    else if ($inter < $gremio)
        $vGremio ++;
    else
        $empate ++;
    echo "Novo grenal (1-sim 2-nao)" . PHP_EOL;
    $novaPartida = fgets(STDIN);
    if ($novaPartida != 1)
        break;
}
echo $partidas . " grenais" . PHP_EOL;
echo "Inter:" . $vInter . PHP_EOL;
echo "Gremio:" . $vGremio . PHP_EOL;
echo "Empates:" . $empate . PHP_EOL;
switch (max($vInter, $vGremio, $empate)) {
    case $vInter:
        echo "Inter venceu mais" . PHP_EOL;
        break;
    case $vGremio:
        echo "Gremio venceu mais" . PHP_EOL;
        break;
    case $empate:
        echo "Nao houve vencedor" . PHP_EOL;
        break;
}
?>
