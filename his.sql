-- MySQL dump 10.13  Distrib 5.6.16, for Win64 (x86_64)
--
-- Host: localhost    Database: his_payroll
-- ------------------------------------------------------
-- Server version	5.6.16-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `add_entry_table`
--
DROP database his_payroll;
CREATE database his_payroll;
use his_payroll
DROP TABLE IF EXISTS `add_entry_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `add_entry_table` (
  `AE_ID` varchar(13) NOT NULL,
  `AE_name` varchar(255) NOT NULL,
  `AE_rate` decimal(7,2) NOT NULL,
  `rate_type` varchar(10) NOT NULL,
  `employee_position` varchar(255) NOT NULL,
  `project_ID` varchar(14) NOT NULL,
  PRIMARY KEY (`AE_ID`),
  KEY `ae_fk` (`project_ID`),
  CONSTRAINT `ae_fk` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `add_entry_table`
--

LOCK TABLES `add_entry_table` WRITE;
/*!40000 ALTER TABLE `add_entry_table` DISABLE KEYS */;
INSERT INTO `add_entry_table` VALUES ('AE-0000000001','Bonus',100.00,'Earning','Admin','PRJ-0000000001');
/*!40000 ALTER TABLE `add_entry_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deduction_hdmf`
--

DROP TABLE IF EXISTS `deduction_hdmf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deduction_hdmf` (
  `HDMF_ID` varchar(15) NOT NULL,
  PRIMARY KEY (`HDMF_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deduction_hdmf`
--

LOCK TABLES `deduction_hdmf` WRITE;
/*!40000 ALTER TABLE `deduction_hdmf` DISABLE KEYS */;
INSERT INTO `deduction_hdmf` VALUES ('HDMF-0000000001');
/*!40000 ALTER TABLE `deduction_hdmf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deduction_phic`
--

DROP TABLE IF EXISTS `deduction_phic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deduction_phic` (
  `PHIC_ID` varchar(15) NOT NULL,
  PRIMARY KEY (`PHIC_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deduction_phic`
--

LOCK TABLES `deduction_phic` WRITE;
/*!40000 ALTER TABLE `deduction_phic` DISABLE KEYS */;
INSERT INTO `deduction_phic` VALUES ('PHIC-0000000001');
/*!40000 ALTER TABLE `deduction_phic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deduction_sss`
--

DROP TABLE IF EXISTS `deduction_sss`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deduction_sss` (
  `SSS_ID` varchar(14) NOT NULL,
  PRIMARY KEY (`SSS_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deduction_sss`
--

LOCK TABLES `deduction_sss` WRITE;
/*!40000 ALTER TABLE `deduction_sss` DISABLE KEYS */;
INSERT INTO `deduction_sss` VALUES ('SSS-0000000001');
/*!40000 ALTER TABLE `deduction_sss` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deduction_wtax`
--

DROP TABLE IF EXISTS `deduction_wtax`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `deduction_wtax` (
  `WTAX_ID` varchar(15) NOT NULL,
  PRIMARY KEY (`WTAX_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deduction_wtax`
--

LOCK TABLES `deduction_wtax` WRITE;
/*!40000 ALTER TABLE `deduction_wtax` DISABLE KEYS */;
INSERT INTO `deduction_wtax` VALUES ('WTAX-0000000001');
/*!40000 ALTER TABLE `deduction_wtax` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_table`
--

DROP TABLE IF EXISTS `employee_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee_table` (
  `employee_ID` varchar(12) NOT NULL,
  `name_last` varchar(255) NOT NULL,
  `name_first` varchar(255) NOT NULL,
  `name_mi` varchar(255) NOT NULL,
  `employee_position` varchar(255) NOT NULL,
  `employee_type_ID` varchar(10) NOT NULL,
  `project_ID` varchar(14) NOT NULL,
  `employee_cat` varchar(255) NOT NULL,
  PRIMARY KEY (`employee_ID`),
  KEY `employee_fk` (`project_ID`),
  KEY `employee_fk2` (`employee_cat`),
  CONSTRAINT `employee_fk2` FOREIGN KEY (`employee_cat`) REFERENCES `salary_rate` (`employee_cat`) ON UPDATE CASCADE,
  CONSTRAINT `employee_fk` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_table`
--

LOCK TABLES `employee_table` WRITE;
/*!40000 ALTER TABLE `employee_table` DISABLE KEYS */;
INSERT INTO `employee_table` VALUES ('E-0000000001','Laurente','Cheng','M','Manager','O','PRJ-0000000001','Carpenter');
/*!40000 ALTER TABLE `employee_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entry_salary_report`
--

DROP TABLE IF EXISTS `entry_salary_report`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entry_salary_report` (
  `SRE_ID` varchar(14) NOT NULL,
  `basic` decimal(7,2) NOT NULL,
  `cola` decimal(7,2) NOT NULL,
  `allow` decimal(7,2) NOT NULL,
  `overtime_rate` decimal(7,2) NOT NULL,
  `undertime_rate` decimal(7,2) NOT NULL,
  `total_net_pay` decimal(7,2) NOT NULL,
  `deduction_fixed` decimal(7,2) NOT NULL,
  `payment_type` varchar(4) NOT NULL,
  `period_ID` varchar(12) NOT NULL,
  `project_ID` varchar(14) NOT NULL,
  `employee_ID` varchar(12) NOT NULL,
  `AE_ID` varchar(13) DEFAULT NULL,
  `HDMF_ID` varchar(15) NOT NULL,
  `PHIC_ID` varchar(15) NOT NULL,
  `SSS_ID` varchar(14) NOT NULL,
  `WTAX_ID` varchar(15) NOT NULL,
  PRIMARY KEY (`SRE_ID`),
  KEY `esr_fk` (`period_ID`),
  KEY `esr_fk2` (`project_ID`),
  KEY `esr_fk3` (`employee_ID`),
  KEY `esr_fk4` (`AE_ID`),
  KEY `esr_fk5` (`HDMF_ID`),
  KEY `esr_fk6` (`PHIC_ID`),
  KEY `esr_fk7` (`SSS_ID`),
  KEY `esr_fk8` (`WTAX_ID`),
  CONSTRAINT `esr_fk` FOREIGN KEY (`period_ID`) REFERENCES `period_table` (`period_ID`),
  CONSTRAINT `esr_fk2` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`),
  CONSTRAINT `esr_fk3` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`),
  CONSTRAINT `esr_fk4` FOREIGN KEY (`AE_ID`) REFERENCES `add_entry_table` (`AE_ID`),
  CONSTRAINT `esr_fk5` FOREIGN KEY (`HDMF_ID`) REFERENCES `deduction_hdmf` (`HDMF_ID`),
  CONSTRAINT `esr_fk6` FOREIGN KEY (`PHIC_ID`) REFERENCES `deduction_phic` (`PHIC_ID`),
  CONSTRAINT `esr_fk7` FOREIGN KEY (`SSS_ID`) REFERENCES `deduction_sss` (`SSS_ID`),
  CONSTRAINT `esr_fk8` FOREIGN KEY (`WTAX_ID`) REFERENCES `deduction_wtax` (`WTAX_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entry_salary_report`
--

LOCK TABLES `entry_salary_report` WRITE;
/*!40000 ALTER TABLE `entry_salary_report` DISABLE KEYS */;
INSERT INTO `entry_salary_report` VALUES ('dfg',23.00,234.00,23.00,234.00,2342.00,234.00,234.00,'23','P-0000000001','PRJ-0000000001','E-0000000001',NULL,'HDMF-0000000001','PHIC-0000000001','SSS-0000000001','WTAX-0000000001');
/*!40000 ALTER TABLE `entry_salary_report` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entry_timesheet`
--

DROP TABLE IF EXISTS `entry_timesheet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entry_timesheet` (
  `TSE_ID` varchar(14) NOT NULL,
  `date` date NOT NULL,
  `morning_in` time NOT NULL,
  `morning_out` time NOT NULL,
  `afternoon_in` time NOT NULL,
  `afternoon_out` time NOT NULL,
  `ot_in` time DEFAULT NULL,
  `ot_out` time DEFAULT NULL,
  `total_hours` decimal(3,2) NOT NULL,
  `undertime` decimal(3,2) DEFAULT NULL,
  `overtime` decimal(3,2) DEFAULT NULL,
  `period_ID` varchar(12) NOT NULL,
  `project_ID` varchar(14) NOT NULL,
  `employee_ID` varchar(12) NOT NULL,
  PRIMARY KEY (`TSE_ID`),
  KEY `et_fk` (`period_ID`),
  KEY `et_fk2` (`project_ID`),
  KEY `et_fk3` (`employee_ID`),
  CONSTRAINT `et_fk` FOREIGN KEY (`period_ID`) REFERENCES `period_table` (`period_ID`),
  CONSTRAINT `et_fk2` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`),
  CONSTRAINT `et_fk3` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entry_timesheet`
--

LOCK TABLES `entry_timesheet` WRITE;
/*!40000 ALTER TABLE `entry_timesheet` DISABLE KEYS */;
INSERT INTO `entry_timesheet` VALUES ('TSE-0000000003','2014-03-12','00:00:00','00:00:00','00:00:00','00:00:00',NULL,NULL,0.00,NULL,NULL,'P-0000000001','PRJ-0000000001','E-0000000001');
/*!40000 ALTER TABLE `entry_timesheet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `period_table`
--

DROP TABLE IF EXISTS `period_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `period_table` (
  `period_ID` varchar(12) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `week_num` int(2) NOT NULL,
  `month` varchar(9) NOT NULL,
  `year` year(4) NOT NULL,
  PRIMARY KEY (`period_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `period_table`
--

LOCK TABLES `period_table` WRITE;
/*!40000 ALTER TABLE `period_table` DISABLE KEYS */;
INSERT INTO `period_table` VALUES ('P-0000000001','2014-03-10','2014-03-15',11,'March',2014);
/*!40000 ALTER TABLE `period_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projects_table`
--

DROP TABLE IF EXISTS `projects_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projects_table` (
  `project_ID` varchar(14) NOT NULL,
  `project_name` varchar(255) NOT NULL,
  `project_location` varchar(255) NOT NULL,
  `project_status` varchar(10) NOT NULL DEFAULT 'Ongoing',
  `project_lodging` decimal(6,2) NOT NULL,
  `project_net_pay` decimal(8,2) NOT NULL,
  PRIMARY KEY (`project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projects_table`
--

LOCK TABLES `projects_table` WRITE;
/*!40000 ALTER TABLE `projects_table` DISABLE KEYS */;
INSERT INTO `projects_table` VALUES ('PRJ-0000000001','HIS MAIN OFFICE','Address of HIS building','Ongoing',0.00,0.00);
/*!40000 ALTER TABLE `projects_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salary_rate`
--

DROP TABLE IF EXISTS `salary_rate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salary_rate` (
  `employee_cat` varchar(255) NOT NULL,
  `salary` decimal(7,2) NOT NULL,
  PRIMARY KEY (`employee_cat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salary_rate`
--

LOCK TABLES `salary_rate` WRITE;
/*!40000 ALTER TABLE `salary_rate` DISABLE KEYS */;
INSERT INTO `salary_rate` VALUES ('Carpenter',400.00),('Mason',400.00),('Office',0.00),('Subcon',0.00),('Welder',400.00);
/*!40000 ALTER TABLE `salary_rate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_accounts_table`
--

DROP TABLE IF EXISTS `user_accounts_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_accounts_table` (
  `user_ID` varchar(15) NOT NULL,
  `username` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `first_name` varchar(256) NOT NULL,
  `last_name` varchar(256) NOT NULL,
  PRIMARY KEY (`user_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_accounts_table`
--

LOCK TABLES `user_accounts_table` WRITE;
/*!40000 ALTER TABLE `user_accounts_table` DISABLE KEYS */;
INSERT INTO `user_accounts_table` VALUES ('USER-00001','HISadmin','admin123','HIS','Administrator');
/*!40000 ALTER TABLE `user_accounts_table` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `worker_office`
--

DROP TABLE IF EXISTS `worker_office`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `worker_office` (
  `employee_ID` varchar(14) NOT NULL,
  `acct_number` varchar(20) NOT NULL,
  `cash_advance_balance` decimal(6,2) NOT NULL,
  KEY `wo_fk` (`employee_ID`),
  CONSTRAINT `wo_fk` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_office`
--

LOCK TABLES `worker_office` WRITE;
/*!40000 ALTER TABLE `worker_office` DISABLE KEYS */;
/*!40000 ALTER TABLE `worker_office` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `worker_regular`
--

DROP TABLE IF EXISTS `worker_regular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `worker_regular` (
  `employee_ID` varchar(14) NOT NULL,
  `acct_number` varchar(20) NOT NULL,
  `cash_advance_balance` decimal(6,2) NOT NULL,
  KEY `wr_fk` (`employee_ID`),
  CONSTRAINT `wr_fk` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_regular`
--

LOCK TABLES `worker_regular` WRITE;
/*!40000 ALTER TABLE `worker_regular` DISABLE KEYS */;
/*!40000 ALTER TABLE `worker_regular` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `worker_subcon`
--

DROP TABLE IF EXISTS `worker_subcon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `worker_subcon` (
  `employee_ID` varchar(14) NOT NULL,
  `company_name` varchar(255) NOT NULL,
  KEY `ws_fk` (`employee_ID`),
  CONSTRAINT `ws_fk` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_subcon`
--

LOCK TABLES `worker_subcon` WRITE;
/*!40000 ALTER TABLE `worker_subcon` DISABLE KEYS */;
/*!40000 ALTER TABLE `worker_subcon` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-03-16 20:35:04
