<?php
class Database {
    private $host = 'localhost';
    private $dbName = 'nombre_base_datos';
    private $username = 'usuario';
    private $password = 'contraseña';
    private $connection;

    public function connect() {
        try {
            $this->connection = new PDO("mysql:host={$this->host};dbname={$this->dbName}", $this->username, $this->password);
            $this->connection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        } catch (PDOException $e) {
            echo "Connection failed: " . $e->getMessage();
        }
        return $this->connection;
    }
}
