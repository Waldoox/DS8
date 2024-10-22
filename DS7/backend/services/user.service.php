<?php
// user_service.php

require_once '../models/User.php';
require_once '../db/database.php';

class UserService {
    private $db;

    public function __construct($dbConnection) {
        $this->db = $dbConnection;
    }

    public function createUser($username, $password) {
        try {
            // Crear una nueva instancia de User
            $user = new User($username, $password);

            // Validar la unicidad del nombre de usuario
            $user->validateUniqueUser($this->db);
            $user->setPassword($password);

            // Guardar el usuario en la base de datos
            $stmt = $this->db->prepare('INSERT INTO users (username, password) VALUES (?, ?)');
            $stmt->execute([$user->getUsername(), $user->getPassword()]);
            $userId = $this->db->lastInsertId();

            // Guardar el ID en la sesión
            $_SESSION['user_id'] = $userId;

            return ['success' => true, 'message' => 'Usuario creado exitosamente.'];
        } catch (Exception $e) {
            return ['success' => false, 'message' => $e->getMessage()];
        }
    }

    public function loginUser($username, $password) {
        $stmt = $this->db->prepare('SELECT * FROM users WHERE username = ?');
        $stmt->execute([$username]);
        $user = $stmt->fetch(PDO::FETCH_ASSOC);

        if (!$user) {
            return false;
        }

        if (password_verify($password, $user['password'])) {
            $_SESSION['user_id'] = $user['id'];
            return new User($user['username'], $user['password']);
        } else {
            return false;
        }
    }


}




?>