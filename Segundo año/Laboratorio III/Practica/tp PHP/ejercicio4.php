<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1> Tablas de multiplicar</h1>
    <hr>
    <form action"">
        <label for="numero"></label>
        <input type="number" name="numero1" placeholder="ingrese un numero">
        <input type="submit" value="Crear Tabla">
    </form>
</hr>
<p>tabla con for</p>
<?php
$numt= $_REQUEST['numero1'];

for($i=0;$i<=10;$i++){
    $resultado = $numt*$i;
    echo $numt. "*" .$i." = ".$resultado."<br>";
}
?>
 <form action"">
        <label for="numero"></label>
        <input type="number" name="numero2" placeholder="ingrese un numero">
        <input type="submit" value="Crear Tabla">
    </form>
</hr>
<p>tabla con while</p>
<?php
$numt= $_REQUEST['numero2'];
$i=0;
while($i!=11){
    $resultado = $numt*$i;
    echo $numt. "*" .$i." = ".$resultado."<br>";
$i++;
}
?>
 <form action"">
        <label for="numero"></label>
        <input type="number" name="numero3" placeholder="ingrese un numero">
        <input type="submit" value="Crear Tabla">
    </form>
</hr>
<?php
$numt= $_REQUEST['numero3'];
$i=0;
do{
    $resultado = $numt*$i;
    echo $numt. "*" .$i." = ".$resultado."<br>";
$i++;
}while($i!=11)
?>
</body>
</html>