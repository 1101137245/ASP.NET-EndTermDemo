using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Services
{
    public interface ICourseService
    {
        Course AddCourse(Course course);

        void UpdateCourse(Course course);

        void DeleteCourse(Course course);

        IList<Course> GetAllCourse();

        Course GetCourseByName(string name);

        Course GetCourseById(string id);
    }
}
