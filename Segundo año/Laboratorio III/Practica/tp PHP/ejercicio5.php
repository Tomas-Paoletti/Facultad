<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>formulario simple</title>
</head>
<body>
        <h1>Registro</h1>
    <form action="">
        <p>Nombre y Apellido:</p>
    <label for="nombre"></label>
    <input type="text" name="nombre" placeholder="Ingrese su nombre" required >
    <p> Dni:</p>
    <label for="dni"></label>
    <input type="number" name="dni" placeholder="Ingrese su Dni"  required>
    <p> Email:</p>
    <label for="email"></label>
    <input type="email" name="email" placeholder="Ingrese su email"  required>
    <p> Sexo:</p>
    <label for="sexo"></label>
    <input type="radio" name="sexo" value="Hombre "> Hombre<br/>
   <input type="radio" name="sexo" value="Mujer "> Mujer<br/>
    <p> Direccion :</p>
    <label for="sir"></label>
    <input type="text" name="dir" placeholder="Ingrese su direccion(calle, nro y, localidad y departamento" >
    <p>Edad :</p>
    <label for="edad"></label>
    <input type="number" name="edad" required placeholder="Ingrese su edad" >
    <p>Estado de civil :</p>
    <label for="estado"></label>
    <input type="text" name="estado"required placeholder="Ingrese su estado de civil" >
    <p>Hijos :</p>
    <label for="hijos"></label>
    <input type="number" name="hijos" placeholder="Ingrese la cantidad de hijos" required >
    <p>Hobbies:</p>
    <label for="hobby"></label>
    <input type="radio" name="hobbies" value="Deportes "> Deportes<br/>
   <input type="radio" name="hobbies" value="Cine "> Cine<br/>
   <input type="radio" name="hobbies" value="Libros"> Libros<br/>
   <input type="radio" name="hobbies" value="Ciencia"> Ciencia</p>
    <button type="submit" required>Entregar</button>
    </form>
    <?php 
    $nombre=$_REQUEST["nombre"];
    $dni=$_REQUEST["dni"];
    $email=$_REQUEST["email"];
    $sexo=$_REQUEST["sexo"];
    $dir=$_REQUEST["dir"];
    $edad=$_REQUEST["edad"];
    $estado_civil=$_REQUEST["estado"];
    $hijos=$_REQUEST["hijos"];
    $hobbies=$_REQUEST["hobbies"];
    
    echo "<h2>Resultados del formulario</h2>";
    echo" <p> Nombre:  ".$nombre."</p> "  ;
    echo" <p> Dni: ".$dni."</p> ";
    echo" <p> Email: ".$email."</p> ";
    echo" <p> Sexo: ".$sexo."</p> ";
    echo" <p> Direccion: ".$dir."</p> ";
    echo" <p> Edad: ".$edad."</p> ";
    echo" <p> Estado Civil: ".$estado_civil."</p> ";
    echo" <p> hijos: ".$hijos."</p> ";
    echo" <p> hobbies: ".$hobbies."</p> ";
    ?>/body>
</html>