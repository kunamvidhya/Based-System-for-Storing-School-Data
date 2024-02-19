using Based_System_for_Storing_School_Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Based_System_for_Storing_School_Data
{
    [TestClass]
    public class UnitTest1
    {
        private readonly object It;

        [TestMethod]
        public void TestMethod1()
        {
            var mockTeacherRepository = new Mock<ITeacherRepository>();
           var schoolService = new SchoolService(mockTeacherRepository.Object);

            // Act
            var teacher = schoolService.GetTeacherById(1);

            // Assert
            Assert.IsNotNull(teacher);
            Assert.AreEqual("John Doe", teacher);
        }
    }
}
