using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolActivity.Model.Models;
using SchoolActivity.Repository;
using SchoolActivity.Services;

namespace SchoolSubmissionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubmissionController : ControllerBase
    {
        private SubmissionRepository _SubmissionRepository { get; set; }

        public SubmissionController()
        {
            _SubmissionRepository = new SubmissionRepository();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(_SubmissionRepository.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] SubmissionCreationRequest request)
        {
            var submission = new Submission
            {
                ActivityId = request.ActivityId,
                StudentId = request.StudentId,
                SubmissionDate = DateTime.Now
            };
            _SubmissionRepository.Add(submission);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Submission submission)
        {
            _SubmissionRepository.Update(submission);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromQuery] int id)
        {
            _SubmissionRepository.Remove(id);
            return Ok();
        }
    }
}
