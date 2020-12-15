using System.Linq;
using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IStudentData
    {
        IEnumerable<Student> GetStudentsByName(string name);
        Student GetById(int id);
        Student Update(Student updatedStudent);
        Student Add(Student newStudent);
        Student Delete(int id);
        int Commit();
        int GetCountOfStudents();
    }
}


