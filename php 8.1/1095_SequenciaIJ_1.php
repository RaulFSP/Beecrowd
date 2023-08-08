<?php
$I = 1;
$J = 60;
for($i = 1; $i <= 13; $i++) {
	for($j = 1; $j < 2; $j++) {
		if ($i == 1) {
			echo "I=$I J=$J";
		} else {
			echo "I=".$I+=3;
			echo " ";
			echo "J=".$J-=5;
		}
	}
	echo PHP_EOL;
}
?>
