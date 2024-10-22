<?php
class Database {
    private $host = '127.0.0.1';
    private $dbName = 'aspirants_db';
    private $username = 'user';
    private $password = 'pass';
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
