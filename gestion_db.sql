-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 08 fév. 2025 à 18:48
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
-- Base de données : `gestion_db`
--

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `adresse` varchar(100) DEFAULT NULL,
  `telephone` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `date_naissance` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `dechets`
--

DROP TABLE IF EXISTS `dechets`;
CREATE TABLE IF NOT EXISTS `dechets` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom_dechet` varchar(100) NOT NULL,
  `type_dechet` varchar(50) DEFAULT NULL,
  `quantite` decimal(10,2) DEFAULT NULL,
  `unite_mesure` varchar(20) DEFAULT NULL,
  `date_collecte` date DEFAULT NULL,
  `lieu_collecte` varchar(100) DEFAULT NULL,
  `responsable` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `dechets`
--

INSERT INTO `dechets` (`id`, `nom_dechet`, `type_dechet`, `quantite`, `unite_mesure`, `date_collecte`, `lieu_collecte`, `responsable`) VALUES
(1, 'DECHETS DE POULETS', 'Organiques', 12.00, 'kg', '2025-02-07', 'TITI GARRAGE', 'CALIXTA ONG'),
(2, 'BOUTEILLE JAVEL', 'Plastiques', 1.00, 'KG ', '2025-02-07', 'SOA', 'NJEUNOU'),
(3, 'BOUTEILLE', 'Plastiques', 10.00, 'KG ', '2025-02-07', 'YAOUNDER', 'SAMIRA');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `reservation` varchar(50) NOT NULL,
  `mot_de_passe` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `nom`, `prenom`, `reservation`, `mot_de_passe`) VALUES
(1, 'fdghdjsds', 'fhgjkl', 'fghjk', 'fhgjkl'),
(2, 'BATOSINE', 'TCHOUHO', 'bouteille', 'admin'),
(3, 'samira', 'samora', 'aeeaz', 'pass'),
(4, 'dsfghjk', 'ertyhuijok', 'retyuiop', 'dfghjdfcvg,hjb'),
(5, 'qzer', 'erret', 'ertert', 'ezretyu'),
(6, 'sanama', 'kkoo', 'droit', 'fraisei'),
(7, 'qweqw', 'ewwe', 'wew', 'ewwe'),
(8, 'aerhjzkaeh', 'hjklzezhj', 'hjkzehj', 'jhkze'),
(9, 'zegrer', 'zdefrer', 'erer', 'rtrt'),
(10, 'zrer', 'ezrer', 're', 'ert'),
(11, 'OTTOU', 'SAMIRA', '12-124', 'SAMSAM'),
(12, 'HGJK', 'GHJK', 'HGJ', 'GH'),
(13, 'FYUJK', 'GHJ', 'GHJ', 'GHJK'),
(14, 'ftryhj', 'retyuryt', 'tryj', 'tryui'),
(15, 'etryu', 'tyu', 'tyui', 'tyui'),
(16, 'tryu', 'yui', 'yui', 'yu'),
(17, 'sd', 'try', 'ryt', 'ytu'),
(18, 'ezrtyu', 'tryu', 'tryui', 'rytui'),
(19, 'dfy', 'fytu', 'ytui', 'fg'),
(20, 'ojtdftfrdd', 'qzer', 'qaszder', 'zedr'),
(21, 'syuhj', 'sdfytu', 'ret', 'sytu'),
(22, 'poiuy', 'poihj', 'oiuh', 'poijh'),
(23, 'ERYTUI', 'TIU', 'FHGJ', 'FG'),
(24, 'NJEUNOU', 'ALAIN', 'YAOUNDE 04-01-25', 'ALLLL'),
(25, 'KJH', 'LKJHG', 'KJHG', 'JKH'),
(26, 'OUIUY', 'PO', 'IU', 'J;LKJ'),
(27, 'KJHG', 'LK', 'JH', 'KJH'),
(28, 'ALADJI', 'ADAMOU', 'ESSOS 02-01-24', 'DFGHJHGFD'),
(29, 'RTYU', 'YT', 'TYU', 'TYYU'),
(30, 'GFH', 'HGJ', 'HGJ', 'HJDFGHJ'),
(31, 'ertyui', 'ertyui', 'ertyui', 'retyuio'),
(32, 'ertyu', 'rety', 'retyu', 'retyui'),
(33, 'yug', 'tryui', 'ytu', 'ytugi'),
(34, 'retyui', 'tryuio', 'rtyuio', 'ytui');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
