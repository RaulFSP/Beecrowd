<?php
while (true) {
    $entrada = explode(" ", fgets(STDIN));    
    if ($entrada[0] == 0 && $entrada[1] == 0)
        break;
    else 
        echo $entrada[0] * $entrada[1] . PHP_EOL;
}
?>
