-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 27 Cze 2023, 19:31
-- Wersja serwera: 10.4.27-MariaDB
-- Wersja PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `projekt_inzynieria`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `antibiotics`
--

CREATE TABLE `antibiotics` (
  `id_antibiotic` int(11) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `description` varchar(230) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `type` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `prescription` tinyint(1) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `antibiotics`
--

INSERT INTO `antibiotics` (`id_antibiotic`, `name`, `price`, `description`, `type`, `prescription`, `user_id`) VALUES
(1, 'Abaktal', '11', 'Chemioterapeutyk z grupy fluorochinolonów.', 'Antybiotyk', 1, 1),
(2, 'Azibiot', '18', 'Lek przeciwbakteryjny do stosowania ogólnego.', 'Antybiotyk', 0, 1),
(3, 'Keflex', '21', 'Antybiotyk na recepte', 'Antybiotyk', 1, 9);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `supplements`
--

CREATE TABLE `supplements` (
  `id_supplement` int(11) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `description` varchar(230) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `type` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `activeSubstance` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `supplements`
--

INSERT INTO `supplements` (`id_supplement`, `name`, `price`, `description`, `type`, `activeSubstance`, `user_id`) VALUES
(1, 'Witamina B12', '21.32', 'Nowa formuła witaminy B12', 'Suplement', 'Witamina B12', 1),
(2, 'Witamina D3', '11.32', 'Nowa witamina dostępna w naszej aptece! Witamina D3!', 'Suplement', 'Witamina D3', 1),
(3, 'Witamina C3', '12.32', 'Super nowa formuła Witaminy C3!', 'Suplement', 'Witamina C3', 1),
(4, 'Witamina B2', '11.43', 'Witamina B2', 'Suplement', 'Witamina B2', 1),
(5, 'Witamina K', '12.43', 'Witamina K', 'Suplement', 'Witamina K', 9),
(6, 'Witamina P', '32.11', 'Witamina P', 'Suplement', 'Witamina P', 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `login` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL,
  `password` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `users`
--

INSERT INTO `users` (`user_id`, `login`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'jan', 'jan123'),
(3, 'andrzej', 'andrzej123'),
(4, 'admin2', 'admin2'),
(5, 'jan123', 'janek321'),
(6, 'ada', 'ada123'),
(7, 'ania', 'ania123'),
(8, 'iga', 'iga123'),
(9, 'janek', 'janek123');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `antibiotics`
--
ALTER TABLE `antibiotics`
  ADD PRIMARY KEY (`id_antibiotic`),
  ADD KEY `antibiotics_ibfk_1` (`user_id`);

--
-- Indeksy dla tabeli `supplements`
--
ALTER TABLE `supplements`
  ADD PRIMARY KEY (`id_supplement`),
  ADD KEY `supplements_ibfk_1` (`user_id`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `antibiotics`
--
ALTER TABLE `antibiotics`
  MODIFY `id_antibiotic` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT dla tabeli `supplements`
--
ALTER TABLE `supplements`
  MODIFY `id_supplement` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `antibiotics`
--
ALTER TABLE `antibiotics`
  ADD CONSTRAINT `antibiotics_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);

--
-- Ograniczenia dla tabeli `supplements`
--
ALTER TABLE `supplements`
  ADD CONSTRAINT `supplements_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
