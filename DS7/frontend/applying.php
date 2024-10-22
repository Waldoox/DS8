<?php
session_start();
if (!isset($_SESSION['username'])) {
    header('Location: index.php');
    exit();
}

$message = isset($_SESSION['message']) ? $_SESSION['message'] : '';
unset($_SESSION['message']);

// Obtener el ID del usuario de la sesión
$userId = $_SESSION['user_id']; // Asegúrate de que el ID del usuario esté almacenado en la sesión

// Incluir el servicio del solicitante
require_once  '../backend/services/applicant.service.php';
require_once '../backend/db/database.php';

// Crear una conexión a la base de datos
$database = new Database();
$dbConnection = $database->connect();
$applicantService = new ApplicantService($dbConnection);

// Verificar si el solicitante ya existe
$applicantExists = $applicantService->applicantExists($userId);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./css/applying.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;500;600&display=swap" rel="stylesheet">
    <title>Aplicar</title>

</head>
<body class="wrapper">
<?php if ($applicantExists): ?>
    <section class="sidebar">
        <div class="sidebar__principal">
            <img class="sidebar__logo" src="./img/LogoParcial2.png" alt="Consultec">
            <h2>TalentEase</h2>
            <h3>Completa tu Aplicación</h3>
        </div>

        <div class="cont-iz-ab">
            <p> <br><a href="./logout.php" class="link-celeste">Cerrar sesión </a></p>
        </div>
    </section>

    <section class="content">
        <h1>Ya has enviado tus datos para la aplicación.</h1>
    </section>


<?php else: ?>
    <section class="sidebar">
        <div class="sidebar__principal">
            <img class="sidebar__logo" src="./img/LogoParcial2.png" alt="Consultec">
            <h2>TalentEase</h2>
            <h3>Completa tu Aplicación</h3>
        </div>

        <div class="cont-iz-ab">
            <p> <br><a href="./logout.php" class="link-celeste">Cerrar sesión </a></p>
        </div>
    </section>

    <section class="content">
        <div>
            <form action="../backend/controllers/applicant.controller.php" method="post" class="formulario" id="formularioRegistro">
                <h1>Información Personal</h1>

                <div class="form-row">
                    <div class="form-group">
                        <label for="idCard">Cédula o Pasaporte</label>
                        <input type="text" name="idCard" id="idCard" class="formulario__input" required>
                    </div>
                    <div class="form-group">
                        <label for="firstName">Nombre</label>
                        <input type="text" name="firstName" id="firstName" class="formulario__input" required>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group">
                        <label for="lastName">Apellido</label>
                        <input type="text" name="lastName" id="lastName" class="formulario__input" required>
                    </div>
                    <div class="form-group">
                        <label for="maritalStatus">Estado Civil</label>
                        <select name="maritalStatus" id="maritalStatus" class="formulario__input">
                            <option value="">Seleccione</option>
                            <option value="soltero">Soltero</option>
                            <option value="casado">Casado</option>
                            <option value="divorciado">Divorciado</option>
                            <option value="viudo">Viudo</option>
                        </select>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group">
                        <label for="gender">Género</label>
                        <select name="gender" id="gender" class="formulario__input" required>
                            <option value="">Seleccione</option>
                            <option value="masculino">Masculino</option>
                            <option value="femenino">Femenino</option>
                            <option value="otro">Otro</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="bloodType">Tipo de Sangre</label>
                        <input type="text" name="bloodType" id="bloodType" class="formulario__input">
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group">
                        <label for="birthDate">Fecha de Nacimiento</label>
                        <input type="date" name="birthDate" id="birthDate" class="formulario__input" required>
                    </div>
                    <div class="form-group">
                        <label for="nationality">Nacionalidad</label>
                        <input type="text" name="nationality" id="nationality" class="formulario__input" required>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group">
                        <label for="phone">Teléfono</label>
                        <input type="tel" name="phone" id="phone" class="formulario__input" required>
                    </div>
                    <div class="form-group">
                        <label for="residence">Residencia</label>
                        <input type="text" name="residence" id="residence" class="formulario__input" required>
                    </div>
                </div>

                <div class="form-group">
                    <label for="email">Correo Electrónico</label>
                    <input type="email" name="email" id="email" class="formulario__input" required>
                </div>

                <input type="submit" value="Enviar Aplicacion" class="formulario__boton">
            </form>
        </div>
    </section>

<?php endif; ?>

<script>
    <?php if ($message): ?>
    alert("<?php echo $message; ?>");
    <?php endif; ?>
</script>

</body>
</html>
