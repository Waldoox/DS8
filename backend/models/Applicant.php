<?php

class Applicant {
    private $idCard;         
    private $firstName;      
    private $lastName;       
    private $maritalStatus;  
    private $gender;        
    private $bloodType;     
    private $birthDate;     
    private $nationality;  
    private $phone;          
    private $residence;      
    private $email;         

    public function __construct($idCard, $firstName, $lastName, $maritalStatus, $gender, $bloodType, $birthDate, $nationality, $phone, $residence, $email) {
        $this->idCard = $idCard;
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->maritalStatus = $maritalStatus;
        $this->gender = $gender;
        $this->bloodType = $bloodType;
        $this->birthDate = $birthDate;
        $this->nationality = $nationality;
        $this->phone = $phone;
        $this->residence = $residence;
        $this->email = $email;

        $this->validateFields();
    }

    private function validateFields() {
        if (empty($this->idCard) || empty($this->firstName) || empty($this->lastName) || empty($this->gender) ||
            empty($this->birthDate) || empty($this->nationality) || empty($this->phone) || empty($this->residence) || empty($this->email)) {
            throw new Exception('Todos los campos son obligatorios.');
        }

        if (!filter_var($this->email, FILTER_VALIDATE_EMAIL)) {
            throw new Exception('El correo electrónico no es válido.');
        }
    }
}
?>