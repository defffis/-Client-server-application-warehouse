CREATE DATABASE  IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mydb`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
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
-- Table structure for table `client_help`
--

DROP TABLE IF EXISTS `client_help`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_help` (
  `id_client` int unsigned NOT NULL AUTO_INCREMENT COMMENT 'Код_клиента',
  `name_client` varchar(45) NOT NULL COMMENT 'Название_клиента',
  `id_country` int unsigned NOT NULL,
  `address_client` varchar(255) NOT NULL COMMENT 'Адрес клиента',
  PRIMARY KEY (`id_client`),
  UNIQUE KEY `id_client_UNIQUE` (`id_client`),
  UNIQUE KEY `name_client_UNIQUE` (`name_client`),
  KEY `fk_client_help_country1_idx` (`id_country`),
  CONSTRAINT `fk_client_help_country1` FOREIGN KEY (`id_country`) REFERENCES `country` (`id_country`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_help`
--

LOCK TABLES `client_help` WRITE;
/*!40000 ALTER TABLE `client_help` DISABLE KEYS */;
INSERT INTO `client_help` VALUES (1,'TALSU TEHNIKA ООО',1,'220117, город Минск, Машиностроителей 29 офис 102'),(2,'КРЕАТУРА ООО',1,'220125, город Минск, д Боровая 3 офис 56'),(3,'ЕВРОПРОМ ЧУП',1,'220073, город Минск, Ольшевского 10 офис 4 (5 этаж)'),(4,'АВТОДСТЕХНО ЧУП',1,'220116, город Минск, пр Дзержинского 104-503Б'),(5,'МИСОМ ОП ОАО',1,'222518, город Борисов, Демина 39 пав 12а'),(6,'Lesprom Network',1,'220073, город Минск, Бирюзова 4/5 пом 1012'),(7,'Группа «Илим»',1,'220125, город Минск, д Боровая 3 офис 56'),(8,'Рауте Сервис',1,'220049, город Минск, Чайковского 34'),(9,'Группа компаний «УЛК»',1,'212013, город Могилев, Славгородский проезд 37'),(10,'Старвуд-НН',1,'220138, город Минск, Карвата 61 пом 1с');
/*!40000 ALTER TABLE `client_help` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `country` (
  `id_country` int unsigned NOT NULL AUTO_INCREMENT,
  `country_name_min` varchar(5) NOT NULL,
  `country_name_max` varchar(45) NOT NULL,
  PRIMARY KEY (`id_country`),
  UNIQUE KEY `id_country_UNIQUE` (`id_country`),
  UNIQUE KEY `country_name_min_UNIQUE` (`country_name_min`),
  UNIQUE KEY `country_name_max_UNIQUE` (`country_name_max`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES (1,'РБ','Республика Беларусь'),(2,'РФ','Российская Федерация'),(3,'ИР','Исламская Республика Иран');
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ksu_one`
--

DROP TABLE IF EXISTS `ksu_one`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ksu_one` (
  `id_ksu` int unsigned NOT NULL AUTO_INCREMENT,
  `id_produkt` int unsigned NOT NULL,
  PRIMARY KEY (`id_ksu`),
  UNIQUE KEY `id_ksu_UNIQUE` (`id_ksu`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ksu_one`
--

LOCK TABLES `ksu_one` WRITE;
/*!40000 ALTER TABLE `ksu_one` DISABLE KEYS */;
INSERT INTO `ksu_one` VALUES (3,3),(5,16),(6,19),(7,14),(8,13),(9,17);
/*!40000 ALTER TABLE `ksu_one` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ksu_two`
--

DROP TABLE IF EXISTS `ksu_two`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ksu_two` (
  `id_ntn` int DEFAULT NULL,
  `id_input_order` int DEFAULT NULL,
  `ksu_date` date NOT NULL,
  `id_client` int DEFAULT NULL,
  `id_provider` int DEFAULT NULL,
  `id_worker` int DEFAULT NULL,
  `coming` int DEFAULT NULL COMMENT 'приход',
  `consumption` int DEFAULT NULL COMMENT 'расход'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ksu_two`
--

LOCK TABLES `ksu_two` WRITE;
/*!40000 ALTER TABLE `ksu_two` DISABLE KEYS */;
/*!40000 ALTER TABLE `ksu_two` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ntn_one`
--

DROP TABLE IF EXISTS `ntn_one`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ntn_one` (
  `id_ntn` int unsigned NOT NULL AUTO_INCREMENT COMMENT 'Номер_требование_накладной',
  `ntn_date` date NOT NULL COMMENT 'Дата Номер_требование_накладной',
  `id_client` int unsigned NOT NULL,
  `about_ntn` varchar(155) DEFAULT NULL COMMENT 'Назначение',
  PRIMARY KEY (`id_ntn`),
  UNIQUE KEY `id_ntn_UNIQUE` (`id_ntn`),
  KEY `fk_ntn_one_client_help_idx` (`id_client`),
  CONSTRAINT `fk_ntn_one_client_help` FOREIGN KEY (`id_client`) REFERENCES `client_help` (`id_client`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ntn_one`
--

LOCK TABLES `ntn_one` WRITE;
/*!40000 ALTER TABLE `ntn_one` DISABLE KEYS */;
INSERT INTO `ntn_one` VALUES (5,'2021-11-03',1,''),(6,'2021-11-04',1,''),(7,'2021-11-10',8,'');
/*!40000 ALTER TABLE `ntn_one` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ntn_two`
--

DROP TABLE IF EXISTS `ntn_two`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ntn_two` (
  `id_ntn` int unsigned NOT NULL,
  `id_produkt` int unsigned NOT NULL,
  `id_ksu` int unsigned NOT NULL,
  `id_worker` int unsigned NOT NULL,
  `requested` int DEFAULT NULL COMMENT 'затребовано',
  `released` int DEFAULT NULL COMMENT 'отпущено',
  KEY `fk_ntn_two_ntn_one1_idx` (`id_ntn`),
  KEY `fk_ntn_two_produkt_help1_idx` (`id_produkt`),
  KEY `fk_ntn_two_ksu_one1_idx` (`id_ksu`),
  KEY `fk_ntn_two_worker_help1_idx` (`id_worker`),
  CONSTRAINT `fk_ntn_two_ksu_one1` FOREIGN KEY (`id_ksu`) REFERENCES `ksu_one` (`id_ksu`),
  CONSTRAINT `fk_ntn_two_ntn_one1` FOREIGN KEY (`id_ntn`) REFERENCES `ntn_one` (`id_ntn`),
  CONSTRAINT `fk_ntn_two_produkt_help1` FOREIGN KEY (`id_produkt`) REFERENCES `produkt_help` (`id_produkt`),
  CONSTRAINT `fk_ntn_two_worker_help1` FOREIGN KEY (`id_worker`) REFERENCES `worker_help` (`id_worker`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ntn_two`
--

LOCK TABLES `ntn_two` WRITE;
/*!40000 ALTER TABLE `ntn_two` DISABLE KEYS */;
INSERT INTO `ntn_two` VALUES (5,16,5,1,3,3),(5,19,5,1,2,1),(5,13,5,1,5,5),(6,19,6,7,4,4),(6,13,6,7,6,4),(6,17,9,7,6,4),(7,14,7,9,6,6),(5,16,5,2,40,35);
/*!40000 ALTER TABLE `ntn_two` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produkt_help`
--

DROP TABLE IF EXISTS `produkt_help`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produkt_help` (
  `id_produkt` int unsigned NOT NULL AUTO_INCREMENT COMMENT 'Код_товара',
  `name_produkt` varchar(45) NOT NULL COMMENT 'Наименование товара',
  `id_unit_produkt` int unsigned NOT NULL COMMENT 'Единица_измеренмя',
  `unit_price_produkt` decimal(10,0) unsigned NOT NULL COMMENT 'цена товара',
  PRIMARY KEY (`id_produkt`),
  UNIQUE KEY `id_produkt_UNIQUE` (`id_produkt`),
  UNIQUE KEY `name_produkt_UNIQUE` (`name_produkt`),
  KEY `fk_produkt_help_unit_produkt1_idx` (`id_unit_produkt`),
  CONSTRAINT `fk_produkt_help_unit_produkt1` FOREIGN KEY (`id_unit_produkt`) REFERENCES `unit_produkt` (`id_unit_produkt`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produkt_help`
--

LOCK TABLES `produkt_help` WRITE;
/*!40000 ALTER TABLE `produkt_help` DISABLE KEYS */;
INSERT INTO `produkt_help` VALUES (1,'Брусок',1,50),(2,'Доска',1,120),(13,'Шкаф с витриной',1,1659),(14,'Тумба ТВ',1,1651),(15,'Стол журнальный',1,838),(16,'Стул',1,563),(17,'Шкаф-купе',1,2094),(18,'Кровать двойная',1,727),(19,'Тумба прикроватная',1,181),(20,'Зеркало настенное',2,181),(21,'Столешница',2,158);
/*!40000 ALTER TABLE `produkt_help` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provider_help`
--

DROP TABLE IF EXISTS `provider_help`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provider_help` (
  `id_provider` int unsigned NOT NULL AUTO_INCREMENT COMMENT 'Код_поставщика',
  `name_provider` varchar(45) NOT NULL COMMENT 'Наименование_поставщика',
  `id_country` int unsigned NOT NULL COMMENT 'Страна_поставщика',
  PRIMARY KEY (`id_provider`),
  UNIQUE KEY `id_provider_UNIQUE` (`id_provider`),
  UNIQUE KEY `name_provider_UNIQUE` (`name_provider`),
  KEY `fk_provider_help_country1_idx` (`id_country`) /*!80000 INVISIBLE */,
  CONSTRAINT `fk_provider_help_country1` FOREIGN KEY (`id_country`) REFERENCES `country` (`id_country`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provider_help`
--

LOCK TABLES `provider_help` WRITE;
/*!40000 ALTER TABLE `provider_help` DISABLE KEYS */;
INSERT INTO `provider_help` VALUES (1,'БЕЛМАШ СООО',1),(2,'СИТИ ПАРК ООО',1),(3,'САВВУДСЕРВИС ООО',1),(4,'НАМАС-М УП',1),(5,'ХАРДМЕТАЛ ООО',1),(6,'ПАСТУШКОВ П.И. ИП',1),(7,'ХЕННЛИХ СООО',1);
/*!40000 ALTER TABLE `provider_help` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ttn`
--

DROP TABLE IF EXISTS `ttn`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ttn` (
  `id_input_order` int unsigned NOT NULL AUTO_INCREMENT COMMENT 'Код_приходного_ордера',
  `date_ttn` date NOT NULL COMMENT 'Дата ТТН',
  `id_produkt` int unsigned NOT NULL COMMENT 'Код_товара',
  `input_produkt` int NOT NULL COMMENT 'Поступило кол-во',
  `id_provider` int unsigned NOT NULL COMMENT 'Код_поставщика',
  `id_ksu` int unsigned NOT NULL COMMENT 'Номер_КСУ',
  `id_worker` int unsigned NOT NULL COMMENT 'Кто_принял',
  PRIMARY KEY (`id_input_order`),
  UNIQUE KEY `id_input_order_UNIQUE` (`id_input_order`),
  KEY `fk_ttn_produkt_help1_idx` (`id_produkt`),
  KEY `fk_ttn_ksu_one1_idx` (`id_ksu`),
  KEY `fk_ttn_worker_help1_idx` (`id_worker`),
  KEY `fk_ttn_provider_help1_idx` (`id_provider`),
  CONSTRAINT `fk_ttn_ksu_one1` FOREIGN KEY (`id_ksu`) REFERENCES `ksu_one` (`id_ksu`),
  CONSTRAINT `fk_ttn_produkt_help1` FOREIGN KEY (`id_produkt`) REFERENCES `produkt_help` (`id_produkt`),
  CONSTRAINT `fk_ttn_provider_help1` FOREIGN KEY (`id_provider`) REFERENCES `provider_help` (`id_provider`),
  CONSTRAINT `fk_ttn_worker_help1` FOREIGN KEY (`id_worker`) REFERENCES `worker_help` (`id_worker`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ttn`
--

LOCK TABLES `ttn` WRITE;
/*!40000 ALTER TABLE `ttn` DISABLE KEYS */;
INSERT INTO `ttn` VALUES (9,'2021-11-10',16,59,1,5,3),(10,'2021-10-26',19,40,6,6,2),(11,'2021-10-14',14,45,3,7,7),(12,'2021-10-14',13,20,5,8,4),(13,'2021-10-14',17,25,7,9,5);
/*!40000 ALTER TABLE `ttn` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit_produkt`
--

DROP TABLE IF EXISTS `unit_produkt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unit_produkt` (
  `id_unit_produkt` int unsigned NOT NULL AUTO_INCREMENT,
  `unit_produkt` varchar(10) NOT NULL,
  `unit_produkt_full` varchar(45) NOT NULL,
  PRIMARY KEY (`id_unit_produkt`),
  UNIQUE KEY `id_unit_produkt_UNIQUE` (`id_unit_produkt`),
  UNIQUE KEY `unit_produkt_UNIQUE` (`unit_produkt`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit_produkt`
--

LOCK TABLES `unit_produkt` WRITE;
/*!40000 ALTER TABLE `unit_produkt` DISABLE KEYS */;
INSERT INTO `unit_produkt` VALUES (1,'Шт.','Штуки'),(2,'m2','Квадратный метр'),(3,'m3','Кубический метр');
/*!40000 ALTER TABLE `unit_produkt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `idusers` int unsigned NOT NULL AUTO_INCREMENT,
  `users_name` varchar(45) NOT NULL,
  `users_pass` varchar(45) NOT NULL,
  `users_primary` tinyint NOT NULL,
  PRIMARY KEY (`idusers`),
  UNIQUE KEY `idusers_UNIQUE` (`idusers`),
  UNIQUE KEY `users_name_UNIQUE` (`users_name`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'root','root',2),(9,'user','user',0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_balance`
--

DROP TABLE IF EXISTS `view_balance`;
/*!50001 DROP VIEW IF EXISTS `view_balance`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_balance` AS SELECT 
 1 AS `bid_ksu`,
 1 AS `name_produkt`,
 1 AS `input_produkt`,
 1 AS `released`,
 1 AS `balance`,
 1 AS `unit_produkt`,
 1 AS `total_price`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_client_help`
--

DROP TABLE IF EXISTS `view_client_help`;
/*!50001 DROP VIEW IF EXISTS `view_client_help`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_client_help` AS SELECT 
 1 AS `id_client`,
 1 AS `name_client`,
 1 AS `country_name_min`,
 1 AS `address_client`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_input`
--

DROP TABLE IF EXISTS `view_input`;
/*!50001 DROP VIEW IF EXISTS `view_input`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_input` AS SELECT 
 1 AS `id_produkt`,
 1 AS `sum_input_produkt`,
 1 AS `id_ksu`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_ksu_one`
--

DROP TABLE IF EXISTS `view_ksu_one`;
/*!50001 DROP VIEW IF EXISTS `view_ksu_one`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_ksu_one` AS SELECT 
 1 AS `id_ksu`,
 1 AS `name_produkt`,
 1 AS `id_produkt`,
 1 AS `unit_produkt`,
 1 AS `unit_price_produkt`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_ksu_two`
--

DROP TABLE IF EXISTS `view_ksu_two`;
/*!50001 DROP VIEW IF EXISTS `view_ksu_two`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_ksu_two` AS SELECT 
 1 AS `ntn_date`,
 1 AS `id_input_order`,
 1 AS `id_ntn`,
 1 AS `aaa`,
 1 AS `name_client`,
 1 AS `input_produkt`,
 1 AS `released`,
 1 AS `balance`,
 1 AS `total_price`,
 1 AS `bid_ksu`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_ntn_one`
--

DROP TABLE IF EXISTS `view_ntn_one`;
/*!50001 DROP VIEW IF EXISTS `view_ntn_one`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_ntn_one` AS SELECT 
 1 AS `id_ntn`,
 1 AS `ntn_date`,
 1 AS `name_client`,
 1 AS `about_ntn`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_ntn_two`
--

DROP TABLE IF EXISTS `view_ntn_two`;
/*!50001 DROP VIEW IF EXISTS `view_ntn_two`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_ntn_two` AS SELECT 
 1 AS `id_ntn`,
 1 AS `name_produkt`,
 1 AS `id_ksu`,
 1 AS `requested`,
 1 AS `released`,
 1 AS `fio_worker`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_produkt_help`
--

DROP TABLE IF EXISTS `view_produkt_help`;
/*!50001 DROP VIEW IF EXISTS `view_produkt_help`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_produkt_help` AS SELECT 
 1 AS `id_produkt`,
 1 AS `name_produkt`,
 1 AS `unit_price_produkt`,
 1 AS `unit_produkt`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_provider_help`
--

DROP TABLE IF EXISTS `view_provider_help`;
/*!50001 DROP VIEW IF EXISTS `view_provider_help`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_provider_help` AS SELECT 
 1 AS `id_provider`,
 1 AS `name_provider`,
 1 AS `country_name_max`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_relesed`
--

DROP TABLE IF EXISTS `view_relesed`;
/*!50001 DROP VIEW IF EXISTS `view_relesed`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_relesed` AS SELECT 
 1 AS `id_produkt`,
 1 AS `sum_released`,
 1 AS `id_ksu`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_slaves`
--

DROP TABLE IF EXISTS `view_slaves`;
/*!50001 DROP VIEW IF EXISTS `view_slaves`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_slaves` AS SELECT 
 1 AS `Заведующий`,
 1 AS `Кладовщик`,
 1 AS `Грузчик`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_ttn`
--

DROP TABLE IF EXISTS `view_ttn`;
/*!50001 DROP VIEW IF EXISTS `view_ttn`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_ttn` AS SELECT 
 1 AS `id_input_order`,
 1 AS `date_ttn`,
 1 AS `name_produkt`,
 1 AS `input_produkt`,
 1 AS `name_provider`,
 1 AS `id_ksu`,
 1 AS `fio_worker`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `worker`
--

DROP TABLE IF EXISTS `worker`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `worker` (
  `fio_worker` varchar(45) DEFAULT NULL,
  `post_worker` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker`
--

LOCK TABLES `worker` WRITE;
/*!40000 ALTER TABLE `worker` DISABLE KEYS */;
/*!40000 ALTER TABLE `worker` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `worker_help`
--

DROP TABLE IF EXISTS `worker_help`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `worker_help` (
  `id_worker` int unsigned NOT NULL AUTO_INCREMENT COMMENT 'Код_сотрудника',
  `fio_worker` varchar(45) NOT NULL COMMENT 'ФИО cjnhelybrf',
  `post_worker` varchar(45) NOT NULL COMMENT 'Должность сотрудника',
  PRIMARY KEY (`id_worker`),
  UNIQUE KEY `id_worker_UNIQUE` (`id_worker`),
  UNIQUE KEY `fio_worker_UNIQUE` (`fio_worker`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_help`
--

LOCK TABLES `worker_help` WRITE;
/*!40000 ALTER TABLE `worker_help` DISABLE KEYS */;
INSERT INTO `worker_help` VALUES (1,'Михайлов Остап','Заведующий'),(2,'Родионов Емельян','Заведующий'),(3,'Исаев Ибрагил','Заведующий'),(4,'Якушев Модест','Кладовщик'),(5,'Белов Аверьян','Кладовщик'),(6,'Никитин Алан','Кладовщик'),(7,'Третьяков Аверкий','Кладовщик'),(8,'Горбачёв Ян','Грузчик'),(9,'Субботин Федор','Грузчик');
/*!40000 ALTER TABLE `worker_help` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `worker_help_AFTER_UPDATE` AFTER UPDATE ON `worker_help` FOR EACH ROW BEGIN
insert into worker (fio_worker, post_worker) values (old.fio_worker, old.post_worker);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `worker_help_AFTER_DELETE` AFTER DELETE ON `worker_help` FOR EACH ROW BEGIN
	insert into worker_terminated (fio_worker, post_worker) values (old.fio_worker, old.post_worker);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `worker_terminated`
--

DROP TABLE IF EXISTS `worker_terminated`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `worker_terminated` (
  `id_worker` int NOT NULL AUTO_INCREMENT,
  `fio_worker` varchar(45) DEFAULT NULL,
  `post_worker` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_worker`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_terminated`
--

LOCK TABLES `worker_terminated` WRITE;
/*!40000 ALTER TABLE `worker_terminated` DISABLE KEYS */;
INSERT INTO `worker_terminated` VALUES (1,'Мишин Матвей','Грузчик');
/*!40000 ALTER TABLE `worker_terminated` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `worker_terminated_AFTER_INSERT` AFTER INSERT ON `worker_terminated` FOR EACH ROW BEGIN
insert into worker (fio_worker, post_worker) values (new.fio_worker, new.post_worker);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--

--
-- Final view structure for view `view_balance`
--

/*!50001 DROP VIEW IF EXISTS `view_balance`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_balance` AS select `vi`.`id_ksu` AS `bid_ksu`,`p`.`name_produkt` AS `name_produkt`,`vi`.`sum_input_produkt` AS `input_produkt`,`vr`.`sum_released` AS `released`,(`vi`.`sum_input_produkt` - `vr`.`sum_released`) AS `balance`,`vp`.`unit_produkt` AS `unit_produkt`,((`vi`.`sum_input_produkt` - `vr`.`sum_released`) * `p`.`unit_price_produkt`) AS `total_price` from ((((((`produkt_help` `p` join `view_relesed` `vr`) join `view_input` `vi` on((`vi`.`id_produkt` = `vr`.`id_produkt`))) join `view_produkt_help` `vp`) join `ntn_two` `n`) join `ksu_one` `k`) join `produkt_help` on((`vi`.`id_produkt` = `p`.`id_produkt`))) group by `vr`.`id_produkt` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_client_help`
--

/*!50001 DROP VIEW IF EXISTS `view_client_help`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_client_help` AS select `client_help`.`id_client` AS `id_client`,`client_help`.`name_client` AS `name_client`,`country`.`country_name_min` AS `country_name_min`,`client_help`.`address_client` AS `address_client` from (`client_help` join `country` on((`client_help`.`id_country` = `country`.`id_country`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_input`
--

/*!50001 DROP VIEW IF EXISTS `view_input`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_input` AS select `t`.`id_produkt` AS `id_produkt`,sum(`t`.`input_produkt`) AS `sum_input_produkt`,`t`.`id_ksu` AS `id_ksu` from (`ttn` `t` join `produkt_help` `p`) where (`t`.`id_produkt` = `p`.`id_produkt`) group by `t`.`id_produkt` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_ksu_one`
--

/*!50001 DROP VIEW IF EXISTS `view_ksu_one`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ksu_one` AS select `k`.`id_ksu` AS `id_ksu`,`p`.`name_produkt` AS `name_produkt`,`k`.`id_produkt` AS `id_produkt`,`vp`.`unit_produkt` AS `unit_produkt`,`p`.`unit_price_produkt` AS `unit_price_produkt` from (((`ksu_one` `k` join `produkt_help` `p`) join `view_produkt_help` `vp`) join `ksu_one` on((`k`.`id_produkt` = `p`.`id_produkt`))) group by `k`.`id_ksu` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_ksu_two`
--

/*!50001 DROP VIEW IF EXISTS `view_ksu_two`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ksu_two` AS select `vn`.`ntn_date` AS `ntn_date`,`vt`.`id_input_order` AS `id_input_order`,`vn`.`id_ntn` AS `id_ntn`,`vt`.`name_provider` AS `aaa`,`vn`.`name_client` AS `name_client`,`vb`.`input_produkt` AS `input_produkt`,`vb`.`released` AS `released`,`vb`.`balance` AS `balance`,`vb`.`total_price` AS `total_price`,`vb`.`bid_ksu` AS `bid_ksu` from (((((`produkt_help` `p` join `ksu_one` `k`) join `view_produkt_help` `vp`) join `view_ntn_one` `vn`) join `view_ttn` `vt`) join `view_balance` `vb`) group by `vb`.`bid_ksu` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_ntn_one`
--

/*!50001 DROP VIEW IF EXISTS `view_ntn_one`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ntn_one` AS select `ntn_one`.`id_ntn` AS `id_ntn`,`ntn_one`.`ntn_date` AS `ntn_date`,`client_help`.`name_client` AS `name_client`,`ntn_one`.`about_ntn` AS `about_ntn` from (`ntn_one` join `client_help` on((`ntn_one`.`id_client` = `client_help`.`id_client`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_ntn_two`
--

/*!50001 DROP VIEW IF EXISTS `view_ntn_two`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ntn_two` AS select `ntn_two`.`id_ntn` AS `id_ntn`,`produkt_help`.`name_produkt` AS `name_produkt`,`ntn_two`.`id_ksu` AS `id_ksu`,`ntn_two`.`requested` AS `requested`,`ntn_two`.`released` AS `released`,`worker_help`.`fio_worker` AS `fio_worker` from ((`ntn_two` join `produkt_help` on((`ntn_two`.`id_produkt` = `produkt_help`.`id_produkt`))) join `worker_help` on((`ntn_two`.`id_worker` = `worker_help`.`id_worker`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_produkt_help`
--

/*!50001 DROP VIEW IF EXISTS `view_produkt_help`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_produkt_help` AS select `produkt_help`.`id_produkt` AS `id_produkt`,`produkt_help`.`name_produkt` AS `name_produkt`,`produkt_help`.`unit_price_produkt` AS `unit_price_produkt`,`unit_produkt`.`unit_produkt` AS `unit_produkt` from (`produkt_help` join `unit_produkt` on((`produkt_help`.`id_unit_produkt` = `unit_produkt`.`id_unit_produkt`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_provider_help`
--

/*!50001 DROP VIEW IF EXISTS `view_provider_help`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_provider_help` AS select `provider_help`.`id_provider` AS `id_provider`,`provider_help`.`name_provider` AS `name_provider`,`country`.`country_name_max` AS `country_name_max` from (`provider_help` join `country` on((`provider_help`.`id_country` = `country`.`id_country`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_relesed`
--

/*!50001 DROP VIEW IF EXISTS `view_relesed`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_relesed` AS select `n`.`id_produkt` AS `id_produkt`,sum(`n`.`released`) AS `sum_released`,`n`.`id_ksu` AS `id_ksu` from (`ntn_two` `n` join `produkt_help` `p`) where (`n`.`id_produkt` = `p`.`id_produkt`) group by `n`.`id_produkt` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_slaves`
--

/*!50001 DROP VIEW IF EXISTS `view_slaves`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_slaves` AS select (case `worker_help`.`post_worker` when 'Заведующий' then `worker_help`.`fio_worker` else '' end) AS `Заведующий`,(case `worker_help`.`post_worker` when 'Кладовщик' then `worker_help`.`fio_worker` else '' end) AS `Кладовщик`,(case `worker_help`.`post_worker` when 'Грузчик' then `worker_help`.`fio_worker` else '' end) AS `Грузчик` from `worker_help` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_ttn`
--

/*!50001 DROP VIEW IF EXISTS `view_ttn`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ttn` AS select `ttn`.`id_input_order` AS `id_input_order`,`ttn`.`date_ttn` AS `date_ttn`,`produkt_help`.`name_produkt` AS `name_produkt`,`ttn`.`input_produkt` AS `input_produkt`,`provider_help`.`name_provider` AS `name_provider`,`ttn`.`id_ksu` AS `id_ksu`,`worker_help`.`fio_worker` AS `fio_worker` from (((`ttn` join `produkt_help` on((`ttn`.`id_produkt` = `produkt_help`.`id_produkt`))) join `provider_help` on((`ttn`.`id_provider` = `provider_help`.`id_provider`))) join `worker_help` on((`ttn`.`id_worker` = `worker_help`.`id_worker`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-18  9:55:04
