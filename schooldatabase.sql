CREATE TABLE Pupil (
studentID INT  NOT NULL  identity(1,1),
FName NVARCHAR(255),
LName NVARCHAR(255),
Sex NVARCHAR(255),
classID INT NOT NULL,
);

CREATE TABLE Teacher(
teacherID INT primary key NOT NULL identity(1,1),
FName VARCHAR(255),
LName VARCHAR(255),
Sex VARCHAR(255),
subjectID INT, 

);

create table Subjects(
subjectID INT primary key NOT NULL auto_increment,
subName VARCHAR(25),
classID INT ,

);
create table Class(
classID INT NOT NULL auto_increment,
className VARCHAR(25),
PRIMARY KEY(classID)
);

INSERT into Pupil(fname, lname, sex, classID)
values('ana', 'altunashvili', 'female', 1);
INSERT into Pupil(fname, lname, sex, classID)
values('saba', 'maisuradze', 'male', 2);

INSERT into Teacher(fname, lname, sex, subjectID)
values('tamriko', 'maisuradze', 'female', 1);
INSERT into Teacher(fname, lname, sex, subjectID)
values('mamuka', 'adamashvili', 'male', 2);


INSERT into Subjects(subName)
values('biology');
INSERT into Subjects(subName)
values('Sports');

INSERT into Class(className) values('10a');
INSERT into Class(className) values('10b');


Select Teacher.fname 
from Subjects 
join Teacher on Subjects.subjectID = Teacher.subjectID 
join Pupil on Subjects.classID = Pupil.classID
WHERE Pupil.fname = 'saba';