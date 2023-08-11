<?php
  $entrada = fgets(STDIN);
  $ano = (int) ($entrada/365);
  $mes = (int) ($entrada%365/30);
  $dia = (int) ($entrada%365%30);
  echo "$ano ano(s)\n$mes mes(es)\n$dia dia(s)".PHP_EOL;
?>
