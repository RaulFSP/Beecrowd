<?php
  $linha1 = explode(" ", fgets(STDIN));
  $linha2 = explode(" ", fgets(STDIN));
  $resultado = number_format($linha1[1]*$linha1[2]+$linha2[1]*$linha2[2],2,".","");
  echo "VALOR A PAGAR: R$ ".$resultado.PHP_EOL;
?>
