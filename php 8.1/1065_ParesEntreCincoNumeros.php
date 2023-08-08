<?php
$contador = 0;
for ($i = 1; $i <= 5; $i ++) {
    $entrada = fgets(STDIN);
    if ($entrada % 2 == 0) {
        $contador ++;
    }
}
echo $contador." valores pares".PHP_EOL;
?>
