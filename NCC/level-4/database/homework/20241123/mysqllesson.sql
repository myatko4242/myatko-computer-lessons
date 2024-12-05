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