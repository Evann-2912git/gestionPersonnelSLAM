-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 05 juin 2025 à 20:39
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `atelier2slam`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2025-02-14 16:46:40', '2025-02-24 20:02:55', 3),
(2, '2025-02-10 08:23:03', '2025-02-21 00:40:07', 1),
(3, '2025-02-09 16:32:24', '2025-02-17 07:18:21', 1),
(4, '2025-02-08 11:31:39', '2025-02-27 15:09:51', 1),
(5, '2025-02-11 06:36:54', '2025-02-18 20:40:30', 2),
(6, '2025-02-11 19:30:43', '2025-02-16 07:57:25', 1),
(7, '2025-02-11 00:29:52', '2025-02-17 14:51:24', 3),
(8, '2025-02-03 18:49:42', '2025-02-24 16:48:17', 3),
(9, '2025-02-03 03:28:47', '2025-02-23 06:55:06', 2),
(10, '2025-02-09 14:13:19', '2025-02-26 18:25:04', 1),
(11, '2025-02-08 15:49:21', '2025-02-22 01:38:26', 3),
(12, '2025-02-05 22:33:49', '2025-02-25 07:09:27', 1),
(13, '2025-02-06 10:37:25', '2025-02-18 10:56:21', 2),
(14, '2025-02-05 08:34:22', '2025-02-19 17:43:50', 1),
(15, '2025-02-13 06:34:42', '2025-02-27 22:02:07', 2),
(16, '2025-02-09 18:57:13', '2025-02-20 07:07:12', 1),
(17, '2025-02-10 07:44:52', '2025-02-26 15:04:06', 1),
(18, '2025-02-14 22:02:35', '2025-02-23 22:22:27', 1),
(19, '2025-02-09 03:23:54', '2025-02-24 15:28:24', 2),
(20, '2025-02-05 11:11:25', '2025-02-16 03:07:29', 4),
(21, '2025-02-13 20:53:38', '2025-02-19 20:28:25', 3),
(22, '2025-02-04 04:32:55', '2025-02-21 03:29:01', 3),
(23, '2025-02-08 03:30:09', '2025-02-27 02:37:54', 2),
(24, '2025-02-09 15:29:51', '2025-02-22 13:29:48', 2),
(25, '2025-02-12 15:21:47', '2025-02-21 21:47:46', 3),
(26, '2025-02-06 18:42:27', '2025-02-21 19:33:36', 3),
(27, '2025-02-08 13:10:56', '2025-02-22 11:33:36', 2),
(28, '2025-02-11 22:28:06', '2025-02-25 17:53:11', 4),
(29, '2025-02-14 12:34:26', '2025-02-20 17:44:34', 2),
(30, '2025-02-08 23:21:24', '2025-02-26 00:57:56', 4),
(31, '2025-02-12 13:44:58', '2025-02-28 09:47:43', 3),
(32, '2025-02-05 11:05:29', '2025-02-28 01:44:35', 3),
(33, '2025-02-09 04:47:28', '2025-02-15 20:44:27', 3),
(34, '2025-02-02 19:46:02', '2025-02-28 12:05:40', 3),
(35, '2025-02-09 21:46:48', '2025-02-25 20:40:04', 3),
(36, '2025-02-14 02:13:58', '2025-02-17 13:04:45', 3),
(37, '2025-02-10 04:40:40', '2025-02-17 20:36:44', 3),
(38, '2025-02-14 05:52:29', '2025-02-27 03:47:36', 3),
(39, '2025-02-04 05:04:11', '2025-02-27 12:48:23', 2),
(40, '2025-02-02 02:40:00', '2025-02-24 10:33:18', 1),
(41, '2025-02-10 12:53:04', '2025-02-24 23:15:14', 3),
(42, '2025-02-02 10:16:01', '2025-02-22 16:38:29', 3),
(43, '2025-02-10 16:34:51', '2025-02-19 17:24:24', 3),
(44, '2025-02-07 07:00:11', '2025-02-26 09:44:46', 3),
(45, '2025-02-05 20:38:23', '2025-02-20 19:58:05', 2),
(46, '2025-02-14 16:15:14', '2025-02-22 06:10:51', 2),
(47, '2025-02-09 10:08:20', '2025-02-26 18:45:06', 2),
(48, '2025-02-11 03:56:15', '2025-02-17 15:09:57', 3),
(49, '2025-02-02 12:50:04', '2025-02-28 10:33:54', 2),
(50, '2025-02-14 18:40:21', '2025-02-28 04:23:12', 3),
(0, '2025-06-06 21:53:39', '2025-06-27 21:53:39', 1),
(0, '2025-06-04 21:54:03', '2025-06-05 21:54:03', 1),
(0, '2025-06-05 22:37:18', '2025-06-25 22:37:17', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(10, 'Graham', 'McKenzie', '07 11 75 17 11', 'sem@yahoo.edu', 1),
(14, 'Fitzpatrick', 'Stephanie', '06 16 14 96 08', 'arcu.vestibulum@hotmail.edu', 3),
(8, 'Koch', 'Summer', '03 77 22 75 48', 'erat@icloud.org', 1),
(6, 'Reilly', 'Ruby', '05 49 13 85 66', 'rutrum.fusce@outlook.ca', 1),
(12, 'Shepard', 'Dacey', '07 56 11 53 51', 'sed.pede.nec@protonmail.org', 2),
(2, 'Clark', 'Xenos', '02 91 82 77 52', 'et.ultrices.posuere@icloud.net', 3),
(11, 'Todd', 'Sonya', '06 46 63 48 76', 'neque.morbi@protonmail.couk', 1),
(4, 'Walton', 'Sydnee', '03 17 21 63 17', 'lobortis.ultrices@protonmail.ca', 2),
(9, 'Pickett', 'Aquila', '09 66 34 14 65', 'nunc@aol.edu', 3),
(3, 'Lang', 'Maile', '03 89 29 13 23', 'duis.sit@hotmail.com', 2),
(7, 'Fischer', 'Oscar', '07 79 46 54 88', 'mauris.ut.mi@aol.net', 1),
(5, 'Salinas', 'Jonas', '04 76 76 24 21', 'elit.sed@hotmail.couk', 3),
(15, 'Anderson', 'Kyle', '06 63 06 62 14', 'nam.tempor@outlook.edu', 1),
(13, 'Henry', 'Flynn', '07 61 18 05 10', 'egestas@aol.net', 2),
(1, 'Soto', 'Aline', '01 59 65 51 67', 'sed.facilisis.vitae@hotmail.ca', 1),
(30, 'Shepard', 'Dacey', '07 56 11 53 59', 'sed.pede.nec@protonmail.org', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) DEFAULT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('mec12', '7c7390a8526be61496e25ada63441727b9628d9a027f290a32d78bc2bf440304');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
