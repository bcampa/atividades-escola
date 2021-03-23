using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolActivity.Model.Models;
using SchoolActivity.Repository;
using SchoolActivity.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController : ControllerBase
    {
        private ActivityRepository _activityRepository { get; set; }
        private SubmissionRepository _submissionRepository { get; set; }

        public ActivityController()
        {
            _activityRepository = new ActivityRepository();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_activityRepository.GetById(id));
        }

        [HttpGet]
        [Route("/{id}/submissions")]
        public IActionResult GetSubmissions(int id)
        {
            return Ok(_submissionRepository.GetByActivityId(id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] ActivityCreationRequest request)
        {
            var activity = new Activity
            {
                Description = request.Description,
                DueDate = request.DueDate
            };
            _activityRepository.Add(activity);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Activity activity) 
        {
            _activityRepository.Update(activity);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromQuery] int id)
        {
            _activityRepository.Remove(id);
            return Ok();
        }
    }
}
