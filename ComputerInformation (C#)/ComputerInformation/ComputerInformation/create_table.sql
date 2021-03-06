﻿CREATE TABLE `comps` (
	`id` INT(11) NOT NULL AUTO_INCREMENT,
	`invent_no` INT(11) NULL DEFAULT NULL,
	`kabinet` VARCHAR(50) NULL DEFAULT NULL,
	`n_comp` VARCHAR(50) NULL DEFAULT NULL,
	`CPU` LONGTEXT NULL DEFAULT NULL,
	`MB` LONGTEXT NULL DEFAULT NULL,
	`GC` LONGTEXT NULL DEFAULT NULL,
	`STOR` LONGTEXT NULL DEFAULT NULL,
	`HDD` LONGTEXT NULL DEFAULT NULL,
	`RAM` LONGTEXT NULL DEFAULT NULL,
	`DEV` LONGTEXT NULL DEFAULT NULL,
	`OS` LONGTEXT NULL DEFAULT NULL,
	`NET` LONGTEXT NULL DEFAULT NULL,
	`MEM` LONGTEXT NULL DEFAULT NULL,
	`SOFT` LONGTEXT NULL DEFAULT NULL,
	PRIMARY KEY (`id`)
)
COLLATE='utf8mb4_general_ci'
ENGINE=InnoDB
;