<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./css/register.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600&display=swap" rel="stylesheet">
    <title>Registro</title>
</head>
<body class="wrapper">
    <section class="sidebar">
        <div class="sidebar__principal">
            <img class="sidebar__logo" src="./img/LogoParcial2.png" alt="Consultec">
            <h2>Te damos la bienvenida a TalentEase</h2>
        </div>
        <div class="sidebar__footer">
            <p>¿Ya tienes una cuenta? <a href="./login.php" class="sidebar__enlace-login">Iniciar sesión</a></p>
        </div>
    </section>

    <section class="content">
        <div>
            <h1 class="content__titulo"><span>Crear</span> Cuenta</h1>
            <form action="" class="formulario" id="formularioRegistro">
                <input type="text" name="user" id="user" placeholder="Ingresa tu Usuario" class="formulario__input" required>
                <input type="password" name="contraseña" id="contraseña" placeholder="Ingresa tu nueva contraseña" class="formulario__input" required>
                <input type="password" name="reptcontraseña" id="reptcontraseña" placeholder="Repite la contraseña que ingresaste" class="formulario__input" required>
                <input type="submit" value="Crear Cuenta" class="formulario__boton">
            </form>
        </div>
    </section>
</body>
</html>
