using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao
    {
        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public void AddCourse(Course course)
        {
            string command = @"INSERT INTO Course (Course_ID, Course_Name, Course_Description, Course_Date, Course_Time, Course_Aboard, Course_Getoff, Course_Number, Course_Phone, Course_Price) VALUES (@Id, @Name, @Description, @Date, @Time, @Aboard, @Getoff, @Number, @Phone, @Price);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;
            parameters.Add("Name", DbType.String).Value = course.Name;
            parameters.Add("Date", DbType.String).Value = course.Date;
            parameters.Add("Time", DbType.String).Value = course.Time;
            parameters.Add("Aboard", DbType.String).Value = course.Aboard;
            parameters.Add("Getoff", DbType.String).Value = course.Getoff;
            parameters.Add("Number", DbType.String).Value = course.Number;
            parameters.Add("Phone", DbType.String).Value = course.Phone;
            parameters.Add("Price", DbType.String).Value = course.Price;
            parameters.Add("Description", DbType.String).Value = course.Description;

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateCourse(Course course)
        {
            string command = @"UPDATE Course SET Course_Name = @Name, Course_Description = @Description ,Course_Date = @Date, Course_Time = @Time, Course_Aboard = @Aboard, Course_Getoff = @Getoff, Course_Number = @Number, Course_Phone = @Phone, Course_Price = @Price WHERE Course_Id = @Id;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;
            parameters.Add("Name", DbType.String).Value = course.Name;
            parameters.Add("Description", DbType.String).Value = course.Description;
            parameters.Add("Date", DbType.String).Value = course.Date;
            parameters.Add("Time", DbType.String).Value = course.Time;
            parameters.Add("Aboard", DbType.String).Value = course.Aboard;
            parameters.Add("Getoff", DbType.String).Value = course.Getoff;
            parameters.Add("Number", DbType.String).Value = course.Number;
            parameters.Add("Phone", DbType.String).Value = course.Phone;
            parameters.Add("Price", DbType.String).Value = course.Price;

            ExecuteNonQuery(command, parameters);
        }

        public void DeleteCourse(Course course)
        {
            string command = @"DELETE FROM Course WHERE Course_Id = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Course> GetAllCourse()
        {
            string command = @"SELECT * FROM Course ORDER BY Course_Id ASC";
            IList<Course> course = ExecuteQueryWithRowMapper(command);
            return course;
        }

        public Course GetCourseByName(string name)
        {
            string command = @"SELECT * FROM Course WHERE Course_Name = @Name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Name", DbType.String).Value = name;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }

        public Course GetCourseById(string id)
        {
            string command = @"SELECT * FROM Course WHERE Course_ID = @id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("id", DbType.String).Value = id;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }
    }
}
