<?php

require_once __DIR__.'/../models/Applicant.php';
require_once __DIR__. '/../db/database.php';

class ApplicantService {
    private $db;

    public function __construct($dbConnection) {
        $this->db = $dbConnection;
    }

    public function createApplicant(Applicant $applicant, $userId) {
        try {
            $stmt = $this->db->prepare("INSERT INTO applicants (user_id, idCard, firstName, lastName, maritalStatus, gender, bloodType, birthDate, nationality, phone, residence, email) 
                                          VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
            $stmt->execute([
                $userId,
                $applicant->getIdCard(),
                $applicant->getFirstName(),
                $applicant->getLastName(),
                $applicant->getMaritalStatus(),
                $applicant->getGender(),
                $applicant->getBloodType(),
                $applicant->getBirthDate(),
                $applicant->getNationality(),
                $applicant->getPhone(),
                $applicant->getResidence(),
                $applicant->getEmail()
            ]);

            return ['success' => true, 'message' => 'Solicitante creado exitosamente.'];
        } catch (Exception $e) {
            return ['success' => false, 'message' => $e->getMessage()];
        }
    }

    public function applicantExists($userId) {
        $stmt = $this->db->prepare('SELECT COUNT(*) FROM applicants WHERE user_id = ?');
        $stmt->execute([$userId]);
        return $stmt->fetchColumn() > 0; // Retorna true si existe, false si no
    }
}
?>