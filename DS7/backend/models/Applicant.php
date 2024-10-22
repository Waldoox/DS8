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

    /**
     * @return mixed
     */
    public function getIdCard()
    {
        return $this->idCard;
    }

    /**
     * @param mixed $idCard
     */
    public function setIdCard($idCard)
    {
        $this->idCard = $idCard;
    }

    /**
     * @return mixed
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param mixed $firstName
     */
    public function setFirstName($firstName)
    {
        $this->firstName = $firstName;
    }

    /**
     * @return mixed
     */
    public function getLastName()
    {
        return $this->lastName;
    }

    /**
     * @param mixed $lastName
     */
    public function setLastName($lastName)
    {
        $this->lastName = $lastName;
    }

    /**
     * @return mixed
     */
    public function getMaritalStatus()
    {
        return $this->maritalStatus;
    }

    /**
     * @param mixed $maritalStatus
     */
    public function setMaritalStatus($maritalStatus)
    {
        $this->maritalStatus = $maritalStatus;
    }

    /**
     * @return mixed
     */
    public function getGender()
    {
        return $this->gender;
    }

    /**
     * @param mixed $gender
     */
    public function setGender($gender)
    {
        $this->gender = $gender;
    }

    /**
     * @return mixed
     */
    public function getBloodType()
    {
        return $this->bloodType;
    }

    /**
     * @param mixed $bloodType
     */
    public function setBloodType($bloodType)
    {
        $this->bloodType = $bloodType;
    }

    /**
     * @return mixed
     */
    public function getBirthDate()
    {
        return $this->birthDate;
    }

    /**
     * @param mixed $birthDate
     */
    public function setBirthDate($birthDate)
    {
        $this->birthDate = $birthDate;
    }

    /**
     * @return mixed
     */
    public function getNationality()
    {
        return $this->nationality;
    }

    /**
     * @param mixed $nationality
     */
    public function setNationality($nationality)
    {
        $this->nationality = $nationality;
    }

    /**
     * @return mixed
     */
    public function getPhone()
    {
        return $this->phone;
    }

    /**
     * @param mixed $phone
     */
    public function setPhone($phone)
    {
        $this->phone = $phone;
    }

    /**
     * @return mixed
     */
    public function getResidence()
    {
        return $this->residence;
    }

    /**
     * @param mixed $residence
     */
    public function setResidence($residence)
    {
        $this->residence = $residence;
    }

    /**
     * @return mixed
     */
    public function getEmail()
    {
        return $this->email;
    }

    /**
     * @param mixed $email
     */
    public function setEmail($email)
    {
        $this->email = $email;
    }


}
?>