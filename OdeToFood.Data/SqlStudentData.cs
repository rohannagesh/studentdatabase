using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Data
{
    public class SqlStudentData : IStudentData
    {
        private readonly StudentDbContext db;

        public SqlStudentData(StudentDbContext db)
        {
            this.db = db;
        }

        public Student Add(Student newRestaurant)
        {
            db.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Student Delete(int id)
        {
            var student = GetById(id);
            if(student != null)
            {
                db.Students.Remove(student);
            }
            return student;
        }

        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }

        public int GetCountOfStudents()
        {
            return db.Students.Count();
        }

        public IEnumerable<Student> GetStudentsByName(string name)
        {
            var query = from r in db.Students
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Student Update(Student updatedRestaurant)
        {
            var entity = db.Students.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}
