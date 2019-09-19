using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TaskManager.BusinessLayer;
using TaskManager.Entities;

namespace TaskManager.API.Controllers
{
    public class TaskController : ApiController
    {
        [Route("getall")]
        public IHttpActionResult Get()
        {
            TaskBAL ts = new TaskBAL();
            return Ok(ts.GetTask());
        }
        [Route("getbytaskid/{id:int}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            TaskBAL ts = new TaskBAL();
            return Ok(ts.GetTaskbyId(id));
        }
        [Route("Addtask")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IHttpActionResult Post(Task item)
        {
            TaskBAL ts = new TaskBAL();
            ts.AddTask(item);
            return Ok("Record added");
        }
        [Route("updatebytaskid/{id}")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IHttpActionResult put(Task item)
        {
            TaskBAL ts = new TaskBAL();
            ts.UpdateTask(item);
            return Ok("Record Updated");
        }
        [Route("updateendtask/{id:int}")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IHttpActionResult Put(int id)
        {
            TaskBAL ts = new TaskBAL();
            ts.Endtask(id);
            return Ok("End Task updated");
        }
        [Route("Deletetask/{id:int}")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            TaskBAL ts = new TaskBAL();
            ts.DeleteTask(id);
            return Ok("Record is deleted");
        }
    }
}