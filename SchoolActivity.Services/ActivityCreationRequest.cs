using System;

namespace SchoolActivity.Services
{
    public class ActivityCreationRequest
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
