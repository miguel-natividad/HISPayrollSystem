-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 10, 2014 at 01:16 PM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+08:00";

CREATE SCHEMA IF NOT EXISTS `his_payroll` DEFAULT CHARACTER SET utf8 ;
USE `his_payroll`;


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `his_payroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_entry_table`
--

CREATE TABLE IF NOT EXISTS `add_entry_table` (
  `AE_ID` varchar(13) NOT NULL,
  `AE_name` varchar(256) NOT NULL,
  `AE_rate` decimal(7,2) NOT NULL,
  `rate_type` varchar(10) NOT NULL,
  `employee_position` varchar(256) NOT NULL,
  `project_ID` varchar(14) NOT NULL,
  PRIMARY KEY (`AE_ID`),
  KEY `project_ID` (`project_ID`),
  KEY `project_ID_2` (`project_ID`),
  KEY `project_ID_3` (`project_ID`),
  KEY `AE_ID` (`AE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_entry_table`
--

INSERT INTO `add_entry_table` (`AE_ID`, `AE_name`, `AE_rate`, `rate_type`, `employee_position`, `project_ID`) VALUES
('AE-0000000001', 'Bonus', '100.00', 'Earning', 'Admin', 'PRJ-0000000001');

-- --------------------------------------------------------

--
-- Table structure for table `deduction_HDMF`
--

CREATE TABLE IF NOT EXISTS `deduction_HDMF` (
  `HDMF_ID` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `deduction_PHIC`
--

CREATE TABLE IF NOT EXISTS `deduction_PHIC` (
  `PHIC_ID` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `deduction_SSS`
--

CREATE TABLE IF NOT EXISTS `deduction_SSS` (
  `SSS_ID` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `deduction_WTAX`
--

CREATE TABLE IF NOT EXISTS `deduction_WTAX` (
  `WTAX_ID` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employee_table`
--

CREATE TABLE IF NOT EXISTS `employee_table` (
  `employee_ID` varchar(12) NOT NULL,
  `name_last` varchar(256) NOT NULL,
  `name_first` varchar(256) NOT NULL,
  `name_mi` varchar(256) NOT NULL,
  `employee_position` varchar(256) NOT NULL,
  `employee_type_ID` varchar(10) NOT NULL,
  PRIMARY KEY (`employee_ID`),
  UNIQUE KEY `employee_type_ID_7` (`employee_type_ID`),
  KEY `employee_ID` (`employee_ID`),
  KEY `employee_type_ID` (`employee_type_ID`),
  KEY `employee_ID_2` (`employee_ID`),
  KEY `employee_type_ID_2` (`employee_type_ID`),
  KEY `employee_ID_3` (`employee_ID`),
  KEY `employee_type_ID_3` (`employee_type_ID`),
  KEY `employee_type_ID_4` (`employee_type_ID`),
  KEY `employee_type_ID_5` (`employee_type_ID`),
  KEY `employee_type_ID_6` (`employee_type_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_table`
--

INSERT INTO `employee_table` (`employee_ID`, `name_last`, `name_first`, `name_mi`, `employee_position`, `employee_type_ID`) VALUES
('E-0000000001', 'Laurente', 'Cheng', 'Z', 'Manager', 'O');

-- --------------------------------------------------------

--
-- Table structure for table `entry_salary_report`
--

CREATE TABLE IF NOT EXISTS `entry_salary_report` (
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
  `AE_ID` varchar(13) NOT NULL,
  PRIMARY KEY (`SRE_ID`),
  KEY `period_ID` (`period_ID`),
  KEY `project_ID` (`project_ID`),
  KEY `employee_ID` (`employee_ID`),
  KEY `period_ID_2` (`period_ID`),
  KEY `project_ID_2` (`project_ID`),
  KEY `employee_ID_2` (`employee_ID`),
  KEY `AE_ID` (`AE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `entry_timesheet`
--

CREATE TABLE IF NOT EXISTS `entry_timesheet` (
  `TSE_ID` varchar(14) NOT NULL,
  `date` date NOT NULL,
  `morning_in` time NOT NULL,
  `morning_out` time NOT NULL,
  `afternoon_in` time NOT NULL,
  `afternoon_out` time NOT NULL,
  `ot_in` time NOT NULL,
  `ot_out` time NOT NULL,
  `total_hours` decimal(3,2) NOT NULL,
  `undertime` decimal(3,2) NOT NULL,
  `overtime` decimal(3,2) NOT NULL,
  `period_ID` varchar(12) NOT NULL,
  `project_ID` varchar(14) NOT NULL,
  `employee_ID` varchar(12) NOT NULL,
  PRIMARY KEY (`TSE_ID`),
  UNIQUE KEY `project_ID` (`project_ID`),
  UNIQUE KEY `employee_ID` (`employee_ID`),
  KEY `period_ID` (`period_ID`),
  KEY `period_ID_2` (`period_ID`),
  KEY `project_ID_2` (`project_ID`),
  KEY `employee_ID_2` (`employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `entry_timesheet`
--

INSERT INTO `entry_timesheet` (`TSE_ID`, `date`, `morning_in`, `morning_out`, `afternoon_in`, `afternoon_out`, `ot_in`, `ot_out`, `total_hours`, `undertime`, `overtime`, `period_ID`, `project_ID`, `employee_ID`) VALUES
('TSE-0000000001', '2014-03-10', '08:00:00', '12:00:00', '01:00:00', '05:00:00', '05:02:00', '06:02:00', '8.00', '0.00', '1.00', 'P-0000000001', 'PRJ-0000000001', 'E-0000000001');

-- --------------------------------------------------------

--
-- Table structure for table `period_table`
--

CREATE TABLE IF NOT EXISTS `period_table` (
  `period_ID` varchar(12) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `week_num` int(2) NOT NULL,
  `month` varchar(9) NOT NULL,
  `year` year(4) NOT NULL,
  PRIMARY KEY (`period_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `period_table`
--

INSERT INTO `period_table` (`period_ID`, `start_date`, `end_date`, `week_num`, `month`, `year`) VALUES
('P-0000000001', '2014-03-10', '2014-03-15', 11, 'March', 2014);

-- --------------------------------------------------------

--
-- Table structure for table `projects_table`
--

CREATE TABLE IF NOT EXISTS `projects_table` (
  `project_ID` varchar(14) NOT NULL,
  `project_name` varchar(256) NOT NULL,
  `project_location` varchar(256) NOT NULL,
  `project_status` varchar(10) NOT NULL,
  `project_lodging` decimal(5,2) NOT NULL,
  `project_net_pay` decimal(8,2) NOT NULL,
  PRIMARY KEY (`project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `projects_table`
--

INSERT INTO `projects_table` (`project_ID`, `project_name`, `project_location`, `project_status`, `project_lodging`, `project_net_pay`) VALUES
('PRJ-0000000001', 'HIS MAIN OFFICE', 'Address of HIS building', 'Ongoing', '0.00', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `user_accounts_table`
--

CREATE TABLE IF NOT EXISTS `user_accounts_table` (
  `user_ID` varchar(15) NOT NULL,
  `username` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `first_name` varchar(256) NOT NULL,
  `last_name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_accounts_table`
--

INSERT INTO `user_accounts_table` (`user_ID`, `username`, `password`, `first_name`, `last_name`) VALUES
('USER-00001', 'HISadmin', 'admin123', 'HIS', 'Administrator');

-- --------------------------------------------------------

--
-- Table structure for table `worker_office`
--

CREATE TABLE IF NOT EXISTS `worker_office` (
  `employee_ID` varchar(14) NOT NULL,
  `acct_number` varchar(20) NOT NULL,
  `cash_advance_balance` decimal(6,2) NOT NULL,
  `employee_type_ID` varchar(10) NOT NULL,
  PRIMARY KEY (`employee_ID`),
  KEY `employee_type_ID` (`employee_type_ID`),
  KEY `employee_type_ID_2` (`employee_type_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `worker_office`
--

INSERT INTO `worker_office` (`employee_ID`, `acct_number`, `cash_advance_balance`, `employee_type_ID`) VALUES
('E-0000000001', '123-456-789-101', '0.00', 'O');

-- --------------------------------------------------------

--
-- Table structure for table `worker_regular`
--

CREATE TABLE IF NOT EXISTS `worker_regular` (
  `employee_ID` varchar(14) NOT NULL,
  `acct_number` varchar(20) NOT NULL,
  `cash_advance_balance` decimal(6,2) NOT NULL,
  `employee_type_ID` varchar(10) NOT NULL,
  PRIMARY KEY (`employee_ID`),
  KEY `employee_type_ID` (`employee_type_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `worker_subcon`
--

CREATE TABLE IF NOT EXISTS `worker_subcon` (
  `employee_ID` varchar(14) NOT NULL,
  `company_name` varchar(256) DEFAULT NULL,
  `employee_type_ID` varchar(10) NOT NULL,
  PRIMARY KEY (`employee_ID`),
  KEY `employee_type_ID` (`employee_type_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `add_entry_table`
--
ALTER TABLE `add_entry_table`
  ADD CONSTRAINT `add_entry_table_ibfk_1` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`);

--
-- Constraints for table `entry_salary_report`
--
ALTER TABLE `entry_salary_report`
  ADD CONSTRAINT `entry_salary_report_ibfk_1` FOREIGN KEY (`period_ID`) REFERENCES `period_table` (`period_ID`),
  ADD CONSTRAINT `entry_salary_report_ibfk_2` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`),
  ADD CONSTRAINT `entry_salary_report_ibfk_3` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`),
  ADD CONSTRAINT `entry_salary_report_ibfk_4` FOREIGN KEY (`AE_ID`) REFERENCES `add_entry_table` (`AE_ID`);

--
-- Constraints for table `entry_timesheet`
--
ALTER TABLE `entry_timesheet`
  ADD CONSTRAINT `entry_timesheet_ibfk_1` FOREIGN KEY (`period_ID`) REFERENCES `period_table` (`period_ID`),
  ADD CONSTRAINT `entry_timesheet_ibfk_2` FOREIGN KEY (`project_ID`) REFERENCES `projects_table` (`project_ID`),
  ADD CONSTRAINT `entry_timesheet_ibfk_3` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`);

--
-- Constraints for table `worker_office`
--
ALTER TABLE `worker_office`
  ADD CONSTRAINT `worker_office_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`),
  ADD CONSTRAINT `worker_office_ibfk_2` FOREIGN KEY (`employee_type_ID`) REFERENCES `employee_table` (`employee_type_ID`);

--
-- Constraints for table `worker_regular`
--
ALTER TABLE `worker_regular`
  ADD CONSTRAINT `worker_regular_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`),
  ADD CONSTRAINT `worker_regular_ibfk_2` FOREIGN KEY (`employee_type_ID`) REFERENCES `employee_table` (`employee_type_ID`);

--
-- Constraints for table `worker_subcon`
--
ALTER TABLE `worker_subcon`
  ADD CONSTRAINT `worker_subcon_ibfk_1` FOREIGN KEY (`employee_ID`) REFERENCES `employee_table` (`employee_ID`),
  ADD CONSTRAINT `worker_subcon_ibfk_2` FOREIGN KEY (`employee_type_ID`) REFERENCES `employee_table` (`employee_type_ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
