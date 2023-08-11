<?php
  $entrada = explode(" ",fgets(STDIN));
  $a = $entrada[0];
  $b = $entrada[1];
  $c = $entrada[2];
  $d = $entrada[3];
  if ($b > $c && $d > $a && ($c+$d) > ($a+$b) && ($c+$d) > 0 && ($a+$b) > 0 && ($a%2==0)) 
      echo "Valores aceitos".PHP_EOL;
  else
      echo "Valores nao aceitos".PHP_EOL;
?>
