using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolActivity.Services
{
    public class SubmissionCreationRequest
    {
        public int ActivityId { get; set; }
        public int StudentId { get; set; }
    }
}
