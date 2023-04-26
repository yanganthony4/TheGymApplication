-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.11.2-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table thegymdb.bookings
CREATE TABLE IF NOT EXISTS `bookings` (
  `booking_id` int(11) NOT NULL,
  `trainer_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `booking_time` varchar(50) NOT NULL DEFAULT '',
  `booking_description` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`booking_id`),
  KEY `FK_Bookings_Trainers` (`trainer_id`),
  KEY `FK_Bookings_Customers` (`customer_id`),
  CONSTRAINT `FK_Bookings_Customers` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`id`),
  CONSTRAINT `FK_Bookings_Trainers` FOREIGN KEY (`trainer_id`) REFERENCES `trainers` (`trainer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

-- Dumping data for table thegymdb.bookings: ~1 rows (approximately)
/*!40000 ALTER TABLE `bookings` DISABLE KEYS */;
/*!40000 ALTER TABLE `bookings` ENABLE KEYS */;

-- Dumping structure for table thegymdb.customers
CREATE TABLE IF NOT EXISTS `customers` (
  `id` int(11) NOT NULL,
  `f_name` varchar(50) NOT NULL,
  `l_name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `number_of_visits` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

-- Dumping data for table thegymdb.customers: ~4 rows (approximately)
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` (`id`, `f_name`, `l_name`, `email`, `password`, `number_of_visits`) VALUES
	(1, 'Joe', 'Blow', 'joeblow@gmail.com', '123456', 15),
	(2, 'Jimmy', 'Pants', 'jpants@gmail.com', '123123', 2),
	(3, 'Jimin', 'Korean', 'ilovebts@gmail.com', 'btsbts', 6900),
	(4, 'Snoop', 'Dog', 'weedeveryday@gmail.com', 'weed', 420);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;

-- Dumping structure for table thegymdb.trainers
CREATE TABLE IF NOT EXISTS `trainers` (
  `trainer_id` int(11) NOT NULL,
  `trainer_f_name` varchar(50) NOT NULL,
  `trainer_l_name` varchar(50) NOT NULL,
  `specialty` varchar(50) NOT NULL,
  PRIMARY KEY (`trainer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;

-- Dumping data for table thegymdb.trainers: ~4 rows (approximately)
/*!40000 ALTER TABLE `trainers` DISABLE KEYS */;
INSERT INTO `trainers` (`trainer_id`, `trainer_f_name`, `trainer_l_name`, `specialty`) VALUES
	(1, 'Keith', 'John', 'Trainer'),
	(2, 'Barry', 'Owens', 'Trainer'),
	(3, 'Reese', 'Penny', 'Trainer / Masseur'),
	(4, 'Chad', 'Bulwark', 'Trainer / Masseur');
/*!40000 ALTER TABLE `trainers` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
