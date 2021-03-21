

CREATE DATABASE IF NOT EXISTS Realty;

DROP TABLE IF EXISTS `Realty`.`contacts`;

CREATE TABLE IF NOT EXISTS `Realty`.`contacts`(
    `id` INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    `name` varchar(30) NOT NULL,
    `email` varchar(30) NOT NULL,
    `phone_number` varchar(30) NOT NULL,
    `message` text,
    `reg_date` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);