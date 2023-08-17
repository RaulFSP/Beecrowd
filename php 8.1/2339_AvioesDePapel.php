<?php
$entrada = explode(" ", fgets(STDIN));
$numCompetidores = $entrada[0];
$qtdFolhas = $entrada[1];
$qtdReceber = $entrada[2];
if ($numCompetidores * $qtdReceber <= $qtdFolhas) {
    echo "S" . PHP_EOL;
} else {
    echo "N" . PHP_EOL;
}
?>
