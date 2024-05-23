-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2024, 21:05:24
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `demırbasuygl`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kasa_bilgileri`
--

CREATE TABLE `kasa_bilgileri` (
  `id` int(11) NOT NULL,
  `kasa_demirbas_no` varchar(255) DEFAULT NULL,
  `calisan_sicil_no` varchar(255) DEFAULT NULL,
  `isletim_sistemi` varchar(255) DEFAULT NULL,
  `islemci_marka_model` varchar(255) DEFAULT NULL,
  `ram` varchar(255) DEFAULT NULL,
  `sabit_disk_kapasitesi` varchar(255) DEFAULT NULL,
  `ekran_karti` varchar(255) DEFAULT NULL,
  `pc_model` varchar(255) DEFAULT NULL,
  `islemci_hizi` varchar(255) DEFAULT NULL,
  `cekirdek_sayisi` varchar(255) DEFAULT NULL,
  `monitor_boyutu` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kasa_bilgileri`
--

INSERT INTO `kasa_bilgileri` (`id`, `kasa_demirbas_no`, `calisan_sicil_no`, `isletim_sistemi`, `islemci_marka_model`, `ram`, `sabit_disk_kapasitesi`, `ekran_karti`, `pc_model`, `islemci_hizi`, `cekirdek_sayisi`, `monitor_boyutu`) VALUES
(1, '1', '1', 'test', 'test', '1', '1', 'test', 'test', '1', '1', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odev`
--

CREATE TABLE `odev` (
  `kullanici` varchar(255) NOT NULL,
  `sifre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `odev`
--

INSERT INTO `odev` (`kullanici`, `sifre`) VALUES
('admin', 1234);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odev2`
--

CREATE TABLE `odev2` (
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `dogum` int(11) NOT NULL,
  `ise_baslama` int(11) NOT NULL,
  `eposta` varchar(255) NOT NULL,
  `odanumarasi` int(11) NOT NULL,
  `unvan` varchar(255) NOT NULL,
  `notlar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `odev2`
--

INSERT INTO `odev2` (`ad`, `soyad`, `dogum`, `ise_baslama`, `eposta`, `odanumarasi`, `unvan`, `notlar`) VALUES
('test', 'test', 2023, 2020, 'test@gmail.com', 1, 'Yönetici', 'test');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odev3`
--

CREATE TABLE `odev3` (
  `marka` varchar(255) NOT NULL,
  `model` varchar(255) NOT NULL,
  `aciklama` varchar(255) NOT NULL,
  `Verilme_tarihi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `odev3`
--

INSERT INTO `odev3` (`marka`, `model`, `aciklama`, `Verilme_tarihi`) VALUES
('test', 'test', 'test', 2020);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kasa_bilgileri`
--
ALTER TABLE `kasa_bilgileri`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kasa_bilgileri`
--
ALTER TABLE `kasa_bilgileri`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
