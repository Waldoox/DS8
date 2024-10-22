<?php
class User {
    private $username;
    private $password;

    public function __construct($username, $password) {
        $this->username = $username;
        $this->password = $password;
    }

    public function setPassword($password) {
        if (strlen($password) < 8 ||
            !preg_match('/[A-Za-z]/', $password) ||
            !preg_match('/[0-9]/', $password) ||
            !preg_match('/[\W_]/', $password)) {
            throw new Exception('La contraseña debe tener al menos 8 caracteres y contener letras, números y caracteres especiales.');
        }
        $this->password = password_hash($password, PASSWORD_DEFAULT);
    }

    public function getUsername() {
        return $this->username;
    }

    public function getPassword() {
        return $this->password;
    }

    public function validateUniqueUser($db) {
        $stmt = $db->prepare('SELECT * FROM users WHERE username = ?');
        $stmt->execute([$this->username]);
        if ($stmt->rowCount() > 0) {
            throw new Exception('El nombre de usuario ya está en uso.');
        }
    }
}
?>