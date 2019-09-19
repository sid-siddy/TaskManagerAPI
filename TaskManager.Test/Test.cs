using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.BusinessLayer;
using TaskManager.Entities;

namespace TaskManager.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Getall()
        {
            TaskBAL obj = new TaskBAL();
            int count = obj.GetTask().Count();
            Assert.Greater(count, 0);
        }
        [Test]
        public void Getbytask()
        {
            TaskBAL obj = new TaskBAL();
            List<Task> Ts = obj.GetTask();
            Task count = obj.GetTaskbyId(Ts[0].TaskId);
            Assert.IsNotNull(count);
        }
        [Test]
        public void AddTask()
        {
            TaskBAL obje = new TaskBAL();
            int count = obje.GetTask().Count();
            Task T = (new Task { ParentName = "ParentTaskstest", TaskName = "Testtaskname", Priority = 15, SDate = DateTime.Now, EDate = DateTime.Now });
            obje.AddTask(T);
            int count1 = obje.GetTask().Count();
            Assert.AreEqual(count1, count + 1);
        }
        [Test]
        public void updateTask()
        {
            TaskBAL obj = new TaskBAL();
            List<Task> Ts = obj.GetTask();
            Task Taskgetbyid = obj.GetTaskbyId(Ts[0].TaskId);
            int count = obj.GetTask().Count();
            Task T = (new Task { TaskId = Taskgetbyid.TaskId, ParentName = "ParentTaskstest", TaskName = "Testtaskname", Priority = 15, SDate = DateTime.Now, EDate = DateTime.Now });
            obj.UpdateTask(T);
            int count1 = obj.GetTask().Count();
            List<Task> TS1 = obj.GetTask();
            Assert.AreEqual(T.TaskName, TS1[0].TaskName);
        }
        [Test]
        public void DeleteTask()
        {
            TaskBAL obj = new TaskBAL();
            List<Task> Ts = obj.GetTask();
            Task Taskgetbyid = obj.GetTaskbyId(Ts[0].TaskId);
            int count1 = obj.GetTask().Count(); 
            obj.DeleteTask(Taskgetbyid.TaskId);
            int count2 = obj.GetTask().Count();
            Assert.AreEqual(count2, count1 - 1);
        }
    }
}
