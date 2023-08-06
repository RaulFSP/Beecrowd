<?php
    $varA = fgets(STDIN);
    $varB = fgets(STDIN);
    $media= ($varA*3.5+$varB*7.5)/11;
    echo "MEDIA = ".number_format($media,5,'.','').PHP_EOL;    
?>
