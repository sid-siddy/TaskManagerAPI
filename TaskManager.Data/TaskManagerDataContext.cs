using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TaskManager.Entities;

namespace TaskManager.Data
{
    public class TaskManagerDataContext : DbContext
    {
        public TaskManagerDataContext() : base("name=Taskdatasource")
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}
