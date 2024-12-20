create table Student;
insert into Student (Studen_id,first_name,last_name,age)
values ('S1','Richart','Mickal',16);


-- chat gpt code

CREATE TABLE student (
    student_id VARCHAR(10) PRIMARY KEY, 
    first_name VARCHAR(50) NOT NULL, 
    last_name VARCHAR(50) NOT NULL, 
    age INT DEFAULT 18 CHECK (age > 0 AND age < 150)
);

INSERT INTO student (student_id, first_name, last_name, age)
VALUES ('S1', 'Richart', 'Mickal', 16);
