/*
Navicat MySQL Data Transfer

Source Server         : MySql_localhost
Source Server Version : 50621
Source Host           : 127.0.0.1:3306
Source Database       : ims

Target Server Type    : MYSQL
Target Server Version : 50621
File Encoding         : 65001

Date: 2016-06-05 23:11:16
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for category
-- ----------------------------
DROP TABLE IF EXISTS `category`;
CREATE TABLE `category` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of category
-- ----------------------------
INSERT INTO `category` VALUES ('1', 'MOTHERBOARD');
INSERT INTO `category` VALUES ('2', 'NETWORK ACCESSORIES');

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(255) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES ('1', 'DefaultCustomer0000000001', 'Skynet Computers', '0000000000', 'customer@skynetcomputers.com');
INSERT INTO `customer` VALUES ('2', 'DefaultCustomer0000000001', 'Skynet Computers', '0000000000', 'customer@skynetcomputers.com');
INSERT INTO `customer` VALUES ('4', 'DefaultCustomer0000000001', 'Skynet Computers', '0000000000', 'customer@skynetcomputers.com');
INSERT INTO `customer` VALUES ('5', 'John Paul Lalruatfela', 'Chaltlang', '123456', '');
INSERT INTO `customer` VALUES ('6', 'Benjamin Lalmuanawma', 'Falklang', '123456789', '');
INSERT INTO `customer` VALUES ('9', 'DefaultCustomer0000000001', 'Skynet Computers', '0000000000', 'customer@skynetcomputers.com');
INSERT INTO `customer` VALUES ('10', 'DefaultCustomer0000000001', 'Skynet Computers', '0000000000', 'customer@skynetcomputers.com');
INSERT INTO `customer` VALUES ('11', 'Lalfakzuala Hmar', 'College Veng', '8014125857', '');
INSERT INTO `customer` VALUES ('12', 'NetSurf Internet Service', 'Chanmari, Aizawl', '123456789', '');
INSERT INTO `customer` VALUES ('13', 'Zothan Auto', 'Aizawl', '123456789', '');
INSERT INTO `customer` VALUES ('14', 'Nextcomm', 'Khatla', '12313123', '');
INSERT INTO `customer` VALUES ('15', 'Xohmaa Pachuau', 'Bawngkawn', '12313123', '');

-- ----------------------------
-- Table structure for customeraccount
-- ----------------------------
DROP TABLE IF EXISTS `customeraccount`;
CREATE TABLE `customeraccount` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) NOT NULL,
  `TransDate` date NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Debit` double(255,0) NOT NULL,
  `Credit` double(255,0) NOT NULL,
  `Balance` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `CustomerID` (`CustomerID`),
  CONSTRAINT `fk_cac_cus` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customeraccount
-- ----------------------------
INSERT INTO `customeraccount` VALUES ('10', '5', '2016-06-04', 'SKYNET/RI/16-17/0001', '2000', '2000', '0');
INSERT INTO `customeraccount` VALUES ('11', '6', '2016-06-04', 'SKYNET/RI/16-17/0002', '10000', '10000', '0');
INSERT INTO `customeraccount` VALUES ('12', '5', '2016-06-04', 'SKYNET/RI/16-17/0002', '950', '950', '0');
INSERT INTO `customeraccount` VALUES ('13', '5', '2016-06-04', 'SKYNET/RI/16-17/0003', '10000', '8000', '2000');
INSERT INTO `customeraccount` VALUES ('14', '5', '2016-06-04', 'Credit Payment', '0', '2000', '0');
INSERT INTO `customeraccount` VALUES ('15', '6', '2016-06-04', 'SKYNET/RI/16-17/0004', '650', '500', '150');
INSERT INTO `customeraccount` VALUES ('16', '5', '2016-06-03', 'SKYNET/RI/16-17/0005', '4000', '3000', '1000');

-- ----------------------------
-- Table structure for product
-- ----------------------------
DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ProductCode` varchar(255) DEFAULT NULL,
  `SupplierID` int(11) DEFAULT NULL,
  `CategoryID` int(11) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `BuyingValue` double(255,0) NOT NULL,
  `SellingValue` double(255,0) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `BarCode` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `CategoryID` (`CategoryID`),
  CONSTRAINT `fk_prd_cat` FOREIGN KEY (`CategoryID`) REFERENCES `category` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of product
-- ----------------------------
INSERT INTO `product` VALUES ('1', 'ff7bf641-a3f0-401a-984e-eef3bad99a83', '1', '1', 'GIGABYTE G1 SNIPER B7', '8400', '10000', '0', 'SN160800077771');
INSERT INTO `product` VALUES ('2', '4c8821c5-48db-423c-91f4-6a0a9f32a056', '1', '1', 'GIGABYTE H61M-DS2', '3255', '4000', '0', 'SN153840028311');
INSERT INTO `product` VALUES ('3', null, '1', '1', 'GIGABYTE G1 SNIPER B7', '8400', '10000', '0', 'SN160800077772');
INSERT INTO `product` VALUES ('4', 'b4ec0945-738e-4479-9b21-42acd8ba0752', '5', '2', 'D-LINK DES-1005C 5-Port Switch', '460', '650', '0', 'QS7K1G2007526');
INSERT INTO `product` VALUES ('5', '0c9567a7-e888-438b-873b-e95c07cbbb55', '5', '2', 'D-LINK DES-1005C 5-Port Switch', '460', '650', '0', 'QS7K1G2007522');
INSERT INTO `product` VALUES ('6', '9a6aa551-adac-4a36-b265-9c932926a953', '5', '2', 'D-LINK DES-1005C 5-Port Switch', '460', '650', '0', 'QS7K1G2007545');
INSERT INTO `product` VALUES ('7', '584c0c86-a2c1-43df-aa3c-7ca512371f5c', '5', '2', 'D-LINK DES-1008C 8-Port Switch', '650', '950', '0', 'QS7L1G1000705');
INSERT INTO `product` VALUES ('8', 'ee76221c-f077-4ec1-ac0f-b2f344de2cc3', '5', '2', 'D-LINK DES-1008C 8-Port Switch', '650', '950', '0', 'QS7L1G1000712');
INSERT INTO `product` VALUES ('9', '16595a6a-6485-4187-b0bc-92d93968956c', '5', '2', 'D-LINK DES-1008C 8-Port Switch', '650', '950', '0', 'QS7L1G1000713');

-- ----------------------------
-- Table structure for purchase
-- ----------------------------
DROP TABLE IF EXISTS `purchase`;
CREATE TABLE `purchase` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `InvoiceNo` varchar(50) NOT NULL,
  `PurchaseDate` date NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `Amount` double(255,0) NOT NULL,
  `Payment` double(255,0) NOT NULL,
  `Balance` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_pur_pdt_idx` (`InvoiceNo`),
  KEY `fk_pur_sup_idx` (`SupplierID`),
  CONSTRAINT `fk_pur_sup` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchase
-- ----------------------------
INSERT INTO `purchase` VALUES ('1', 'SKYNET/RI/16-17/0001', '2016-06-04', '1', '11655', '11655', '0');
INSERT INTO `purchase` VALUES ('2', 'SKYNET/RI/16-17/0001', '2016-06-04', '1', '11655', '11655', '0');
INSERT INTO `purchase` VALUES ('3', 'SKYNET/RI/16-17/0001', '2016-06-04', '1', '11655', '11655', '0');
INSERT INTO `purchase` VALUES ('4', 'SKYNET/RI/16-17/0001', '2016-06-04', '5', '3330', '3330', '0');

-- ----------------------------
-- Table structure for purchasedetail
-- ----------------------------
DROP TABLE IF EXISTS `purchasedetail`;
CREATE TABLE `purchasedetail` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `InvoiceNo` varchar(255) NOT NULL,
  `ProductCode` varchar(255) DEFAULT NULL,
  `Quantity` int(255) NOT NULL,
  `BuyingValue` double(255,0) NOT NULL,
  `SellingValue` double(255,0) NOT NULL,
  `Amount` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_pdt_pur_idx` (`InvoiceNo`),
  CONSTRAINT `fk_pdt_pur` FOREIGN KEY (`InvoiceNo`) REFERENCES `purchase` (`InvoiceNo`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purchasedetail
-- ----------------------------
INSERT INTO `purchasedetail` VALUES ('1', 'SKYNET/RI/16-17/0001', 'c9d6813b-63d7-4b04-a7cd-0d999bc7a445', '1', '8400', '10000', '8400');
INSERT INTO `purchasedetail` VALUES ('2', 'SKYNET/RI/16-17/0001', 'ff7bf641-a3f0-401a-984e-eef3bad99a83', '1', '8400', '10000', '8400');
INSERT INTO `purchasedetail` VALUES ('3', 'SKYNET/RI/16-17/0001', '4c8821c5-48db-423c-91f4-6a0a9f32a056', '1', '3255', '4000', '3255');
INSERT INTO `purchasedetail` VALUES ('4', 'SKYNET/RI/16-17/0001', 'b4ec0945-738e-4479-9b21-42acd8ba0752', '1', '460', '650', '460');
INSERT INTO `purchasedetail` VALUES ('5', 'SKYNET/RI/16-17/0001', '0c9567a7-e888-438b-873b-e95c07cbbb55', '1', '460', '650', '460');
INSERT INTO `purchasedetail` VALUES ('6', 'SKYNET/RI/16-17/0001', '9a6aa551-adac-4a36-b265-9c932926a953', '1', '460', '650', '460');
INSERT INTO `purchasedetail` VALUES ('7', 'SKYNET/RI/16-17/0001', '584c0c86-a2c1-43df-aa3c-7ca512371f5c', '1', '650', '950', '650');
INSERT INTO `purchasedetail` VALUES ('8', 'SKYNET/RI/16-17/0001', 'ee76221c-f077-4ec1-ac0f-b2f344de2cc3', '1', '650', '950', '650');
INSERT INTO `purchasedetail` VALUES ('9', 'SKYNET/RI/16-17/0001', '16595a6a-6485-4187-b0bc-92d93968956c', '1', '650', '950', '650');

-- ----------------------------
-- Table structure for sale
-- ----------------------------
DROP TABLE IF EXISTS `sale`;
CREATE TABLE `sale` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `InvoiceNo` varchar(50) NOT NULL,
  `SaleDate` date NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `Amount` double(255,0) NOT NULL,
  `Discount` double(255,0) NOT NULL,
  `Payment` double(255,0) NOT NULL,
  `Balance` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `CustomerID` (`CustomerID`),
  KEY `fk_sls_sdt_idx` (`InvoiceNo`),
  CONSTRAINT `fk_sls_cus` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sale
-- ----------------------------
INSERT INTO `sale` VALUES ('14', 'SKYNET/RI/16-17/0001', '2016-06-01', '5', '2250', '250', '2000', '0');
INSERT INTO `sale` VALUES ('15', 'SKYNET/RI/16-17/0002', '2016-06-02', '6', '10000', '0', '10000', '0');
INSERT INTO `sale` VALUES ('16', 'SKYNET/QS/16-17/0001', '2016-06-04', '10', '950', '0', '950', '0');
INSERT INTO `sale` VALUES ('17', 'SKYNET/RI/16-17/0002', '2016-06-04', '5', '950', '0', '950', '0');
INSERT INTO `sale` VALUES ('18', 'SKYNET/RI/16-17/0003', '2016-06-04', '5', '10000', '0', '8000', '2000');
INSERT INTO `sale` VALUES ('19', 'SKYNET/RI/16-17/0004', '2016-06-04', '6', '650', '0', '500', '150');
INSERT INTO `sale` VALUES ('20', 'SKYNET/RI/16-17/0005', '2016-06-03', '5', '4000', '0', '3000', '1000');
INSERT INTO `sale` VALUES ('21', 'SKYNET/SV/16-17/0001', '2016-06-04', '10', '2000', '0', '2000', '0');

-- ----------------------------
-- Table structure for saledetail
-- ----------------------------
DROP TABLE IF EXISTS `saledetail`;
CREATE TABLE `saledetail` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `InvoiceNo` varchar(50) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `BuyingValue` double(255,0) NOT NULL,
  `SellingValue` double(255,0) NOT NULL,
  `Amount` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `sk_sls_sdt_idx` (`InvoiceNo`),
  KEY `fk_sdt_prd_idx` (`ProductID`),
  CONSTRAINT `fk_sdt_prd` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_sdt_sls` FOREIGN KEY (`InvoiceNo`) REFERENCES `sale` (`InvoiceNo`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of saledetail
-- ----------------------------
INSERT INTO `saledetail` VALUES ('29', 'SKYNET/RI/16-17/0001', '4', '1', '460', '650', '650');
INSERT INTO `saledetail` VALUES ('30', 'SKYNET/RI/16-17/0001', '5', '1', '460', '650', '650');
INSERT INTO `saledetail` VALUES ('31', 'SKYNET/RI/16-17/0001', '7', '1', '650', '950', '950');
INSERT INTO `saledetail` VALUES ('32', 'SKYNET/RI/16-17/0002', '3', '1', '8400', '10000', '10000');
INSERT INTO `saledetail` VALUES ('33', 'SKYNET/QS/16-17/0001', '9', '1', '650', '950', '950');
INSERT INTO `saledetail` VALUES ('34', 'SKYNET/RI/16-17/0002', '8', '1', '650', '950', '950');
INSERT INTO `saledetail` VALUES ('35', 'SKYNET/RI/16-17/0003', '1', '1', '8400', '10000', '10000');
INSERT INTO `saledetail` VALUES ('36', 'SKYNET/RI/16-17/0004', '6', '1', '460', '650', '650');
INSERT INTO `saledetail` VALUES ('37', 'SKYNET/RI/16-17/0005', '2', '1', '3255', '4000', '4000');

-- ----------------------------
-- Table structure for service
-- ----------------------------
DROP TABLE IF EXISTS `service`;
CREATE TABLE `service` (
  `ID` int(11) NOT NULL,
  `InvoiceNo` varchar(50) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Amount` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_srv_sls` (`InvoiceNo`),
  CONSTRAINT `fk_srv_sls` FOREIGN KEY (`InvoiceNo`) REFERENCES `sale` (`InvoiceNo`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of service
-- ----------------------------

-- ----------------------------
-- Table structure for supplier
-- ----------------------------
DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierName` varchar(255) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of supplier
-- ----------------------------
INSERT INTO `supplier` VALUES ('1', 'HI-TECH DISCOVERY', 'GUWAHATI', '9436143704', '');
INSERT INTO `supplier` VALUES ('2', 'COMPUTER HOUSE', 'MILLENIUM CENTRE, AIZAWL', '2306771', '');
INSERT INTO `supplier` VALUES ('3', 'LYNX TECHNOLOGIES', 'SILCHAR, ASSAM', '9435073116', '');
INSERT INTO `supplier` VALUES ('4', 'COMPUTERS AND APPLIANCES', 'GUWAHATI', '9435074359', '');
INSERT INTO `supplier` VALUES ('5', 'CAFE DE NET', 'SILCHAR', '', '');

-- ----------------------------
-- Table structure for supplieraccount
-- ----------------------------
DROP TABLE IF EXISTS `supplieraccount`;
CREATE TABLE `supplieraccount` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) NOT NULL,
  `TransDate` date NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Debit` double(255,0) NOT NULL,
  `Credit` double(255,0) NOT NULL,
  `Balance` double(255,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_sac_sup_idx` (`SupplierID`),
  CONSTRAINT `fk_sac_sup` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of supplieraccount
-- ----------------------------
INSERT INTO `supplieraccount` VALUES ('1', '1', '2016-06-04', 'Invoice No SKYNET/RI/16-17/0001', '11655', '11655', '0');
INSERT INTO `supplieraccount` VALUES ('2', '1', '2016-06-04', 'Invoice No SKYNET/RI/16-17/0001', '11655', '11655', '0');
INSERT INTO `supplieraccount` VALUES ('3', '1', '2016-06-04', 'Invoice No SKYNET/RI/16-17/0001', '11655', '11655', '0');
INSERT INTO `supplieraccount` VALUES ('4', '5', '2016-06-04', 'Invoice No SKYNET/RI/16-17/0001', '3330', '3330', '0');
