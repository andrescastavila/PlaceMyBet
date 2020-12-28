-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 10, 2019 at 05:10 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `placemybet`
--

-- --------------------------------------------------------

--
-- Table structure for table `apuestas`
--

CREATE TABLE `apuestas` (
  `id_mercado` int(11) NOT NULL,
  `tipo_apuesta` varchar(30) NOT NULL,
  `cuota` float NOT NULL,
  `ingreso` float NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_apuesta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `apuestas`
--

INSERT INTO `apuestas` (`id_mercado`, `tipo_apuesta`, `cuota`, `ingreso`, `id_usuario`, `id_apuesta`) VALUES
(1, 'Over', 2.5, 500, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `cuentas`
--

CREATE TABLE `cuentas` (
  `saldo` int(11) NOT NULL,
  `nombreBanco` varchar(30) NOT NULL,
  `numeroTarjeta` int(20) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `eventos`
--

CREATE TABLE `eventos` (
  `id_evento` int(11) NOT NULL,
  `equipo_local` varchar(30) NOT NULL,
  `equipo_visitante` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `eventos`
--

INSERT INTO `eventos` (`id_evento`, `equipo_local`, `equipo_visitante`) VALUES
(1, 'Valencia', 'Barcelona');

-- --------------------------------------------------------

--
-- Table structure for table `mercados`
--

CREATE TABLE `mercados` (
  `tipoMercado` float NOT NULL,
  `cuotaUnder` float NOT NULL,
  `cuotaOver` float NOT NULL,
  `apostadoUnder` float NOT NULL,
  `apostadoOver` float NOT NULL,
  `id_mercado` int(11) NOT NULL,
  `id_evento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `mercados`
--

INSERT INTO `mercados` (`tipoMercado`, `cuotaUnder`, `cuotaOver`, `apostadoUnder`, `apostadoOver`, `id_mercado`, `id_evento`) VALUES
(1.5, 2.5, 3, 200, 300, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `edad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nombre`, `apellido`, `email`, `edad`) VALUES
(1, 'Andres', 'Castaño Vilanova', 'andrescastano93@gmail.com', 21);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `apuestas`
--
ALTER TABLE `apuestas`
  ADD PRIMARY KEY (`id_apuesta`),
  ADD KEY `id_mercado` (`id_mercado`),
  ADD KEY `id_usuario` (`id_usuario`);

--
-- Indexes for table `cuentas`
--
ALTER TABLE `cuentas`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indexes for table `eventos`
--
ALTER TABLE `eventos`
  ADD PRIMARY KEY (`id_evento`);

--
-- Indexes for table `mercados`
--
ALTER TABLE `mercados`
  ADD PRIMARY KEY (`id_mercado`),
  ADD KEY `id_evento` (`id_evento`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `apuestas`
--
ALTER TABLE `apuestas`
  ADD CONSTRAINT `apuestas_ibfk_1` FOREIGN KEY (`id_mercado`) REFERENCES `mercados` (`id_mercado`),
  ADD CONSTRAINT `apuestas_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);

--
-- Constraints for table `cuentas`
--
ALTER TABLE `cuentas`
  ADD CONSTRAINT `cuentas_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`);

--
-- Constraints for table `mercados`
--
ALTER TABLE `mercados`
  ADD CONSTRAINT `mercados_ibfk_1` FOREIGN KEY (`id_evento`) REFERENCES `eventos` (`id_evento`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
