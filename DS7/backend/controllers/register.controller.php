<?php
session_start();

require_once '../models/User.php';
require_once '../db/database.php';
require_once '../services/user.service.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $username = trim($_POST['username']);
    $password = trim($_POST['password']);
    $repeatPassword = trim($_POST['repeatPassword']);

    if (empty($username) || empty($password)) {
        $_SESSION['message'] = 'Los campos de usuario y contraseña no pueden estar vacíos.';
        header('Location: ../../frontend/register.php');
        exit();
    }

    if ($password !== $repeatPassword) {
        $_SESSION['message'] = 'Las contraseñas no coinciden.';
        header('Location: ../../frontend/register.php');
        exit();
    }

    $database = new Database();
    $dbConnection = $database->connect();
    $userService = new UserService($dbConnection);

    $result = $userService->createUser($username, $password);

    if ($result['success']) {
        $_SESSION['username'] = $username;
        $_SESSION['message'] = 'Registro exitoso. Bienvenido, ' . $username . '!';
        header('Location: ../../frontend/applying.php');

    } else {
        $_SESSION['message'] = $result['message'];
        header('Location: ../../frontend/register.php');
        exit();
    }
    exit();
} else {
    echo json_encode(['success' => false, 'message' => 'Método no permitido.']);
}
?>