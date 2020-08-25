-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-08-2020 a las 02:42:11
-- Versión del servidor: 10.4.13-MariaDB
-- Versión de PHP: 7.2.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mycompany`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administrador`
--

CREATE TABLE `administrador` (
  `ID_Administrador` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Nombre_Usuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `administrador`
--

INSERT INTO `administrador` (`ID_Administrador`, `Nombre`, `Apellido`, `Nombre_Usuario`, `Contraseña`) VALUES
(1, 'Pedro', 'Díaz', 'Pedro123', '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especialidad`
--

CREATE TABLE `especialidad` (
  `ID_Especialidad` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `especialidad`
--

INSERT INTO `especialidad` (`ID_Especialidad`, `Nombre`) VALUES
(1, 'Dermatologo'),
(2, 'Cardiología'),
(3, 'Gastroenterología'),
(4, 'Hermatología'),
(5, 'Endocrinología');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medicos`
--

CREATE TABLE `medicos` (
  `ID_Medicos` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Nombre_Usuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `Especialidad` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pacientes`
--

CREATE TABLE `pacientes` (
  `ID_Paciente` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Nombre_Usuario` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pacientes`
--

INSERT INTO `pacientes` (`ID_Paciente`, `Nombre`, `Apellido`, `Nombre_Usuario`, `Contraseña`, `Email`) VALUES
(5, 'Sebastian', 'Rodriguez', 'Seba45', '1234', 'seba@gmail.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologias`
--

CREATE TABLE `patologias` (
  `ID_Patologia` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `patologias`
--

INSERT INTO `patologias` (`ID_Patologia`, `Nombre`) VALUES
(1, 'Gripe o Resfriado'),
(2, 'Anemia'),
(3, 'Ansiedad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologiassintomas`
--

CREATE TABLE `patologiassintomas` (
  `ID_Conjunto` int(5) NOT NULL,
  `Nombre_Patologia` varchar(50) DEFAULT NULL,
  `Nombre_Sintoma` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `patologiassintomas`
--

INSERT INTO `patologiassintomas` (`ID_Conjunto`, `Nombre_Patologia`, `Nombre_Sintoma`) VALUES
(1, 'Tos', NULL),
(2, 'Covid-19', NULL),
(3, 'Sindrome de la Hipersensibilidad de la tos', NULL),
(4, 'Diarrea por Antibioticos', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sintomas`
--

CREATE TABLE `sintomas` (
  `ID_Sintomas` int(5) NOT NULL,
  `Nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `sintomas`
--

INSERT INTO `sintomas` (`ID_Sintomas`, `Nombre`) VALUES
(4, 'Dolor de Garganta'),
(3, 'Fiebre'),
(2, 'Gripe'),
(1, 'Tos');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `administrador`
--
ALTER TABLE `administrador`
  ADD PRIMARY KEY (`ID_Administrador`);

--
-- Indices de la tabla `especialidad`
--
ALTER TABLE `especialidad`
  ADD PRIMARY KEY (`ID_Especialidad`);

--
-- Indices de la tabla `medicos`
--
ALTER TABLE `medicos`
  ADD PRIMARY KEY (`ID_Medicos`);

--
-- Indices de la tabla `pacientes`
--
ALTER TABLE `pacientes`
  ADD PRIMARY KEY (`ID_Paciente`);

--
-- Indices de la tabla `patologias`
--
ALTER TABLE `patologias`
  ADD PRIMARY KEY (`ID_Patologia`);

--
-- Indices de la tabla `patologiassintomas`
--
ALTER TABLE `patologiassintomas`
  ADD PRIMARY KEY (`ID_Conjunto`);

--
-- Indices de la tabla `sintomas`
--
ALTER TABLE `sintomas`
  ADD PRIMARY KEY (`ID_Sintomas`),
  ADD UNIQUE KEY `Nombre` (`Nombre`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `administrador`
--
ALTER TABLE `administrador`
  MODIFY `ID_Administrador` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `especialidad`
--
ALTER TABLE `especialidad`
  MODIFY `ID_Especialidad` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `medicos`
--
ALTER TABLE `medicos`
  MODIFY `ID_Medicos` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `pacientes`
--
ALTER TABLE `pacientes`
  MODIFY `ID_Paciente` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `patologias`
--
ALTER TABLE `patologias`
  MODIFY `ID_Patologia` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `patologiassintomas`
--
ALTER TABLE `patologiassintomas`
  MODIFY `ID_Conjunto` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `sintomas`
--
ALTER TABLE `sintomas`
  MODIFY `ID_Sintomas` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
