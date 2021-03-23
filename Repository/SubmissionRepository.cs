using SchoolActivity.Model;
using SchoolActivity.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolActivity.Repository
{
    public class SubmissionRepository
    {
        private SchoolActivityContext _context { get; set; }

        public SubmissionRepository()
        {
            _context = new SchoolActivityContext();
        }

        public void Add(Submission submission)
        {
            _context.Add(submission);
            _context.SaveChanges();
        }

        public Submission GetById(int id)
        {
            return _context.Submissions.Find(id);
        }

        public List<Submission> GetByActivityId(int activityId)
        {
            return _context.Submissions
                .Where(x => x.ActivityId == activityId)
                .ToList();
        }

        public void Update(Submission submission)
        {
            _context.Submissions.Update(submission);
        }

        public void Remove(int id)
        {
            var submission = GetById(id);
            _context.Submissions.Remove(submission);
            _context.SaveChanges();
        }
    }
}
