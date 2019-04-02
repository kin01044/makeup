-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: makeup
-- ------------------------------------------------------
-- Server version	5.1.41-community

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
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `cid` int(8) NOT NULL,
  `cusname` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cusage` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cuscall` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cusmail` varchar(20) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`cid`),
  KEY `cid_index` (`cid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `makeupd`
--

DROP TABLE IF EXISTS `makeupd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `makeupd` (
  `mid` int(8) NOT NULL,
  `makeupsort` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `makeupname` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `makeupuse` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `makeupprice` int(8) DEFAULT NULL,
  `makeupvol` int(8) DEFAULT NULL,
  `makeupskin` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `makeupfab` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `makeupudate` int(8) DEFAULT NULL,
  `makeuping` varchar(500) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`mid`),
  KEY `mid_index` (`mid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `makeupd`
--

LOCK TABLES `makeupd` WRITE;
/*!40000 ALTER TABLE `makeupd` DISABLE KEYS */;
INSERT INTO `makeupd` VALUES (1,'스킨','포레스트 포맨 그루밍 필링 토너','기타',14000,200,'모든피부','한국콜마(주)',36,'정제수, 프로판디올, 1,2-헥산디올, 트레할로스, 마치현추출물, 느릅나무뿌리추출물, 윈터그린잎추출물, 줄맨드라미씨추출물, 삼나무잎추출물, 녹나무잎추출물, 클러스터소나무껍질/싹추출물, 편백수, 글리세린, 베타인, 부틸렌글라이콜, C12-14파레스-12, 소듐시트레이트, 시트릭애씨드, 디소듐이디티에이, 토코페롤, 에칠헥실글리세린, 페녹시에탄올'),(2,'스킨','포레스트 포맨 오일 컨트롤 스킨','지성',19000,180,'모든피부','(주)코스비전',36,'정제수, 에탄올, 트레할로스, 글리세린,베타인, 옥틸도데세스-16, 피이지-60하이드로제네이티드캐스터오일, 에칠헥실글리세린, 디소듐이디티에이, 향료, 부틸렌글라이콜, 박하잎추출물, 녹차추출물, 귤껍질추출물, 백년초열매추출물, 난추출물, 동백나무잎추출물, 페녹시에탄올, 1,2-헥산디올, 녹나무잎추출물, 클러스터소나무껍질/싹추출물, 편백수, 삼나무잎추출물, 토코페롤'),(3,'스킨','포레스트 포맨 모이스처 스킨','건성',19000,180,'모든피부','(주)코스비전',36,'정제수, 부틸렌글라이콜, 프로판디올, 트리에칠헥사노인, 녹차추출물, 편백수, 삼나무잎추출물, 클러스터소나무껍질/싹추출물, 동백나무잎추출물, 백년초열매추출물, 난추출물, 귤껍질추출물, 녹나무잎추출물, 트레할로스, 1,2-헥산디올, 디메치콘, 스쿠알란, 피이지-60글리세릴이소스테아레이트, 글리세릴스테아레이트, 피이지-20글리세릴이소스테아레이트, 세테아릴알코올, 스테아릭애씨드, 팔미틱애씨드, 에칠헥실글리세린, 낫토검, 디소듐이디티에이, 포타슘하이드록사이드, 향료'),(4,'스킨','포레스트 포맨 프레시 스킨','중성/복합성',19000,180,'모든피부','(주)코스비전',36,'정제수, 에탄올, 디프로필렌글라이콜, 녹차추출물, 편백수, 삼나무잎추출물, 클러스터소나무껍질/싹추출물, 동백나무잎추출물, 백년초열매추출물, 난추출물, 귤껍질추출물, 녹나무잎추출물, 글리세린, 피이지/피피지-17/6코폴리머, 피이지-60하이드로제네이티드캐스터오일, 옥틸도데세스-16, 베타인, 디소듐이디티에이, 에칠헥실글리세린, 페녹시에탄올, 향료'),(5,'스킨','포레스트 포맨 프리미엄 스킨','지성',25000,180,'모든피부','(주)코스비전',36,'삼나무잎추출물, 프로판디올, 에탄올, 글리세레스-26, 피이지/피피지-17/6코폴리머, 글리세린, 알부틴, 귤껍질추출물, 난추출물, 녹차추출물, 동백나무잎추출물, 백년초열매추출물, 흰목이버섯추출물, 아스코빌글루코사이드, 하이알루로닉애씨드, 세라마이드3, 아데노신, 부틸렌글라이콜, 디메치콘, 비스-피이지-18메칠에텔디메칠실란, 소듐메칠스테아로일타우레이트, 정제수, 피이지-60하이드로제네이티드캐스터오일, 하이드로제네이티드레시틴, 잔탄검, 하이드록시에칠아크릴레이트/소듐아크릴로일디메칠타우레이트코폴리머, 아크릴레이트/스테아릴메타크릴레이트코폴리머, 페녹시에탄올, 디소듐이디티에이, 향료'),(6,'스킨','그린티 스킨 포맨','수분',15000,150,'모든피부','(주)코스비전',36,'정제수, 에탄올, 부틸렌글라이콜, 녹차추출물30mg, 귤껍질추출물, 백년초열매추출물, 난추출물, 동백나무잎추출물, 대나무추출물, 삼나무잎추출물, 피이지/피피지-17/6코폴리머, 옥틸도데세스-16, 피이지-60하이드로제네이티드캐스터오일, 글리세린, 에칠헥실글리세린, 디소듐이디티에이, 페녹시에탄올, 향료'),(7,'스킨','올리브 리얼 스킨 포맨','보습',17000,150,'모든피부','(주)코스비전',36,'정제수, 에탄올, 글리세린, 올리브오일, 녹차추출물, 귤껍질추출물, 백년초열매추출물, 난추출물, 동백나무잎추출물, 삼나무잎추출물, 대나무추출물, 베타-글루칸, 토코페릴아세테이트, 베타인, 부틸렌글라이콜, 바이오사카라이드검-1, 피이지/피피지-17/6코폴리머, 비스-피 이지-18메칠에텔디메칠실란, 글리세릴폴리메타크릴레이트, 피이지-60하이드로제네이티드캐스터오일, 프로판디올, 셀룰로 오스검, 에칠헥실글리세린, 카보머, 포타슘하이드록사이드, 디소듐이디티에이, 페녹시에탄올, 향료'),(8,'에센스/크림','포레스트 포맨 오일 컨트롤 올인원 에센스','지성',25000,100,'모든피부','(주)코스비전',36,'정제수, 부틸렌글라이콜, 에탄올, 폴리소르베이트20, 옥틸도데세스-16, 실리카, 트로메타민, 아크릴레이트/C10-30알킬아크릴레이트크로스폴리머, 글리세린, 향료, 살리실릭애씨드, 에칠헥실글리세린, 녹차추출물, 귤껍질추출물, 백년초열매추출물, 난추출물, 동백나무잎추출물, 디소듐이디티에이, 박하잎추출물, 1,2-헥산디올, 페녹시에탄올, 토코페롤, 녹나무잎추출물, 클러스터소나무껍질/싹추출물, 편백수, 삼나무잎추출물'),(9,'에센스/크림','포레스트 포맨 모이스처 올인원 에센스','건성',25000,100,'모든피부','(주)코스비전',36,'정제수, 글리세린, 프로판디올, 사이클로펜타실록산, 나이아신아마이드, 사이클로헥사실록산, 삼나무잎추출물, 편백수, 클러스터소나무껍질/싹추출물, 녹나무잎추출물, 글라이코프로테인, 귤껍질추출물, 난추출물, 녹차추출물, 동백나무잎추출물, 백년초열매추출물, 아데노신, 세테아릴올리베이트, 소르비탄올리베이트, 부틸렌글라이콜, 하이드록시프로필스타치포스페이트, 하이드록시에칠아크릴레이트/소듐아크릴로일디메칠타우레이트코폴리머, 아크릴레이트/C10-30알킬아크릴레이트크로스폴리머, 에칠헥실글리세린, 카올린, 폴리실리콘-11, 트로메타민, 디소듐이디티에이, 페녹시에탄올, 향료'),(10,'에센스/크림','포레스트 포맨 프레시 올인원 에센스','중성/복합성',25000,100,'모든피부','(주)코스비전',36,'정제수, 프로판디올, 바이오사카라이드검-1, 에탄올, 피이지/피피지-17/6코폴리머, 디에톡시에칠석시네이트, 녹차추출물, 귤껍질추출물, 백년초열매추출물, 난추출물, 동백나무잎추출물, 녹나무잎추출물, 클러스터소나무껍질/싹추출물, 삼나무잎추출물, 편백수, 징크글루코네이트, 카페인, 마로니에씨추출물, 사이클로펜타실록산, 하이드록시에칠아크릴레이트/소듐아크릴로일디메칠타우레이트코폴리머, 사이클로헥사실록산, 피이지-60하이드로제네이티드캐스터오일, 비스-피이지-18메칠에텔디메칠실란, 만니톨, 옥수수전분, 세테아릴알코올, 마이크로크리스탈린셀룰로오스, 글리세릴카프릴레이트, 하이드로제네이티드레시틴, 글리세릴스테아레이트, 에칠헥실글리세린, 스테아릭애씨드, 암모늄글리시리제이트, 폴리글리세릴-3메칠글루코오스디스테아레이트, 아크릴레이트/C10-30알킬아크릴레이트크로스폴리머, 트로메타민, 디소듐이디티에이, 향료, 크로뮴하이드록사이드그린'),(11,'에센스/크림','포레스트 포맨 프리미엄 세럼','지성',32000,50,'모든피부','(주)코스비전',36,'삼나무잎추출물, 프로판디올, 글리세레스-26, 사이클로펜타실록산, 알부틴, 사이클로헥사실록산, 귤껍질추출물, 난추출물, 녹차추출물, 동백나무잎추출물, 백년초열매추출물, 흰목이버섯추출물, 하이알루로닉애씨드, 글리세린, 부틸렌글라이콜, 세라마이드3, 아데노신, 아크릴레이트/스테아릴메타크릴레이트코폴리머, 에칠헥실글리세린, 잔탄검, 정제수, 판테놀, 폴리소르베이트20, 폴리아크릴레이트-13, 폴리이소부텐, 피이지-240/에이치디아이코폴리머비스-데실테트라데세스-20에텔, 디메치콘올, 페녹시에탄올, 향료'),(12,'에센스/크림','포레스트 포맨 프리미엄 크림','지성',30000,50,'모든피부','(주)코스비전',36,'삼나무잎추출물, 부틸렌글라이콜, 프로판디올, 디메치콘, 정제수, 쉐어버터, 디이소스테아릴말레이트, 알부틴, 카프릴릴메치콘, 페닐트리메치콘, 글리세린, 흰목이버섯추출물, 베타-글루칸, 세라마이드3, 하이알루로닉애씨드, 난추출물, 녹차추출물, 동백나무잎추출물, 백년초열매추출물, 귤껍질추출물, 아데노신, 나이아신아마이드, C12-20알킬글루코사이드, C14-22알코올, 글리세릴스테아레이트, 라우릭애씨드, 미리스틱애씨드, 베헤닐알코올, 세틸에칠헥사노에이트, 스테아릭애씨드, 아라키딜글루코사이드, 아라키딜알코올, 아크릴레이트/스테아릴메타크릴레이트코폴리머, 암모늄아크릴로일디메칠타우레이트/브이피코폴리머, 잔탄검, 카올린, 팔미틱애씨드, 피이지-100스테아레이트, 하이드록시에칠아크릴레이트/소듐아크릴로일디메칠타우레이트코폴리머, 디소듐이디티에이, 페녹시에탄올, 향료');
/*!40000 ALTER TABLE `makeupd` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `oid` int(8) NOT NULL,
  `mid` int(8) DEFAULT NULL,
  `cid` int(8) DEFAULT NULL,
  `ordernum` int(8) DEFAULT NULL,
  `ordersum` int(10) DEFAULT NULL,
  `orderday` date DEFAULT NULL,
  PRIMARY KEY (`oid`),
  KEY `mid` (`mid`),
  KEY `cid` (`cid`),
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`cid`) REFERENCES `customer` (`cid`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`mid`) REFERENCES `makeupd` (`mid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,NULL,3,42000,'2019-04-01');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stat`
--

DROP TABLE IF EXISTS `stat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stat` (
  `sid` int(8) NOT NULL,
  `statday` date DEFAULT NULL,
  `statsale` int(10) DEFAULT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stat`
--

LOCK TABLES `stat` WRITE;
/*!40000 ALTER TABLE `stat` DISABLE KEYS */;
/*!40000 ALTER TABLE `stat` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-02 11:31:34
