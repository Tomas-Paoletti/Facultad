CREATE DATABASE  IF NOT EXISTS `museo` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `museo`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: museo
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `obras`
--

DROP TABLE IF EXISTS `obras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `obras` (
  `idObras` int NOT NULL AUTO_INCREMENT,
  `AñoCreacion` int NOT NULL,
  `Creador` varchar(45) NOT NULL,
  `Descripcion` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `NombreDeLaObra` varchar(45) NOT NULL,
  `tipo` int DEFAULT NULL,
  PRIMARY KEY (`idObras`),
  UNIQUE KEY `idObras_UNIQUE` (`idObras`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obras`
--

LOCK TABLES `obras` WRITE;
/*!40000 ALTER TABLE `obras` DISABLE KEYS */;
INSERT INTO `obras` VALUES (1,1503,'Leonardo Da Vinci','Es el Retrato de Lisa Gherardini, esposa de Francesco del Giocondo, ​ más conocido como La  Monna Lisa o Gioconda, es una obra pictórica del renacentismo italiano','La Gioconda',1),(2,1819,'Théodore Géricault','Es una obra hecha con oleo , sobre un naufragio que conmovio las costas de francia en el siglo xlx','La Balsa De La Medusa',1),(3,1830,'Eugène Delacroix','Es uno de los cuadros mas famosos de la historia , que trata sobre como el pueblo uniendose desde campesinos  hasta burgueses hacen una revolucion para tener su libertad ','La Libertad Guiando Al Pueblo',1),(4,1477,'Antoine Le Moiturier(Sin Confirmar)','En esta obra lo que se representa es a 8 personas con tunicas negras levantando en sus hombros a un noble fallecido llamado Philippe Pot','Tumba de Philipe Pot',2),(5,190,'Desconnocido','Es una escultura del periodo helenistico en la cual se ve una figura alada que representa a la diosa Nike con un velo transparente','La Victoria Alada De Samotracia',2),(10,11221,'asas','sdasdsad','as',1),(11,860,'Orfebres egipcios','Son 3 Esculturas de oro macizo que representan la triada osirica(Osiris, iris y Horus)','LaTriada de osorkon ll',2);
/*!40000 ALTER TABLE `obras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tablausuarios`
--

DROP TABLE IF EXISTS `tablausuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tablausuarios` (
  `Users` varchar(45) NOT NULL,
  `Contraseñaa` varchar(45) NOT NULL,
  `Seccion` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tablausuarios`
--

LOCK TABLES `tablausuarios` WRITE;
/*!40000 ALTER TABLE `tablausuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tablausuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `Usuario` varchar(45) NOT NULL,
  `Contraseña` varchar(45) NOT NULL,
  `Seccion` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-11  2:35:57
