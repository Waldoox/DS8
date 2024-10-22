<?php
session_start();
if (isset($_SESSION['username'])) {
    // Redirige a la página deseada, por ejemplo, la página principal o el panel de usuario
    header('Location: applying.php');
    exit();
}


$message = isset($_SESSION['message']) ? $_SESSION['message'] : '';
unset($_SESSION['message']);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./css/login.css">
    <title>Parcial 2</title>
</head>
<body>
<section class="cont-prin">
    <div class="cont-prin-log colo-celeste flex-center">
        <div class="cont-iz-ar">
            <img class="sidebar__logo" src="./img/LogoParcial2.png" alt="ConsulTec">
            <h2>Te damos la bienvenida a TalentEase</h2>
        </div>
        <div class="cont-iz-ab">
            <p>¿Aún no tienes una cuenta? <br><a href="./register.php" class="link-celeste">Regístrate ahora</a></p>
        </div>
    </div>
    <div class="cont-prin-log color-wh">
        <div class="cont-flex">
            <form action="../backend/controllers/login.controller.php" method="post" class="form-log" id="form-log">
                <h1><span class="color-celeste">Inicio de</span> sesión</h1>
                <div class="form-log-inp">
                    <input type="text" name="username" placeholder="Ingresa tu Usuario" class="input-from-log" id="username">
                    <input type="password" name="password" placeholder="Ingresa tu contraseña" class="input-from-log" id="password">
                </div>
                <input type="submit" value="Iniciar sesión" class="btn-negro">
                <p id="error-message" class="error-message"></p>
            </form>
        </div>
    </div>
</section>
<script>
    <?php if ($message): ?>
    alert("<?php echo $message; ?>");
    <?php endif; ?>
</script>

</body>
</html>

