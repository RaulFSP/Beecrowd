<?php
$entrada = explode(" ", fgets(STDIN));
$abas = $entrada[0];
for ($i = 0; $i < $entrada[1]; $i ++) {
    $caso = trim(fgets(STDIN));
    if ($caso === "fechou") {
        $abas ++;
    } else {
        $abas --;
    }
}
echo $abas . PHP_EOL;
?>
