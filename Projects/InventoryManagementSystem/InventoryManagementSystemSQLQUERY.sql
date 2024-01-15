create Database Inventory_Management_System;

use Inventory_Management_System

create table Product
(
	id int identity primary key,
	Product_name varchar(50) not null,
	Product_qnty varchar(5) not null
)

select * from Product

create table Purchase
(
	id int identity primary key,
	Purchase_prod varchar(50) not null,
	Purchase_qnty varchar(5) not null,
	Purchase_date Date not null
)

create table Sale
(
	id int identity primary key,
	Sale_prod varchar(50) not null,
	Sale_qnty varchar(5) not null,
	Sale_date Date not null
)

select * from Purchase
select * from Sale