<?php //Ejemplo curso PHP aprenderaprogramar.com

$time = time();
echo"<p>";
echo  date("d-m-Y ", $time);
echo"</p> <p> ";
echo  date("d/m/Y ", $time);
echo"</p> <p> ";
echo date("l d-F m-Y ", $time);
echo"</p> ";
?>