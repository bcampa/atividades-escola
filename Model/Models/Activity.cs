using System;
using System.Collections.Generic;

namespace SchoolActivity.Model.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public ICollection<Submission> Submissions { get; } = new List<Submission>();
    }
}
