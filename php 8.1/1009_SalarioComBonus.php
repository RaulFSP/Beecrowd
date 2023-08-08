<?php
  $nome = fgets(STDIN);
  $salario = fgets(STDIN);
  $vendasMontante = fgets(STDIN);
  $percentualVendas = $vendasMontante*0.15;
  $totalMes = $percentualVendas+$salario;
  echo "TOTAL = R$ ".number_format($totalMes,2,'.','').PHP_EOL;
?>
