<?php
while (true) {
    $entrada = explode(" ", fgets(STDIN));
    $maior = max($entrada);
    $menor = min($entrada);
    if ($maior <= 0 || $menor <= 0) {
        break;
    } else {
        $vetor = range($menor, $maior, 1);
        foreach ($vetor as $i) {
            echo $i . " ";
        }
        echo "Sum=" . array_sum($vetor) . PHP_EOL;
    }
}
?>
