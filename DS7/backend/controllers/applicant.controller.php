<?php
session_start();

require_once  '../models/Applicant.php';
require_once '../db/database.php';
require_once '../services/applicant.service.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $userId = $_SESSION['user_id'];


    $idCard = trim($_POST['idCard']);
    $firstName = trim($_POST['firstName']);
    $lastName = trim($_POST['lastName']);
    $maritalStatus = trim($_POST['maritalStatus']);
    $gender = trim($_POST['gender']);
    $bloodType = trim($_POST['bloodType']);
    $birthDate = trim($_POST['birthDate']);
    $nationality = trim($_POST['nationality']);
    $phone = trim($_POST['phone']);
    $residence = trim($_POST['residence']);
    $email = trim($_POST['email']);

    try {
        $applicant = new Applicant($idCard, $firstName, $lastName, $maritalStatus, $gender, $bloodType, $birthDate, $nationality, $phone, $residence, $email);

        $database = new Database();
        $dbConnection = $database->connect();
        $applicantService = new ApplicantService($dbConnection);


        $result = $applicantService->createApplicant($applicant, $userId);

        $_SESSION['message'] = $result['message'];
        header('Location: ../../frontend/applying.php');
        exit();
    } catch (Exception $e) {
        $_SESSION['message'] = $e->getMessage();
        header('Location: ../../frontend/register.php'); // Redirige a la página de registro
        exit();
    }
} else {
    echo json_encode(['success' => false, 'message' => 'Método no permitido.']);
}
?>