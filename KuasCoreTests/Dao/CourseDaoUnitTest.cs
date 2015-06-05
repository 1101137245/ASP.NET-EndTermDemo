using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCoreTests.Dao
{
    [TestClass]
    public class CourseDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCorePointcut.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        public ICourseDao CourseDao { get; set; }


        [TestMethod]
        public void TestCourseDao_AddCourse()
        {
            Course course = new Course();
            course.Id = "UnitTests";
            course.Name = "單元測試";
            course.Description = "請做出單元測試";
            CourseDao.AddCourse(course);

            Course dbCourse = CourseDao.GetCourseByName(course.Name);
            Assert.IsNotNull(dbCourse);
            Assert.AreEqual(course.Name, dbCourse.Name);

            Console.WriteLine("課程編號為 = " + dbCourse.Id);
            Console.WriteLine("課程名稱為 = " + dbCourse.Name);
            Console.WriteLine("課程描述為 = " + dbCourse.Description);

            CourseDao.DeleteCourse(dbCourse);
            dbCourse = CourseDao.GetCourseByName(course.Name);
            Assert.IsNull(dbCourse);
        }

    }
}
