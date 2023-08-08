<?php
    $input = explode(" ", fgets(STDIN));
    $media = ($input[0]*2.0+$input[1]*3.0+$input[2]*4.0+$input[3]*1.0)/10.0;    
    $mediaFormatada = number_format((floor($media * 100) / 100),1,'.','');
    echo "Media: ".$mediaFormatada.PHP_EOL;
    if ($mediaFormatada >= 7.0) {
        echo "Aluno aprovado.".PHP_EOL;
    } else if ($mediaFormatada >= 5.0 && $mediaFormatada < 7.0) {
        echo "Aluno em exame.".PHP_EOL;      
        $notaExame = fgets(STDIN);
        echo "Nota do exame: ".$notaExame;
        $resultadoFinal = number_format(($notaExame+$mediaFormatada)/2.0,1,'.','');
        if ($resultadoFinal >= 5.0) {
            echo "Aluno aprovado.".PHP_EOL;
            echo "Media final: ".$resultadoFinal.PHP_EOL;
        } else {
            echo "Aluno reprovado.".PHP_EOL;
            echo "Media final: ".$resultadoFinal.PHP_EOL;
        }
    } else {
        echo "Aluno reprovado.".PHP_EOL;
    }
?>
