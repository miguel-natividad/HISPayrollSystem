-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 08, 2014 at 01:02 AM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `his_payroll_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `additional_entry`
--

CREATE TABLE IF NOT EXISTS `additional_entry` (
  `AE_name` varchar(255) NOT NULL,
  `AE_rate` decimal(7,2) NOT NULL,
  `rate_type` varchar(10) NOT NULL,
  `employee_position` varchar(255) NOT NULL,
  `SRE_id` varchar(14) NOT NULL,
  `project_id` varchar(14) NOT NULL,
  KEY `SRE_id` (`SRE_id`),
  KEY `project_id` (`project_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE IF NOT EXISTS `employee` (
  `employee_id` varchar(12) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `mi` varchar(255) NOT NULL,
  `employee_position` varchar(255) NOT NULL,
  `employee_type` varchar(25) NOT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_id`, `last_name`, `first_name`, `mi`, `employee_position`, `employee_type`) VALUES
('E-0000000001', 'Natividad', 'Miguel', 'B', 'Manager', 'office worker'),
('E-0000000002', 'Laurente', 'Cheng', 'M', 'Manager', 'office worker'),
('E-0000000003', 'Go', 'Jourdan', 'D', 'Manager', 'office worker'),
('E-0000000004', 'Samson', 'Stuart', 'M', 'Manager', 'office worker'),
('E-0000000005', 'Bautista', 'Denise', 'O', 'Manager', 'office worker'),
('E-0000000006', 'Patron', 'Miguel', 'A', 'Head Plumber', 'regular worker'),
('E-0000000007', 'Marquez-Lim', 'Joshua', 'B', 'Head Welder', 'regular worker'),
('E-0000000008', 'Alcantara', 'Paulo', 'C', 'Head Carpenter', 'regular worker'),
('E-0000000009', 'Reyes', 'Justin', 'D', 'Head Electrician', 'regular worker'),
('E-0000000010', 'Torres', 'Keith', 'E', 'Head Technician', 'regular worker'),
('E-0000000011', 'Chan Pinco', 'Gio', 'A', 'Carpenter', 'sub-contracted worker'),
('E-0000000012', 'Pulmano', 'Christian', 'B', 'Carpenter', 'sub-contracted worker'),
('E-0000000013', 'Caluag', 'Jay', 'C', 'Carpenter', 'sub-contracted worker'),
('E-0000000014', 'Campos', 'Althea', 'D', 'Carpenter', 'sub-contracted worker'),
('E-0000000015', 'Chua', 'Diane', 'E', 'Carpenter', 'sub-contracted worker'),
('E-0000000016', 'Ong', 'Meg', 'F', 'Carpenter', 'sub-contracted worker'),
('E-0000000017', 'Mallari', 'Eyana', 'G', 'Carpenter', 'sub-contracted worker'),
('E-0000000018', 'Fernandez', 'Alyssa', 'H', 'Carpenter', 'sub-contracted worker'),
('E-0000000019', 'Agloro', 'Paolo', 'I', 'Carpenter', 'sub-contracted worker'),
('E-0000000020', 'De Vera', 'Jal', 'J', 'Carpenter', 'sub-contracted worker');

-- --------------------------------------------------------

--
-- Table structure for table `HDMF`
--

CREATE TABLE IF NOT EXISTS `HDMF` (
  `HDMF_id` int(11) NOT NULL,
  `low_range` decimal(6,2) NOT NULL,
  `high_range` decimal(6,2) NOT NULL,
  `HDMF_multiplier` decimal(3,2) NOT NULL,
  PRIMARY KEY (`HDMF_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `office_worker`
--

CREATE TABLE IF NOT EXISTS `office_worker` (
  `O-employee_id` varchar(12) NOT NULL,
  `account_number` varchar(19) NOT NULL,
  `remaining_cash_advance` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`O-employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `PHIC`
--

CREATE TABLE IF NOT EXISTS `PHIC` (
  `PHIC_id` varchar(15) NOT NULL,
  `low_range` decimal(7,2) NOT NULL,
  `high_range` decimal(7,2) NOT NULL,
  `PHIC_base_salary` decimal(9,2) NOT NULL,
  `PHIC_total_premium` decimal(7,2) NOT NULL,
  `PHIC_employee_share` decimal(7,2) NOT NULL,
  PRIMARY KEY (`PHIC_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `project`
--

CREATE TABLE IF NOT EXISTS `project` (
  `project_id` varchar(14) NOT NULL,
  `project_name` varchar(255) NOT NULL,
  `project_location` varchar(255) NOT NULL,
  `project_status` varchar(10) NOT NULL,
  `net_pay_project` decimal(8,2) DEFAULT NULL,
  `lodging_allowance` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`project_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `project`
--

INSERT INTO `project` (`project_id`, `project_name`, `project_location`, `project_status`, `net_pay_project`, `lodging_allowance`) VALUES
('PRJ-0000000000', 'HIS', 'HIS HQ', 'Ongoing', NULL, NULL),
('PRJ-0000000001', 'Ateneo', '123 Katipunan Jump Street', 'Ongoing', NULL, NULL),
('PRJ-0000000002', 'LaSalle', '123 Taft Avenue', 'Ongoing', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `regular_worker`
--

CREATE TABLE IF NOT EXISTS `regular_worker` (
  `R-employee_id` varchar(12) NOT NULL,
  `account_number` varchar(19) NOT NULL,
  `remaining_cash_advance` decimal(7,2) DEFAULT NULL,
  PRIMARY KEY (`R-employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `salary_report_entry`
--

CREATE TABLE IF NOT EXISTS `salary_report_entry` (
  `SRE_id` varchar(14) NOT NULL,
  `basic` decimal(7,2) NOT NULL,
  `cola` decimal(7,2) NOT NULL,
  `allow` decimal(7,2) DEFAULT NULL,
  `overtime_rate` decimal(7,2) NOT NULL,
  `undertime_rate` decimal(7,2) NOT NULL,
  `net_pay_total` decimal(7,2) NOT NULL,
  `deduction_fixed` decimal(7,2) DEFAULT NULL,
  `payment_type` varchar(4) NOT NULL,
  `period_id` varchar(12) NOT NULL,
  `project_id` varchar(14) NOT NULL,
  `employee_id` varchar(12) NOT NULL,
  PRIMARY KEY (`SRE_id`),
  KEY `period_id` (`period_id`,`project_id`,`employee_id`),
  KEY `employee_id` (`employee_id`),
  KEY `project_id` (`project_id`),
  KEY `period_id_2` (`period_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `SSS`
--

CREATE TABLE IF NOT EXISTS `SSS` (
  `SSS_id` varchar(14) NOT NULL,
  `low_range` decimal(7,2) NOT NULL,
  `high_range` decimal(7,2) NOT NULL,
  `SSS_base_credit` decimal(9,2) NOT NULL,
  `SSS_total_contribution` decimal(7,2) NOT NULL,
  `SSS_employee_share` decimal(7,2) NOT NULL,
  PRIMARY KEY (`SSS_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `sub_contracted_worker`
--

CREATE TABLE IF NOT EXISTS `sub_contracted_worker` (
  `S-employee_id` varchar(12) NOT NULL,
  `company_name` varchar(255) NOT NULL,
  PRIMARY KEY (`S-employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `timesheet_entry`
--

CREATE TABLE IF NOT EXISTS `timesheet_entry` (
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `in_morning` time NOT NULL,
  `out_morning` time NOT NULL,
  `in_afternoon` time NOT NULL,
  `out_afternoon` time NOT NULL,
  `in_ot` time DEFAULT NULL,
  `out_ot` time DEFAULT NULL,
  `total_hours` decimal(3,2) NOT NULL,
  `undertime` decimal(3,2) DEFAULT NULL,
  `overtime` decimal(3,2) DEFAULT NULL,
  `period_id` varchar(12) NOT NULL,
  `project_id` varchar(14) NOT NULL,
  `employee_id` varchar(12) NOT NULL,
  KEY `period_id` (`period_id`),
  KEY `project_id` (`project_id`),
  KEY `employee_id` (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `time_period`
--

CREATE TABLE IF NOT EXISTS `time_period` (
  `period_id` varchar(12) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL,
  `week_num` int(2) NOT NULL,
  `month` varchar(9) NOT NULL,
  `year` year(4) NOT NULL,
  PRIMARY KEY (`period_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `time_period`
--

INSERT INTO `time_period` (`period_id`, `start_date`, `end_date`, `week_num`, `month`, `year`) VALUES
('P-0000000001', '2014-01-06', '2014-01-11', 2, 'January', 2014),
('P-0000000002', '2014-01-13', '2014-01-18', 2, 'January', 2014);

-- --------------------------------------------------------

--
-- Table structure for table `user_table`
--

CREATE TABLE IF NOT EXISTS `user_table` (
  `username` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `first_name` varchar(256) NOT NULL,
  `last_name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `WTAX`
--

CREATE TABLE IF NOT EXISTS `WTAX` (
  `WTAX_id` varchar(15) NOT NULL,
  `employee_status` varchar(5) NOT NULL,
  `boundary` varchar(20) NOT NULL,
  `tax_value` decimal(7,2) NOT NULL,
  PRIMARY KEY (`WTAX_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `additional_entry`
--
ALTER TABLE `additional_entry`
  ADD CONSTRAINT `ae_PRJ` FOREIGN KEY (`project_id`) REFERENCES `project` (`project_id`),
  ADD CONSTRAINT `ae_SRE` FOREIGN KEY (`SRE_id`) REFERENCES `salary_report_entry` (`SRE_id`);

--
-- Constraints for table `salary_report_entry`
--
ALTER TABLE `salary_report_entry`
  ADD CONSTRAINT `are_EMP` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`),
  ADD CONSTRAINT `sre_P` FOREIGN KEY (`period_id`) REFERENCES `time_period` (`period_id`),
  ADD CONSTRAINT `sre_PRJ` FOREIGN KEY (`project_id`) REFERENCES `project` (`project_id`);

--
-- Constraints for table `timesheet_entry`
--
ALTER TABLE `timesheet_entry`
  ADD CONSTRAINT `tse_EMP` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`),
  ADD CONSTRAINT `tse_P` FOREIGN KEY (`period_id`) REFERENCES `time_period` (`period_id`),
  ADD CONSTRAINT `tse_PRJ` FOREIGN KEY (`project_id`) REFERENCES `project` (`project_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
