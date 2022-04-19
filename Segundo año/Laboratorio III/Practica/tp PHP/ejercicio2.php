<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>tablas bucles</title>
</head>
<body>
    <?php
echo "<p>tabla del 5 </p>";
?>
    <table>
    <tbody>
        
<?php
       
       
    for($i=0; $i<=10; $i++){  
        $x=5; 
        echo"<tr>";
	echo '<th> '.$i.' * '.$x.' = '.$i*$x.' </th> ';
    echo"</tr>";
    }?>

<p>tabla del 6 </p>
    
   
</tbody>
    </table>
    <table>
    <tbody>
    <?php
    
  echo" <p>tabla del 6 </p>";
    $x=6;
    $i=0;
   while($i<=10){
    echo"<tr>";
        echo '<th> '.$i.' * '.$x.' = '.$i*$x.' </th> ';
        $i++;
        echo"</tr>";
    }
    ?>

</table>
</tbody>


<table>
    <tbody>
    <?php
    
 
  echo "<p>tabla del 7 </p>";
  $p=7;
  $t=0;
     do{
        echo"<tr>";
          echo '<th> '.$t.' * '.$p.' = '.$p*$t.'</th> ';
          $t++;
          echo"</tr>";
      }while($t!=11)
    ?>

</table>
</tbody>
</body>
</html>





/* <?php 
/*echo "<p>tabla del 5 </p>";
/*$x=5; 

/*

    
	echo '<td>[ '.$i.' * '.$x.' = '.$i*$x.' ]</td> ';


    while($i<=10){
        echo '<p>[ '.$i.' * '.$x.' = '.$i*$x.' ]</p> ';
        $i++;
    }
    echo "<p>tabla del 7 </p>";
$p=7;
$t=0;
/*    do{
        echo '<p>[ '.$t.' * '.$p.' = '.$p*$t.' ]</p> ';
        $t++;
    }while($t!=11)

?> */