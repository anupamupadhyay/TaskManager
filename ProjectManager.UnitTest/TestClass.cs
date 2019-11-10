using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectManagerAPI.Controllers;
using ProjectManagerDAL;


namespace ProjectManager.UnitTest
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(1 == 1);
        }
        [Test]
        public void ValidateAllTasks()
        {
            TaskDAL pobj = new TaskDAL();
            List<ProjectManagerDAL.Task> tasks = pobj.GetAllTask();
            foreach (var x in tasks)
            {
                Assert.IsNotNull(x.Task_Id);
                Assert.IsNotNull(x.Task_Name);
                Assert.IsNotNull(x.Start_Date);
                Assert.IsNotNull(x.Priority);
                Assert.IsNotNull(x.End_Date);
                Assert.IsNotNull(x.Project_Id);
            }
        }
        [Test]
        public void ValidateTaskById()
        {
            TaskDAL pobj = new TaskDAL();
            var p = pobj.GetTaskById(2);

            Assert.AreEqual(p.Task_Id, 2);
            Assert.AreEqual(p.Task_Name, "Testing");
            Assert.AreEqual(p.Project_Id, 1);
        }
        [Test]
        public void ValidateAllProjects()
        {
            ProjectDAL pobj = new ProjectDAL();
            List<ProjectManagerDAL.Project> project = pobj.GetAllProjects();
            foreach (var x in project)
            {
                Assert.IsNotNull(x.Project_Id);
                Assert.IsNotNull(x.Project_Name);
                Assert.IsNotNull(x.Start_Date);
                Assert.IsNotNull(x.Priority);
                Assert.IsNotNull(x.End_Date);
                Assert.IsNotNull(x.Project_Id);
            }
        }
        [Test]
        public void ValidateProjectById()
        {
            ProjectDAL pobj = new ProjectDAL();
            var p = pobj.GetProjectById(1);

            Assert.AreEqual(p.Project_Id, 1);
            Assert.AreEqual(p.Project_Name, "My Project");            
            Assert.AreEqual(p.Priority, 5);            
        }
        [Test]
        public void TestAddUser()
        {
            UserDAL pobj = new UserDAL();
            var p = pobj.AddUser(new User { Employee_id = 1, First_Name="Anupam",
            Last_Name = "U"});

        }
        [Test]
        public void TestViewProjects()
        {
            ProjectDAL pobj = new ProjectDAL();
            var p = pobj.GetAllProjects();

        }
        [Test]
        public void TestViewTasks()
        {
            TaskDAL pobj = new TaskDAL();
            var p = pobj.GetAllTask();

        }
    }
}
