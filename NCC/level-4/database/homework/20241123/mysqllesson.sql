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

-- side note proper use of this ('') 
create table chess(name varchar(30));
insert into chess(name)
values ('King'),
       ('King\'s wife');

      --  name
      --  King
      --  King's wife                              this is how it will come out. 
                                                  -- it better to use '' for varchar,etc instead of "". 
                                                  --  if it is something like 's just use \'s.


                        -- For next lesson CRUD(Create,Read,Update,Delete) I have to drop all tables.
                        -- have dropped all the tables in the my Sql app.

create table Cats(
cat_id int auto_increment primary key,
name varchar(40),
breed varchar(40),
age int);

insert into Cats (name,breed,age)
values ('Ringo', 'Tabby', 4),
       ('Cindy', 'Maine Coon', 10),
       ('Dumbledore', 'Maine Coon', 11),
       ('Egg', 'Persian', 4),
       ('Misty', 'Tabby', 13),
       ('George Michael', 'Ragdoll', 9),
       ('Jackson', 'Sphynx', 7);
 select * from Cats;                         -- select is a form of read and * means show me all the columns.
                        --  so we can replace * with the column name of the one we want to know if we want to.

select name from Cats;
select age from Cats;
select breed from Cats;      -- like this. also you can select multipule columns like this.

select name,age from Cats;

select * from Cats where age=4;    -- where can narrow things down and have alots of use other than select, like update and delete.
                  -- also there no need to see age whenever you do age=n.
select name from Cats where age=4;
select name,breed from Cats where age=4;  -- also you can search for other specific stuff you want with where.
select * from Cats where name='Egg';    -- like this for example

-- these are the answer to the questions of rapid fire from video
-- the questions are: 1 show cat_id, 2 show name and breed,3 show name and age of tabby cats,
-- 4 show cat_id that is same as age
select cat_id from Cats;
select name,breed from Cats;
select name,age from Cats where breed='Tabby';
select cat_id,age from Cats where cat_id=age;
-- alias is a way to rename the column for a single run meaning for it temporary. 
-- it is use to make long column name shorter in long code where it need to be typed a lot.
-- but other than that it doesn't have much use.
select cat_id as id,name,breed from Cats;      -- when you run it will have id as column name but
select * from Cats;        -- when you run the next line it will return back to cat_id as column name.
-- we gonna recreate table again for update.
CREATE TABLE Employees(employee_id integer not null Auto_increment primary key,
last_name varchar(20) not null,
first_name varchar(20) not null,
middle_name varchar(20),
age integer not null,
current_status varchar(20) not null default'employed');
insert into Employees(first_name,last_name,age)
values ('Ditty','Joe',36);        -- run the values 3 times

update Employees set current_status='don\'t know',last_name='who care'; -- this gonna change three of their last name and status.
-- it is update (table) set (column)=n. usually you need to narrow down so need to use it with where.
-- it a good habit to select before updating to check the content.
update Employees set current_status='jail',last_name='bro'
where employee_id=2;         -- this is how it usually use to update just what you need instead of entire row.
update Cats set age=14
where name='Misty';
update Cats set name='Jack' where name='Jackson';    -- question change cat Jackson's name into Jack.
update Cats set breed='British Shorthair'
where name='Ringo';          -- question change Ringo's breed to British Shorthair.
update Cats set age=12
where breed='Maine Coon';     -- question change cats with breed Maine Coon, age to 12.
delete from Cats 
where name='Egg';    -- this delete a single row from cat table
                     -- delete from (table)
                     -- where column='value';
delete from Cats;   -- didn't run this.this will delete all row from cats but the table and columns will stay the same.
delete from Cats
where age=4;       -- delete all cats that are age 4.
delete from Cats
where age=cat_id;  -- delete all cats that have same age as it's id.
delete from Cats;  -- delete all cats.

-- CRUD practise lesson

create database shirt_db;
show databases;
use shirt_db;

create table shirts
(shirt_id integer auto_increment primary key,
article varchar(20) not null,
colour varchar(20)not null,
shirt_size varchar(20) not null,
last_worn integer not null);
show tables;

insert into shirts(article,colour,shirt_size,last_worn)
values ('t-shirt', 'white', 'S', 10),
('t-shirt', 'green', 'S', 200),
('polo shirt', 'black', 'M', 10),
('tank top', 'blue', 'S', 50),
('t-shirt', 'pink', 'S', 0),
('polo shirt', 'red', 'M', 5),
('tank top', 'white', 'S', 200),
('tank top', 'blue', 'M', 15);
select * from shirts;
-- add a purple polo shirt size medium last worn 50 days
insert into shirts (article,colour,shirt_size,last_worn)
values ('polo shirt','purple','M',50);
-- show only shirt and colour
select article,colour from shirts;
-- show everything of medium size shirt except id
select article,colour,shirt_size,last_worn from shirts
where shirt_size = 'M';
-- update all polo shirts size to Large
update shirts set shirt_size = 'L'
where article='polo shirt';
-- update shirt that was worn 15 days ago to 0
update shirts set last_worn = 0
where last_worn= 15;
-- update all white shirt to size XS and colour off white
update shirts set shirt_size = 'XS',colour = 'off white'
where colour = 'white';
-- delete shirt that was worn 200 days ago
delete from shirts
where last_worn = 200;
-- delete all tank top
delete from shirts
where article = 'tank top';
-- delete all shirts
delete from shirts;
-- drop the table
drop table shirts;

-- #####String function#####

create database book_shop;
use book_shop;

create table books
(book_id int auto_increment primary key,
title varchar(100),
author_fname varchar(100),
author_lname varchar(100),
released_year int,
stock_quantity int,
pages int);

insert into books (title,author_fname,author_lname,released_year,stock_quantity,pages)
values ('The Namesake', 'Jhumpa', 'Lahiri', 2003, 32, 291),
('Norse Mythology', 'Neil', 'Gaiman',2016, 43, 304),
('American Gods', 'Neil', 'Gaiman', 2001, 12, 465),
('Interpreter of Maladies', 'Jhumpa', 'Lahiri', 1996, 97, 198),
('A Hologram for the King: A Novel', 'Dave', 'Eggers', 2012, 154, 352),
('The Circle', 'Dave', 'Eggers', 2013, 26, 504),
('The Amazing Adventures of Kavalier & Clay', 'Michael', 'Chabon', 2000, 68, 634),
('Just Kids', 'Patti', 'Smith', 2010, 55, 304),
('A Heartbreaking Work of Staggering Genius', 'Dave', 'Eggers', 2001, 104, 437),
('Coraline', 'Neil', 'Gaiman', 2003, 100, 208),
('What We Talk About When We Talk About Love: Stories', 'Raymond', 'Carver', 1981, 23, 176),
("Where I'm Calling From: Selected Stories", 'Raymond', 'Carver', 1989, 12, 526),
('White Noise', 'Don', 'DeLillo', 1985, 49, 320),
('Cannery Row', 'John', 'Steinbeck', 1945, 95, 181),
('Oblivion: Stories', 'David', 'Foster Wallace', 2004, 172, 329),
('Consider the Lobster', 'David', 'Foster Wallace', 2005, 92, 343);
select * from books;
select concat('pic','kle');        -- this is used to stick letters together and you need to use ''.
select concat(author_fname,' ',author_lname) as author_name from books;    
-- this is same but if you use column from table you need to add ' from table'. if you want to give it a name use AS.
select concat_ws('-',title,author_fname,author_lname) from books;
-- this one ws use the first '-' as between every value (title-AF-AL). 
-- also this doesn't have AS so name will be "concat_ws('-',title,author_fname,author_lname)"