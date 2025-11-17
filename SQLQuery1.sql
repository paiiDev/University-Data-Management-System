CREATE TABLE Courses (
    course_id INT PRIMARY KEY IDENTITY(1,1), -- Auto increment ID
    course_name NVARCHAR(100) NOT NULL,
    course_code NVARCHAR(50) UNIQUE NOT NULL,
    semester NVARCHAR(20) NOT NULL,
    credits INT NOT NULL,
    instructor_id INT NOT NULL,

    CONSTRAINT FK_Courses_Instructor 
        FOREIGN KEY (instructor_id) REFERENCES Instructor(id)
);
