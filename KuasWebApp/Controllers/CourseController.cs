using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace KuasWebApp.Controllers
{
    public class CourseController : ApiController
    {

        public ICourseService CourseService { get; set; }

        [HttpPost]
        public Course AddCourse(Course course)
        {
            CheckCourseIsNotNullThrowException(course);

            try
            {
                return CourseService.AddCourse(course);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut]
        public Course UpdateCourse(Course course)
        {
            CheckCourseIsNullThrowException(course);

            try
            {
                CourseService.UpdateCourse(course);
                return CourseService.GetCourseByName(course.Name);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete]
        public void DeleteEmployee(Course course)
        {
            try
            {
                CourseService.DeleteCourse(course);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet]
        public IList<Course> GetAllCourse()
        {
            return CourseService.GetAllCourse();
        }

        [HttpGet]
        public Course GetCourseById(string id)
        {
            var course = CourseService.GetCourseById(id);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

        [HttpGet]
        [ActionName("Name")]
        public Course GetCourseByName(string input)
        {
            var course = CourseService.GetCourseByName(input);

            if (course == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return course;
        }

        /// <summary>
        ///     檢查課程資料是否存在，如果不存在則拋出錯誤.
        /// </summary>
        /// <param name="course">
        ///     課程資料.
        /// </param>
        private void CheckCourseIsNullThrowException(Course course)
        {
            Course dbCourse = CourseService.GetCourseById(course.Id);

            if (dbCourse == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        ///     檢查課程資料是否存在，如果存在則拋出錯誤.
        /// </summary>
        /// <param name="course">
        ///     課程資料.
        /// </param>
        private void CheckCourseIsNotNullThrowException(Course course)
        {
            Course dbCourse = CourseService.GetCourseById(course.Id);

            if (dbCourse != null)
            {
                throw new HttpResponseException(HttpStatusCode.Conflict);
            }
        }

    }
}