<?php
$contIn = 0;
$contOut = 0;
$reps = fgets(STDIN);

for ($i = 0; $i < $reps; $i++) {
    $entrada[] = trim(fgets(STDIN));
    if ($entrada[$i] >= 10 && $entrada[$i] <= 20) {
        $contIn++;
    } else {
        $contOut++;
    }
}
echo "$contIn in\n$contOut out" . PHP_EOL;
?>
