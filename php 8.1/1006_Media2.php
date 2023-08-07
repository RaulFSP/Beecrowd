<?php
    $varA = fgets(STDIN);
    $varB = fgets(STDIN);
    $varC = fgets(STDIN);
    $media = ($varA*2.0+$varB*3.0+$varC*5.0)/10.0;
    echo "MEDIA = ".number_format($media,1,'.','').PHP_EOL;    
?>
