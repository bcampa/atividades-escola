using System;

namespace SchoolActivity.Model.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int StudentId { get; set; }
        public decimal? Score { get; set; }
        public DateTime SubmissionDate { get; set; }

        public Activity Activity { get; set; }
    }
}
