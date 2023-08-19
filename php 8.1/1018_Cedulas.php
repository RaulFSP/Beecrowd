<?php
$entrada = trim(fgets(STDIN));
$n100 = (int) ($entrada / 100);
$n50 = (int) ($entrada % 100 / 50);
$n20 = (int) ($entrada % 100 % 50 / 20);
$n10 = (int) ($entrada % 100 % 50 % 20 / 10);
$n5 = (int) ($entrada % 100 % 50 % 20 % 10 / 5);
$n2 = (int) ($entrada % 100 % 50 % 20 % 10 % 5 / 2);
$n1 = (int) ($entrada % 100 % 50 % 20 % 10 % 5 % 2);
echo $entrada.PHP_EOL;
echo $n100 . " nota(s) de R$ 100,00" . PHP_EOL;
echo $n50 . " nota(s) de R$ 50,00" . PHP_EOL;
echo $n20 . " nota(s) de R$ 20,00" . PHP_EOL;
echo $n10 . " nota(s) de R$ 10,00" . PHP_EOL;
echo $n5 . " nota(s) de R$ 5,00" . PHP_EOL;
echo $n2 . " nota(s) de R$ 2,00" . PHP_EOL;
echo $n1 . " nota(s) de R$ 1,00" . PHP_EOL;
?>
