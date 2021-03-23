using SchoolActivity.Model;
using SchoolActivity.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolActivity.Repository
{
    public class ActivityRepository
    {
        private SchoolActivityContext _context { get; set; }

        public ActivityRepository()
        {
            _context = new SchoolActivityContext();
        }

        public void Add(Activity activity)
        {
            _context.Add(activity);
            _context.SaveChanges();
        }

        public Activity GetById(int id)
        {
            return _context.Activities.Find(id);
        }

        public List<Activity> List(int rows, int skip)
        {
            return _context.Activities
                .Skip(skip)
                .Take(rows)
                .ToList();
        }

        public void Update(Activity activity)
        {
            _context.Activities.Update(activity);
        }

        public void Remove(int id)
        {
            var activity = GetById(id);
            _context.Activities.Remove(activity);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
