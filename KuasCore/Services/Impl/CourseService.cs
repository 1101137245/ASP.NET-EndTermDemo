using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services.Impl
{
    public class CourseService : ICourseService
    {
        public ICourseDao CourseDao { get; set; }

        public Course AddCourse(Course course)
        {
            CourseDao.AddCourse(course);
            return GetCourseByName(course.Name);
        }

        public void UpdateCourse(Course course)
        {
            CourseDao.UpdateCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            course = CourseDao.GetCourseByName(course.Name);

            if (course != null)
            {
                CourseDao.DeleteCourse(course);
            }
        }

        public IList<Course> GetAllCourse()
        {
            return CourseDao.GetAllCourse();
        }

        public Course GetCourseByName(string name)
        {
            return CourseDao.GetCourseByName(name);
        }

        public Course GetCourseById(string id)
        {
            return CourseDao.GetCourseById(id);
        }
    }
}
