-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2019 at 09:29 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `echargerinternational`
--

-- --------------------------------------------------------

--
-- Table structure for table `aikstele`
--

CREATE TABLE `aikstele` (
  `pavadinimas` varchar(255) NOT NULL,
  `telefono_numeris` varchar(255) NOT NULL,
  `darbo_pradzia` time NOT NULL,
  `darbo_pabaiga` time NOT NULL,
  `saugoma` tinyint(1) NOT NULL,
  `elektros_kaina` decimal(10,0) NOT NULL,
  `papildomas_mokestis` decimal(10,0) NOT NULL,
  `papildomo_mokescio_aprasymas` varchar(255) NOT NULL,
  `miestas` varchar(255) NOT NULL,
  `gatve` varchar(255) NOT NULL,
  `namoNr` int(11) NOT NULL,
  `koordinateX` decimal(10,0) NOT NULL,
  `koordinateY` decimal(10,0) NOT NULL,
  `pasto_kodas` varchar(255) NOT NULL,
  `aprasymas` varchar(255) NOT NULL,
  `id_Aikstele` int(11) NOT NULL,
  `fk_Klientasid_Klientas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aikstele`
--

INSERT INTO `aikstele` (`pavadinimas`, `telefono_numeris`, `darbo_pradzia`, `darbo_pabaiga`, `saugoma`, `elektros_kaina`, `papildomas_mokestis`, `papildomo_mokescio_aprasymas`, `miestas`, `gatve`, `namoNr`, `koordinateX`, `koordinateY`, `pasto_kodas`, `aprasymas`, `id_Aikstele`, `fk_Klientasid_Klientas`) VALUES
('Elektro-1234', '86324432342', '08:00:00', '20:00:00', 0, '123', '0', '-', 'Kaunas', 'Kauno g.', 5, '3143', '31413', 'LT-12345', '-', 0, 1),
('nauja', 'qwe', '05:50:00', '05:50:00', 3, '5', '5', 'weqeqw', 'qwe', 'we', 2, '6', '6', '6', '6', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(767) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(767) NOT NULL,
  `ClaimType` text,
  `ClaimValue` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` text,
  `UserId` varchar(767) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(767) NOT NULL,
  `RoleId` varchar(767) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(767) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` text,
  `SecurityStamp` text,
  `ConcurrencyStamp` text,
  `PhoneNumber` text,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` timestamp NULL DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(767) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `atsiliepimas`
--

CREATE TABLE `atsiliepimas` (
  `aprasymas` varchar(255) NOT NULL,
  `data` datetime NOT NULL,
  `id_Atsiliepimas` int(11) NOT NULL,
  `fk_Klientasid_Klientas` int(11) NOT NULL,
  `fk_Aiksteleid_Aikstele` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `atsiliepimas`
--

INSERT INTO `atsiliepimas` (`aprasymas`, `data`, `id_Atsiliepimas`, `fk_Klientasid_Klientas`, `fk_Aiksteleid_Aikstele`) VALUES
('asd', '0001-01-01 00:00:00', 0, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `kalba`
--

CREATE TABLE `kalba` (
  `kalba` int(11) NOT NULL,
  `id_Kalba` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kalbos`
--

CREATE TABLE `kalbos` (
  `id_Kalbos` int(11) NOT NULL DEFAULT '0',
  `name` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kalbos`
--

INSERT INTO `kalbos` (`id_Kalbos`, `name`) VALUES
(1, 'Lietuvių'),
(2, 'Anglų'),
(3, 'Rusų'),
(4, 'Vokiečių'),
(5, 'Prancūzų'),
(6, 'Ispanų'),
(7, 'Italų'),
(8, 'Lenkų');

-- --------------------------------------------------------

--
-- Table structure for table `klientas`
--

CREATE TABLE `klientas` (
  `vardas` varchar(255) NOT NULL,
  `pavarde` varchar(255) NOT NULL,
  `gimimo_data` date NOT NULL,
  `telefonas` varchar(255) NOT NULL,
  `epastas` varchar(255) NOT NULL,
  `asmens_kodas` varchar(255) NOT NULL,
  `role` varchar(255) DEFAULT NULL,
  `busena` tinyint(1) NOT NULL,
  `slaptazodis` varchar(255) NOT NULL,
  `aprasymas` varchar(255) NOT NULL,
  `id_Klientas` int(11) NOT NULL,
  `fk_Roleid_Role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `klientas`
--

INSERT INTO `klientas` (`vardas`, `pavarde`, `gimimo_data`, `telefonas`, `epastas`, `asmens_kodas`, `role`, `busena`, `slaptazodis`, `aprasymas`, `id_Klientas`, `fk_Roleid_Role`) VALUES
('Jonas', 'Jonaitis', '1999-12-02', '864354343', 'Jonas@ktu.lt', '396789876342324', NULL, 0, 'Jonas123', '-', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `klientokalbos`
--

CREATE TABLE `klientokalbos` (
  `fk_Kalbaid_Kalba` int(11) NOT NULL,
  `fk_Klientasid_Klientas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `remejai`
--

CREATE TABLE `remejai` (
  `pavadinimas` varchar(255) NOT NULL,
  `skirtos_lesos` decimal(10,0) NOT NULL,
  `data` datetime NOT NULL,
  `salis` varchar(255) NOT NULL,
  `aprasymas` varchar(255) NOT NULL,
  `id_Remėjai` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `rezervacija`
--

CREATE TABLE `rezervacija` (
  `pradzia` datetime NOT NULL,
  `pabaiga` datetime NOT NULL,
  `sutarties_data` datetime NOT NULL,
  `numeris` int(11) NOT NULL,
  `pranesimas` varchar(255) NOT NULL,
  `busena` int(11) NOT NULL,
  `id_Rezervacija` int(11) NOT NULL,
  `fk_Klientasid_Siuntejas` int(11) NOT NULL,
  `fk_Klientasid_Gavejas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `rezervacijos_busena`
--

CREATE TABLE `rezervacijos_busena` (
  `id_Rezervacijos_busena` int(11) NOT NULL DEFAULT '0',
  `name` char(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `rezervacijos_busena`
--

INSERT INTO `rezervacijos_busena` (`id_Rezervacijos_busena`, `name`) VALUES
(1, 'uzbaigta'),
(2, 'nutraukta'),
(3, 'vyksta');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `pavadinimas` varchar(255) NOT NULL,
  `naudojama` tinyint(1) NOT NULL,
  `id_Role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`pavadinimas`, `naudojama`, `id_Role`) VALUES
('Klientas', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `skundas`
--

CREATE TABLE `skundas` (
  `aprasymas` varchar(255) NOT NULL,
  `data` datetime NOT NULL,
  `busena` int(11) NOT NULL,
  `id_Skundas` int(11) NOT NULL,
  `fk_Klientasid_Klientas` int(11) NOT NULL,
  `fk_Klientasid_Klientas1` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `skundo_busena`
--

CREATE TABLE `skundo_busena` (
  `id_Skundo_busena` int(11) NOT NULL DEFAULT '0',
  `name` char(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `skundo_busena`
--

INSERT INTO `skundo_busena` (`id_Skundo_busena`, `name`) VALUES
(1, 'priimta'),
(2, 'atmesta');

-- --------------------------------------------------------

--
-- Table structure for table `stotele`
--

CREATE TABLE `stotele` (
  `galia` int(11) NOT NULL,
  `numeris` int(11) NOT NULL,
  `valandinis_mokestis` decimal(10,0) NOT NULL,
  `aprasymas` varchar(255) NOT NULL,
  `id_Stotele` int(11) NOT NULL,
  `fk_Aiksteleid_Aikstele` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `vertinimas`
--

CREATE TABLE `vertinimas` (
  `reitingas` double NOT NULL,
  `data` datetime NOT NULL,
  `id_Vertinimas` int(11) NOT NULL,
  `fk_Aiksteleid_Aikstele` int(11) NOT NULL,
  `fk_Klientasid_Klientas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20191204074509_AddIdentity', '2.1.11-servicing-32099');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aikstele`
--
ALTER TABLE `aikstele`
  ADD PRIMARY KEY (`id_Aikstele`),
  ADD KEY `Administruoja` (`fk_Klientasid_Klientas`);

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `atsiliepimas`
--
ALTER TABLE `atsiliepimas`
  ADD PRIMARY KEY (`id_Atsiliepimas`),
  ADD KEY `Palieka` (`fk_Klientasid_Klientas`),
  ADD KEY `Apibūdina` (`fk_Aiksteleid_Aikstele`);

--
-- Indexes for table `kalba`
--
ALTER TABLE `kalba`
  ADD PRIMARY KEY (`id_Kalba`),
  ADD KEY `kalba` (`kalba`);

--
-- Indexes for table `kalbos`
--
ALTER TABLE `kalbos`
  ADD PRIMARY KEY (`id_Kalbos`);

--
-- Indexes for table `klientas`
--
ALTER TABLE `klientas`
  ADD PRIMARY KEY (`id_Klientas`),
  ADD KEY `Priklauso` (`fk_Roleid_Role`);

--
-- Indexes for table `klientokalbos`
--
ALTER TABLE `klientokalbos`
  ADD PRIMARY KEY (`fk_Kalbaid_Kalba`,`fk_Klientasid_Klientas`);

--
-- Indexes for table `remejai`
--
ALTER TABLE `remejai`
  ADD PRIMARY KEY (`id_Remėjai`);

--
-- Indexes for table `rezervacija`
--
ALTER TABLE `rezervacija`
  ADD PRIMARY KEY (`id_Rezervacija`),
  ADD KEY `busena` (`busena`),
  ADD KEY `Pateikta` (`fk_Klientasid_Siuntejas`),
  ADD KEY `Pateikia` (`fk_Klientasid_Gavejas`);

--
-- Indexes for table `rezervacijos_busena`
--
ALTER TABLE `rezervacijos_busena`
  ADD PRIMARY KEY (`id_Rezervacijos_busena`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id_Role`);

--
-- Indexes for table `skundas`
--
ALTER TABLE `skundas`
  ADD PRIMARY KEY (`id_Skundas`),
  ADD KEY `busena` (`busena`),
  ADD KEY `Apie` (`fk_Klientasid_Klientas`),
  ADD KEY `Sukuria` (`fk_Klientasid_Klientas1`);

--
-- Indexes for table `skundo_busena`
--
ALTER TABLE `skundo_busena`
  ADD PRIMARY KEY (`id_Skundo_busena`);

--
-- Indexes for table `stotele`
--
ALTER TABLE `stotele`
  ADD PRIMARY KEY (`id_Stotele`),
  ADD KEY `Turi` (`fk_Aiksteleid_Aikstele`);

--
-- Indexes for table `vertinimas`
--
ALTER TABLE `vertinimas`
  ADD PRIMARY KEY (`id_Vertinimas`),
  ADD UNIQUE KEY `fk_Klientasid_Klientas` (`fk_Klientasid_Klientas`),
  ADD KEY `Skirtas` (`fk_Aiksteleid_Aikstele`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aikstele`
--
ALTER TABLE `aikstele`
  ADD CONSTRAINT `Administruoja` FOREIGN KEY (`fk_Klientasid_Klientas`) REFERENCES `klientas` (`id_Klientas`);

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `atsiliepimas`
--
ALTER TABLE `atsiliepimas`
  ADD CONSTRAINT `Apibūdina` FOREIGN KEY (`fk_Aiksteleid_Aikstele`) REFERENCES `aikstele` (`id_Aikstele`),
  ADD CONSTRAINT `Palieka` FOREIGN KEY (`fk_Klientasid_Klientas`) REFERENCES `klientas` (`id_Klientas`);

--
-- Constraints for table `kalba`
--
ALTER TABLE `kalba`
  ADD CONSTRAINT `Kalba_ibfk_1` FOREIGN KEY (`kalba`) REFERENCES `kalbos` (`id_Kalbos`);

--
-- Constraints for table `klientas`
--
ALTER TABLE `klientas`
  ADD CONSTRAINT `Priklauso` FOREIGN KEY (`fk_Roleid_Role`) REFERENCES `role` (`id_Role`);

--
-- Constraints for table `klientokalbos`
--
ALTER TABLE `klientokalbos`
  ADD CONSTRAINT `Kalba` FOREIGN KEY (`fk_Kalbaid_Kalba`) REFERENCES `kalba` (`id_Kalba`);

--
-- Constraints for table `rezervacija`
--
ALTER TABLE `rezervacija`
  ADD CONSTRAINT `Pateikia` FOREIGN KEY (`fk_Klientasid_Gavejas`) REFERENCES `klientas` (`id_Klientas`),
  ADD CONSTRAINT `Pateikta` FOREIGN KEY (`fk_Klientasid_Siuntejas`) REFERENCES `klientas` (`id_Klientas`),
  ADD CONSTRAINT `Rezervacija_ibfk_1` FOREIGN KEY (`busena`) REFERENCES `rezervacijos_busena` (`id_Rezervacijos_busena`);

--
-- Constraints for table `skundas`
--
ALTER TABLE `skundas`
  ADD CONSTRAINT `Apie` FOREIGN KEY (`fk_Klientasid_Klientas`) REFERENCES `klientas` (`id_Klientas`),
  ADD CONSTRAINT `Skundas_ibfk_1` FOREIGN KEY (`busena`) REFERENCES `skundo_busena` (`id_Skundo_busena`),
  ADD CONSTRAINT `Sukuria` FOREIGN KEY (`fk_Klientasid_Klientas1`) REFERENCES `klientas` (`id_Klientas`);

--
-- Constraints for table `stotele`
--
ALTER TABLE `stotele`
  ADD CONSTRAINT `Turi` FOREIGN KEY (`fk_Aiksteleid_Aikstele`) REFERENCES `aikstele` (`id_Aikstele`);

--
-- Constraints for table `vertinimas`
--
ALTER TABLE `vertinimas`
  ADD CONSTRAINT `Kuria` FOREIGN KEY (`fk_Klientasid_Klientas`) REFERENCES `klientas` (`id_Klientas`),
  ADD CONSTRAINT `Skirtas` FOREIGN KEY (`fk_Aiksteleid_Aikstele`) REFERENCES `aikstele` (`id_Aikstele`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
