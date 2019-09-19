using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManager.Data;
using TaskManager.Entities;
namespace TaskManager.BusinessLayer
{
    public class TaskBAL
    {
        public void AddTask(Task item)
        {
            using (TaskManagerDataContext db = new TaskManagerDataContext())
            {
                db.Tasks.Add(item);
                db.SaveChanges();
            }
        }
        public List<Task> GetTask()
        {
            using (TaskManagerDataContext db = new TaskManagerDataContext())
            { 
                return db.Tasks.ToList();
            }
        }
        public Task GetTaskbyId(int id)
        {
            using (TaskManagerDataContext db = new TaskManagerDataContext())
            {
                return db.Tasks.SingleOrDefault(k => k.TaskId == id);
            }
        }

        public void DeleteTask(int Id)
        {
            using (TaskManagerDataContext db = new TaskManagerDataContext())
            {
                Task ts = db.Tasks.Where(d => d.TaskId == Id).First();
                db.Tasks.Remove(ts);
                db.SaveChanges();
            }
        }
        public void UpdateTask(Task task)
        {
            using (TaskManagerDataContext db = new TaskManagerDataContext())
            {
                Task taskupdate = db.Tasks.SingleOrDefault(x => x.TaskId == task.TaskId);
                taskupdate.ParentName = task.ParentName;
                taskupdate.TaskName = task.TaskName;
                taskupdate.Priority = task.Priority;
                taskupdate.SDate = task.SDate;
                taskupdate.EDate = task.EDate;
                db.SaveChanges();
            }
        }
        public void Endtask(int id)
        {
            using (TaskManagerDataContext db = new TaskManagerDataContext())
            {
                Task ts = db.Tasks.SingleOrDefault(x => x.TaskId == id);
                ts.flag = true;
                ts.EDate = DateTime.Now;
                db.SaveChanges();
            }
        }
    }
}
