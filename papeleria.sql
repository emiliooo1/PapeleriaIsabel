-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 17, 2026 at 02:08 AM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `papeleria`
--

-- --------------------------------------------------------

--
-- Table structure for table `detalle_ventas`
--

CREATE TABLE `detalle_ventas` (
  `idDetalle` int(11) NOT NULL,
  `idVenta` int(11) NOT NULL,
  `idProd` int(11) NOT NULL,
  `precioUnitario` decimal(10,2) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `detalle_ventas`
--

INSERT INTO `detalle_ventas` (`idDetalle`, `idVenta`, `idProd`, `precioUnitario`, `cantidad`, `subtotal`) VALUES
(1, 3, 121, '10.00', 2, '20.00'),
(2, 7, 121, '10.00', 2, '20.00'),
(3, 11, 121, '10.00', 1, '10.00'),
(4, 12, 121, '10.00', 2, '20.00'),
(5, 13, 121, '10.00', 2, '20.00'),
(6, 14, 121, '10.00', 1, '10.00'),
(7, 14, 12312312, '10.00', 1, '10.00'),
(8, 14, 1213123122, '10.00', 1, '10.00'),
(9, 15, 12312312, '10.00', 1, '10.00'),
(10, 15, 121, '10.00', 1, '10.00'),
(11, 16, 19192011, '5.00', 2, '10.00'),
(12, 17, 2147483647, '15.00', 1, '15.00'),
(13, 18, 121312312, '10.00', 2, '20.00'),
(14, 19, 121, '10.00', 4, '40.00'),
(15, 20, 121, '10.00', 2, '20.00'),
(16, 21, 121, '10.00', 2, '20.00'),
(17, 22, 121, '10.00', 1, '10.00');

-- --------------------------------------------------------

--
-- Table structure for table `inventario`
--

CREATE TABLE `inventario` (
  `idInv` int(11) NOT NULL,
  `idProd` int(11) NOT NULL,
  `stock` int(11) NOT NULL
) ;

--
-- Dumping data for table `inventario`
--

INSERT INTO `inventario` (`idInv`, `idProd`, `stock`) VALUES
(1, 121, 5),
(2, 121312312, 0),
(4, 1213123122, 1),
(5, 12312312, 1),
(6, 19192011, 1),
(7, 2147483647, 0);

-- --------------------------------------------------------

--
-- Table structure for table `productos`
--

CREATE TABLE `productos` (
  `idProd` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(80) DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `idProv` int(11) NOT NULL
) ;

--
-- Dumping data for table `productos`
--

INSERT INTO `productos` (`idProd`, `nombre`, `descripcion`, `precio`, `idProv`) VALUES
(121, 'Lapiz', 'efsdfs', '10.00', 2147483647),
(12312312, 'borradorsin', '', '10.00', 2147483647),
(19192011, 'Lapicito', '', '5.00', 2147483647),
(121312312, 'Lapizin', '', '10.00', 2147483647),
(1213123122, 'Borrador', '', '10.00', 2147483647),
(2147483647, 'Pluma', '', '15.00', 2147483647);

-- --------------------------------------------------------

--
-- Table structure for table `proveedores`
--

CREATE TABLE `proveedores` (
  `idProv` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `proveedores`
--

INSERT INTO `proveedores` (`idProv`, `nombre`, `correo`, `telefono`) VALUES
(214748378, 'Emilio12', 'emiliorenovato11@gmail.com', '8771149897'),
(2147483647, 'Emilio1', 'emiliorenovato11@gmail.com', '8771149897');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(30) NOT NULL,
  `tipo` varchar(20) DEFAULT NULL,
  `ultimo_login` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`idUsuario`, `usuario`, `contrasena`, `tipo`, `ultimo_login`) VALUES
(1, 'admin', '1234', 'Administrador', '2026-04-16 20:52:02'),
(3, 'Emilio', '1234', 'Vendedor', '2026-04-16 21:00:38');

-- --------------------------------------------------------

--
-- Table structure for table `ventas`
--

CREATE TABLE `ventas` (
  `idVenta` int(11) NOT NULL,
  `fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `total` decimal(10,2) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `estado` varchar(20) DEFAULT 'Activa'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `ventas`
--

INSERT INTO `ventas` (`idVenta`, `fecha`, `total`, `idUsuario`, `estado`) VALUES
(1, '2026-04-08 00:45:46', '0.00', 1, 'Activa'),
(2, '2026-04-08 00:45:48', '0.00', 1, 'Activa'),
(3, '2026-04-09 00:45:18', '20.00', 1, 'Activa'),
(4, '2026-04-09 00:45:22', '20.00', 1, 'Activa'),
(5, '2026-04-09 00:45:27', '20.00', 1, 'Activa'),
(6, '2026-04-09 00:45:30', '20.00', 1, 'Activa'),
(7, '2026-04-09 00:45:45', '20.00', 1, 'Activa'),
(8, '2026-04-09 00:45:50', '20.00', 1, 'Activa'),
(9, '2026-04-09 00:46:00', '20.00', 1, 'Activa'),
(10, '2026-04-09 00:46:50', '20.00', 1, 'Activa'),
(11, '2026-04-09 00:50:43', '10.00', 1, 'Activa'),
(12, '2026-04-09 00:50:54', '20.00', 1, 'Activa'),
(13, '2026-04-13 07:30:07', '20.00', 1, 'Activa'),
(14, '2026-04-13 09:50:16', '30.00', 1, 'Cancelada'),
(15, '2026-04-13 10:03:02', '20.00', 1, 'Activa'),
(16, '2026-04-13 10:12:57', '10.00', 1, 'Activa'),
(17, '2026-04-13 23:15:33', '15.00', 1, 'Activa'),
(18, '2026-04-15 21:18:18', '20.00', 1, 'Activa'),
(19, '2026-04-15 23:11:38', '40.00', 1, 'Activa'),
(20, '2026-04-15 23:12:49', '20.00', 1, 'Activa'),
(21, '2026-04-16 20:28:10', '20.00', 1, 'Activa'),
(22, '2026-04-16 20:33:57', '10.00', 1, 'Activa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detalle_ventas`
--
ALTER TABLE `detalle_ventas`
  ADD PRIMARY KEY (`idDetalle`),
  ADD KEY `idVenta` (`idVenta`),
  ADD KEY `idProd` (`idProd`);

--
-- Indexes for table `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`idInv`),
  ADD UNIQUE KEY `idProd` (`idProd`);

--
-- Indexes for table `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`idProd`),
  ADD KEY `idProv` (`idProv`);

--
-- Indexes for table `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`idProv`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idUsuario`);

--
-- Indexes for table `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`idVenta`),
  ADD KEY `idUsuario` (`idUsuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detalle_ventas`
--
ALTER TABLE `detalle_ventas`
  MODIFY `idDetalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `inventario`
--
ALTER TABLE `inventario`
  MODIFY `idInv` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `productos`
--
ALTER TABLE `productos`
  MODIFY `idProd` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `idProv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2147483647;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `ventas`
--
ALTER TABLE `ventas`
  MODIFY `idVenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detalle_ventas`
--
ALTER TABLE `detalle_ventas`
  ADD CONSTRAINT `detalle_ventas_ibfk_1` FOREIGN KEY (`idVenta`) REFERENCES `ventas` (`idVenta`),
  ADD CONSTRAINT `detalle_ventas_ibfk_2` FOREIGN KEY (`idProd`) REFERENCES `productos` (`idProd`);

--
-- Constraints for table `inventario`
--
ALTER TABLE `inventario`
  ADD CONSTRAINT `inventario_ibfk_1` FOREIGN KEY (`idProd`) REFERENCES `productos` (`idProd`);

--
-- Constraints for table `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`idProv`) REFERENCES `proveedores` (`idProv`);

--
-- Constraints for table `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuarios` (`idUsuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
