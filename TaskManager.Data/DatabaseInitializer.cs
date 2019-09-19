using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace TaskManager.Data
{
   
        public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<TaskManagerDataContext>
        {
            protected override void Seed(TaskManagerDataContext context)
            {
                base.Seed(context);

            }
        }
    
}
