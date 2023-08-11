<?php
  $entrada = fgets(STDIN);
  $horas = (int) ($entrada/3600);
  $minutos = (int) ($entrada%3600/60);
  $segundos = (int) ($entrada%3600%60);
  echo "$horas:$minutos:$segundos".PHP_EOL;
?>
