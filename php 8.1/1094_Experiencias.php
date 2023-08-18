<?php
$total = 0;
$somaC = 0;
$somaR = 0;
$somaS = 0;
$entrada = trim(fgets(STDIN));
for ($i = 0; $i < $entrada; $i ++) {
    $valores = explode(" ", trim(fgets(STDIN)));
    $total += $valores[0];
    switch ($valores[1]) {
        case "C":
            $somaC += $valores[0];
            break;
        case "R":
            $somaR += $valores[0];
            break;
        case "S":
            $somaS += $valores[0];
            break;
    }
}
echo "Total: $total cobaias" . PHP_EOL;
echo "Total de coelhos: $somaC" . PHP_EOL;
echo "Total de ratos: $somaR" . PHP_EOL;
echo "Total de sapos: $somaS" . PHP_EOL;
echo "Percentual de coelhos: " . number_format(($somaC / $total) * 100, '2', '.', '') . " %" . PHP_EOL;
echo "Percentual de ratos: " . number_format(($somaR / $total) * 100, '2', '.', '') . " %" . PHP_EOL;
echo "Percentual de sapos: " . number_format(($somaS / $total) * 100, '2', '.', '') . " %" . PHP_EOL;
?>
