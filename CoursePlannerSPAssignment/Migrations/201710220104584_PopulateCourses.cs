namespace CoursePlannerSPAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D111', '1', '1', 1, '', 1, 'Data Fundamentals')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I121', '1', '1', 2, '', 1, 'Systems Analysis Fundamentals')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T111', '1', '1', 3, '', 1, 'Computer Fundamentals')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I101', '1', '1', 2, '', 1, 'Information Systems')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D101', '2', '1', 1, '', 1, 'Software Development')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T101', '2', '1', 3, '', 1, 'Network Fundamentals')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I111', '2', '1', 2, '', 1, 'Web Fundamentals')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I102', '2', '1', 2, '', 1, 'User Support')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D211', '1', '2', 1, 'D111', 1, 'Database Development')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I203', '1', '2', 2, 'I101', 0, 'Digital Multimedia')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I211', '1', '2', 2, 'I111', 0, 'eCommerce Systems')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D201', '1', '2', 1, 'D101', 0, 'Advanced Programming')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T201', '1', '2', 3, 'T101', 0, 'Network Services')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T205', '1', '2', 3, '', 0, 'Networks - Cisco ITN')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T206', '1', '2', 3, 'T205', 0, 'Networks - Cisco RSE')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I221', '2', '2', 2, 'I121', 1, 'Analysis & Design')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I202', '2', '2', 2, 'I102', 1, 'IT Project Management')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I213', '2', '2', 2, 'I111', 0, 'Dynamic Web Solutions')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D201', '2', '2', 1, 'D101', 0, 'Advanced Programming')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D202', '2', '2', 1, 'D201', 0, 'Software Process and Planning')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T205', '2', '2', 3, '', 0, 'Networks - Cisco ITN')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T206', '2', '2', 3, 'T205', 0, 'Networks - Cisco RSE')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T211', '2', '2', 3, 'T111', 0, 'Systems Security')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I301', '1', '3', 2, '240 Credits', 1, 'Professional Practice')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I302', '1', '3', 2, 'I301', 1, 'Industry Project')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I321', '1', '3', 2, 'I221', 0, 'Advanced Systems Analysis')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D301', '1', '3', 1, 'D201', 0, 'Software Engineering')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D311', '1', '3', 1, 'D211', 0, 'Advanced Database Concepts')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T301', '1', '3', 3, 'T201', 0, 'Network Design')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T302', '1', '3', 3, '', 0, 'Networks Cisco')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T311', '1', '3', 3, 'T211', 0, 'Systems Administration')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I302', '2', '3', 2, 'I301', 1, 'Industry Project')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I301', '2', '3', 2, '240 Credits', 1, 'Professional Practice')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T302', '2', '3', 3, '', 0, 'Networks Cisco')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('T311', '2', '3', 3, 'T211', 0, 'Systems Administration')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('I303', '2', '3', 2, 'I202', 0, 'Managerial Practice')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D303', '2', '3', 1, 'D101', 0, 'Java Mobile & Web')");
            Sql("INSERT INTO Courses (CourseCode, Semester, Year, TopicId, PreReq, Compulsory, CourseName) VALUES ('D311', '2', '3', 1, 'D211', 0, 'Advanced Database Concepts')");

        }

        public override void Down()
        {
        }
    }
}
