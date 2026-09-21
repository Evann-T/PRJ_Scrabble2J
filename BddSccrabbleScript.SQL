CREATE DATABASE IF NOT EXISTS BDD_SCRABBLE;
USE BDD_SCRABBLE;

CREATE TABLE IF NOT EXISTS partie (
    id INT AUTO_INCREMENT PRIMARY KEY,
    date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    nomJoueur1 VARCHAR(100) NOT NULL,
    nomJoueur2 VARCHAR(100) NOT NULL,
    scoreJoueur1 INT NOT NULL DEFAULT 0,
    scoreJoueur2 INT NOT NULL DEFAULT 0
);

INSERT INTO partie (nomJoueur1, scoreJoueur1, nomJoueur2, scoreJoueur2) VALUES
('Matt', 287, 'Bob', 241);

INSERT INTO partie (nomJoueur1, scoreJoueur1, nomJoueur2, scoreJoueur2) VALUES
('Jean', 60, 'Leo', 241);

INSERT INTO partie (nomJoueur1, scoreJoueur1, nomJoueur2, scoreJoueur2) VALUES
('Paul', 169, 'Timeo', 169);

SELECT date, nomJoueur1, scoreJoueur1, nomJoueur2, scoreJoueur2 FROM partie;
