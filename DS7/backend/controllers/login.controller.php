<?php
session_start();

require_once '../models/User.php';
require_once '../db/database.php';
require_once '../services/user.service.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Recibir los datos del formulario
    $username = trim($_POST['username']);
    $password = trim($_POST['password']);

    // Verificar si los campos están vacíos
    if (empty($username) || empty($password)) {
        $_SESSION['message'] = 'Los campos de usuario y contraseña no pueden estar vacíos.';
        header('Location: ../../frontend/index.php');
        exit();
    }

    // Conectar a la base de datos
    $database = new Database();
    $dbConnection = $database->connect();
    $userService = new UserService($dbConnection);

    try {
        // Intentar iniciar sesión con las credenciales proporcionadas
        $user = $userService->loginUser($username, $password);

        if ($user) {
            // Si las credenciales son correctas, establecer la sesión
            $_SESSION['username'] = $user->getUsername();
            $_SESSION['message'] = 'Inicio de sesión exitoso. Bienvenido, ' . $user->getUsername() . '!';
            header('Location: ../../frontend/applying.php');
        } else {
            // Si las credenciales no son correctas, mostrar un mensaje de error
            $_SESSION['message'] = 'Credenciales incorrectas. Por favor, intenta de nuevo.';
            header('Location: ../../frontend/index.php');
        }
    } catch (Exception $e) {
        $_SESSION['message'] = 'Error: ' . $e->getMessage();
        header('Location: ../../frontend/index.php');
    }

    exit();
} else {
    echo json_encode(['success' => false, 'message' => 'Método no permitido.']);
}
