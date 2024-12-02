CREATE DATABASE Practise;                    -- this(--) mean comment and it make the line affected by it invisible to SQL.You can use key like Ctrl+/ to underlined letter to make it invisible. same key to make it visible. 
show databases;                                    -- This code show you what databases you have.
select database();                                 -- This one show what database you are currently using.
drop database practise;                            -- this deleate database.
USE Practise;
CREATE TABLE Cats(name varchar(20),age int);       -- create table name(column name type,column name type);
show tables;         -- s is important. It show what tables it have in database.
desc Cats;           -- show full information of the table Cats.
drop table Cats;         -- delete table Cats. Can check with show tables;. didn't run so still exist.
-- another practise

CREATE TABLE Pastries(pastries varchar(50),quantity int);
show tables;
desc Pastries;
drop table Pastries;

insert into Cats(name,age)        -- it is important to add column name before values. Order also matter.
values ('Jetson',7);
select * from Cats;                 --  don't forget from. This show what values are added in the table you select from.
insert into Cats(name,age)
values ('Jerry',8),('Tom',9),('Mary',2);       -- this is how you add multipule rows of data. careful with the '' and , and () because it will cause error if misplace.

-- +-------+------------+------+-----+---------+-------+
-- | Field | Type       | Null | Key | Default | Extra |
-- +-------+------------+------+-----+---------+-------+
-- | name  | varchar(5) | YES  |     | NULL    |       |
-- | age   | int(11)    | YES  |     | NULL    |       |
-- +-------+------------+------+-----+---------+-------+          NUll mean the value is not known and if you leave it like that,INSERT INTO cats() values (); you can do stuff like that.
-- the sloution
CREATE TABLE cats2
  (name VARCHAR(100) NOT NULL,
 age  INT NOT NULL); 

--  +-------+--------------+------+-----+---------+-------+
-- | Field | Type         | Null | Key | Default | Extra |
-- +-------+--------------+------+-----+---------+-------+
-- | name  | varchar(100) | NO   |     | NULL    |       |
-- | age   | int(11)      | NO   |     | NULL    |       |
-- +-------+--------------+------+-----+---------+-------+            the default place is to set default values.
-- for example

CREATE TABLE cats3
  ( name VARCHAR(100) DEFAULT 'unnamed',
     age  INT DEFAULT 99); 

--      +-------+------------+------+-----+---------+-------+
-- | Field | Type       | Null | Key | Default | Extra |
-- +-------+------------+------+-----+---------+-------+
-- | name  |varchar(100)| YES  |     | unnamed |       |
-- | age   |int         | YES  |     | 99      |       |
-- +-------+------------+------+-----+---------+-------+
--                                                              key is the unique identifier like primary key. IT is needed to make sure there are ways to differentiate between two person with same name or similar cases.

create table unique_cats(cat_id int not null primary key,
                       name varchar(20) not null default 'not named',
                         age int not null);                   
                                               -- don't forget to add '' behind default 
     --  # PRIMARY KEYS CANNOT BE NULL #

-- another way to do this is

CREATE TABLE unique_cats (cat_id INT NOT NULL,
  name VARCHAR(100) not null default 'not named', 
  age INT not null,
  PRIMARY KEY(cat_id));

  CREATE TABLE unique_cats3 (cat_id INT AUTO_INCREMENT,
    name VARCHAR(100),
    age INT,
    PRIMARY KEY (cat_id));        -- AUTO_INCREMENT make the new cat id you add to increase in order.


-- QUESTION FROM SQL COURSE

-- Define an Employees table, with the following fields:

 

-- id - number(automatically increments) and  primary key
-- last_name - text, mandatory
-- first_name - text, mandatory
-- middle_name - text, not mandatory
-- age - number mandatory
-- current_status - text, mandatory, defaults to 'employed'


-- ANSWER

CREATE TABLE Employees(employee_id integer not null Auto_increment primary key,
last_name varchar(20) not null,
first_name varchar(20) not null,
middle_name varchar(20),
age integer not null,
current_status varchar(20) not null default'employed');